//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static ReflectionFlags;

    partial class Reflections
    {        
        /// <summary>
        /// For a generic type or reference to a generic type, retrieves the generic type definition;
        /// otherwise, returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<Type> GenericDefinition(this Type t)
        {
            var effective = t.EffectiveType();
            if(effective.IsConstructedGenericType)
                return effective.GetGenericTypeDefinition();
            else if(effective.IsGenericTypeDefinition)
                return effective;
            else
                return default;            
        }

        /// <summary>
        /// Determines whether a type is anonymous
        /// </summary>
        /// <param name="src">The type to test</param>
        /// <remarks>
        /// Lifted from: https://github.com/NancyFx/Nancy/blob/master/src/Nancy/ViewEngines/Extensions.cs
        /// </remarks>
        public static bool IsAnonymous(this Type src)
            => src == null ? false : src.GetTypeInfo().IsGenericType
                    && (src.GetTypeInfo().Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic
                    && (src.Name.StartsWith("<>", StringComparison.OrdinalIgnoreCase) || src.Name.StartsWith("VB$", StringComparison.OrdinalIgnoreCase))
                    && (src.Name.Contains("AnonymousType") || src.Name.Contains("AnonType"))
                    && src.GetTypeInfo().GetCustomAttributes(typeof(CompilerGeneratedAttribute)).Any();

        /// <summary>
        /// Determines whether a type has a name
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsNamed(this Type t)
            => !t.IsAnonymous();

        /// <summary>
        /// Determines whether the type is an option type and if so returns the underlying option
        /// type encapsulated within an option ( ! ). Otherwise, none
        /// </summary>
        /// <param name="candidate">the type to test</param>
        [MethodImpl(Inline)]
        public static bool IsOption(this Type candidate)
            => candidate.Realizes<IOption>();

        /// <summary>
        /// Attempts to retrieve a name-identified field from a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="name">The name of the field</param>
        /// <param name="declared">Whether the field is required to be declared by the source type</param>
        public static Option<FieldInfo> Field(this Type src, string name)
            => src.Fields().FirstOrDefault(f => f.Name == name);

        public static object FieldValue(this Type src, string name, object instance = null)
            => src.Fields().FirstOrDefault(f => f.Name == name)?.GetValue(instance);

        /// <summary>
        /// Selects the public and non-public static fields declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredInstanceFields(this Type t)
            => t.GetFields(BF_DeclaredInstance);

        /// <summary>
        /// Selects all instance/static and public/non-public fields inhertited by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> InheritedFields(this Type t)
            => t.Fields().Except(t.DeclaredFields());

        /// <summary>
        /// Retrieves the public instance Fields declared by a supertype
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> InheritedPublicFields(this Type src)
            => src.BaseType?.GetFields(BF_AllPublicInstance) ?? new FieldInfo[] { };

        /// <summary>
        /// Retrieves all public instance Fields declared or inherited by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> PublicFields(this Type t)
            => t.InheritedPublicFields().Union(t.GetFields());

        /// <summary>
        /// Attempts to retrieves a static field by name, irrespective of its visibility
        /// </summary>
        /// <param name="t">The declaring type</param>
        /// <param name="name">The name of the method</param>
        public static Option<FieldInfo> DeclaredStaticField(this Type t, string name) 
            => t.DeclaredFields().Static().Where(f => f.Name == name).FirstOrDefault();

        /// <summary>
        /// Retrieves a public or non-public setter for a property if it exists
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static Option<MethodInfo> Setter(this PropertyInfo p)
            => p.GetSetMethod() ?? p.GetSetMethod(true);

        /// <summary>
        /// Retrieves a public or non-public getter for a property if it exists
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static Option<MethodInfo> Getter(this PropertyInfo p)
            => p.GetGetMethod() ?? p.GetGetMethod(true);

        /// <summary>
        /// Selects the first method found on the type, if any, that has a specified name
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="name">The name to match</param>
        public static Option<MethodInfo> Method(this Type src, string name)
            => src.DeclaredMethods().WithName(name).FirstOrDefault();

        public static IEnumerable<object> Values(this IEnumerable<FieldInfo> src, object o = null)
            => src.Select(x => x.GetValue(o));

        public static IEnumerable<T> Values<T>(this IEnumerable<FieldInfo> src, object o = null)
            => src.Select(x => x.GetValue(o)).Where(x => x is T).Cast<T>();

        /// <summary>
        /// Retrieves a type's default constructor, if present; otherwise, none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<ConstructorInfo> DefaultConstructor(this Type t)
            => t.GetConstructor(BF_DeclaredInstance, null, new Type[] { }, new ParameterModifier[] { });

        /// <summary>
        /// Retrieves the public properties declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="mit">The instance type</param>
        /// <param name="requireSetters">Whether the existence of setters are requied to satisfy matches</param>
        public static IEnumerable<PropertyInfo> DeclaredPublicProperties(this Type t, bool requireSetters = false)
                => t.GetProperties(BF_Declared) .Where(p => !p.IsIndexer() && (requireSetters ? p.HasSetter() : true));
            
        /// <summary>
        /// Retrieves the public instance properties declared by a supertype
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<PropertyInfo> InheritedPublicProperties(this Type t, bool requireSetters = false)
            => t.BaseType?.GetProperties(BF_AllPublicInstance)
                        .Where(p => !p.IsIndexer() && (requireSetters ? p.HasSetter() : true))
                        ?? new PropertyInfo[] { };

        /// <summary>
        /// Retrieves the inheritance chain for a specifed type, up to, but not including, <see cref="object"/>
        /// </summary>
        /// <param name="child">The type to examine</param>
        public static IEnumerable<Type> BaseTypes(this Type child)
        {
            if (child.BaseType != null && child.BaseType != typeof(object))
            {
                var parent = child.BaseType;
                yield return parent;

                foreach (var grandfather in BaseTypes(parent))
                    yield return grandfather;
            }
        }

        /// <summary>
        /// Retrieves all public properties exposed by a type and appropriately handles interface inheritance
        /// </summary>
        /// <param name="type">The type to examine</param>
        /// <remarks>
        /// Taken from: http://stackoverflow.com/questions/358835/getproperties-to-return-all-properties-for-an-interface-inheritance-hierarchy
        /// </remarks>   
        public static PropertyInfo[] PublicInstanceProperties(this Type type)
        {
            if (type.IsInterface)
            {
                var propertyInfos = new List<PropertyInfo>();

                var considered = new List<Type>();
                var queue = new Queue<Type>();
                considered.Add(type);
                queue.Enqueue(type);
                while (queue.Count > 0)
                {
                    var subType = queue.Dequeue();
                    foreach (var subInterface in subType.Interfaces())
                    {
                        if (considered.Contains(subInterface)) continue;

                        considered.Add(subInterface);
                        queue.Enqueue(subInterface);
                    }

                    var typeProperties = subType.GetProperties(
                        BindingFlags.FlattenHierarchy
                        | BindingFlags.Public
                        | BindingFlags.Instance);

                    var newPropertyInfos = typeProperties
                        .Where(x => !propertyInfos.Contains(x));

                    propertyInfos.InsertRange(0, newPropertyInfos);
                }

                return propertyInfos.ToArray();
            }

            return type.GetProperties(BindingFlags.FlattenHierarchy
                | BindingFlags.Public | BindingFlags.Instance);
        }

        /// <summary>
        /// Retrieves the values of a type's public instance properties
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="o">The type instance</param>
        public static IReadOnlyDictionary<string, object> PropertyValues(this Type t, object o)
            => map(props(o), p => (p.Name, p.GetValue(o))).ToReadOnlyDictionary();

        /// <summary>
        /// Recursively close an IEnumerable generic type
        /// </summary>
        /// <param name="stype">The sequence type</param>
        /// <remarks>
        /// Adapted from https://blogs.msdn.microsoft.com/mattwar/2007/07/30/linq-building-an-iqueryable-provider-part-i/
        /// </remarks>
        public static Option<Type> CloseEnumerableType(this Type stype)
        {
            if (stype == typeof(string))
                return null;

            if (stype.IsArray)
                return typeof(IEnumerable<>).MakeGenericType(stype.GetElementType());

            if (stype.IsGenericType)
            {
                foreach (var arg in stype.GetGenericArguments())
                {
                    var enumerable = typeof(IEnumerable<>).MakeGenericType(arg);
                    if (enumerable.IsAssignableFrom(stype))
                        return enumerable;
                }
            }

            var interfaces = stype.Interfaces().ToList();
            if (interfaces.Count > 0)
            {
                foreach (var i in interfaces)
                {
                    var ienum = CloseEnumerableType(i);
                    if (ienum.Exists)
                        return ienum;
                }
            }

            if (stype.BaseType != null && stype.BaseType != typeof(object))
                return CloseEnumerableType(stype.BaseType);
            return null;
        }

        /// <summary>
        /// Retrieves a static method by name, irrespective of its visibility
        /// </summary>
        /// <param name="t">The declaring type</param>
        /// <param name="name">The name of the method</param>
        public static Option<MethodInfo> StaticMethod(this Type t, string name) 
            => t.GetMethod(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

        /// <summary>
        /// Creates an instance of a type and casts the instance value as specified by a type parameter
        /// </summary>
        /// <typeparam name="T">The cast instance type</typeparam>
        /// <param name="t">The type for which an instance will be created</param>
        /// <param name="args">Arguments matched with/passed to an instance constructor defined by the type</param>
        [MethodImpl(Inline)]
        public static T CreateInstance<T>(this Type t, params object[] args)
            => (T)Activator.CreateInstance(t, args);
    }
}