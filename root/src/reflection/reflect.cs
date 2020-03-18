//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;
    using System.Linq.Expressions;
    using System.Linq;

    using static Root;
    using static ReflectionFlags;

    public static partial class RootReflections{}

    public static class reflect
    {
        /// <summary>
        /// Returns the System.Type of the supplied parametric type
        /// </summary>
        /// <param name="t">A representative value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static Type type<T>(T t = default) 
            => typeof(T);

        /// <summary>
        /// Gets the assembly in which a parametric type is defined
        /// </summary>
        /// <typeparam name="T">The type to be examined</typeparam>
        [MethodImpl(Inline)]
        public static Assembly assembly<T>(T t = default)
            => typeof(T).Assembly;

        /// <summary>
        /// Returns 1 if the two parameteric types are the same, 0 otherwise
        /// </summary>
        /// <typeparam name="S">The first type</typeparam>
        /// <typeparam name="T">The second type</typeparam>
        [MethodImpl(Inline)]
        public static bit typematch<S,T>(S s = default, T t = default)
            => typeof(S) == typeof(T);

        /// <summary>
        /// Specifies the generic type definition for a specified generic type
        /// </summary>
        [MethodImpl(Inline)]   
        public static Type typedef(Type t)
            => t.GetGenericTypeDefinition();

        /// <summary>
        /// Returns the display name of the supplied type
        /// </summary>
        /// <param name="full">Whether the full name should be returned</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static string typename<T>(T t = default)
            => typeof(T).DisplayName();

        /// <summary>
        /// Returns the display name of the source type
        /// </summary>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]   
        public static string label<T>(T t = default)
            => typeof(T).DisplayName();

        /// <summary>
        /// Creates an instance of a specified type
        /// </summary>
        /// <param name="t">The type of the instance to create</param>
        [MethodImpl(Inline)]   
        public static T instance<T>(Type t, params object[] args)
            => (T)Activator.CreateInstance(t,args);

        /// <summary>
        /// Returns a pair of System.Type 
        /// </summary>
        /// <typeparam name="T0">The first source type</typeparam>
        /// <typeparam name="T1">The second source type</typeparam>
        [MethodImpl(Inline)]
        public static (Type t0,Type t1) types<T0,T1>(T0 t0 = default, T1 t1 = default) 
            => (typeof(T0),typeof(T1));

        /// <summary>
        /// Constructs an object
        /// </summary>
        /// <typeparam name="O">The object type</typeparam>
        /// <param name="parms">The parameters passed to the oject's constructor</param>
        public static Option<O> construct<O>(params object[] parms)
            => Root.Try(parms, args => (O)Activator.CreateInstance(typeof(O), args));

        /// <summary>
        /// Gets the type's classification code
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static TypeCode typecode(Type t)
            => Type.GetTypeCode(t);

        /// <summary>
        /// Gets the type's classification code
        /// </summary>
        /// <param name="t">A type representative</param>
        /// <typeparam name="T">The type to examine</typeparam>
        [MethodImpl(Inline)]
        public static TypeCode typecode<T>(T t = default)
            => Type.GetTypeCode(typeof(T));

        /// <summary>
        /// Retrieves any declared public/non-public,static or instance property with the given name
        /// </summary>
        /// <typeparam name="T">The type that defines the property</typeparam>
        /// <param name="name">The name of the property</param>
        /// <remarks>
        /// This operation does not use the property cache, which only maintains lookups for public/instance properties
        /// </remarks>
        public static Option<PropertyInfo> prop<T>(string name)
            => typeof(T).GetProperties(BF_Declared).TryGetFirst(x => x.Name == name);

        /// <summary>
        /// Retrieves any declared public/non-public,static or instance field with the given name
        /// </summary>
        /// <typeparam name="T">The type that defines the field</typeparam>
        /// <param name="name">The name of the field</param>
        public static Option<FieldInfo> field<T>(string name)
            => typeof(T).GetFields(BF_Declared).TryGetFirst(x => x.Name == name);

        /// <summary>
        /// Attempts to retrieves the value of a static or instance property
        /// </summary>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="member">The property</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<V> value<V>(PropertyInfo member, object instance = null)
            => from o in member.TryGetValue(instance)
                from v in Root.TryCast<V>(o)
                select v;

        /// <summary>
        /// Attempts to retrieves the value of a field
        /// </summary>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="member">The field</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<V> value<V>(FieldInfo member, object instance = null)
            => from o in member.Value(instance)
            from v in Root.TryCast<V>(o)
            select v;

        /// <summary>
        /// Retrieves the identified <see cref="PropertyInfo"/>
        /// </summary>
        /// <param name="o">The object on which the property is defined</param>
        /// <param name="propname"></param>
        static PropertyInfo GetProperty(object o, string propname)
            => o.GetType().GetProperty(propname, BF_Instance);

        /// <summary>
        /// Retrieves the public properties declared on an object's type
        /// </summary>
        /// <param name="o">The object</param>
        [MethodImpl(Inline)]
        public static PropertyInfo[] props(object o)
            => o == null
            ? new PropertyInfo[]{}
            : o.GetType().GetProperties(BF_AllPublicInstance);

        /// <summary>
        /// Retrieves the public properties declared on a type
        /// </summary>
        [MethodImpl(Inline)]
        public static PropertyInfo[] props(Type type)
            => type.GetProperties(BF_AllPublicInstance);

        /// <summary>
        /// Attempts the retrieve a named property declared on a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="name">The name of the property</param>
        public static Option<PropertyInfo> prop(Type t, string name)
            => props(t).FirstOrDefault(p => p.Name == name);

        /// <summary>
        /// Gets the value of the identified property
        /// </summary>
        /// <param name="o">The object on which the property is defined</param>
        /// <param name="propname">The name of the property</param>
        [MethodImpl(Inline)]
        public static object propval(object o, string propname)
            => GetProperty(o,propname)?.GetValue(o);

        /// <summary>
        /// Gets the value of a name-identified property on an object instance
        /// </summary>
        /// <typeparam name="T">The property value type</typeparam>
        /// <param name="o">The object on which the property is defined</param>
        /// <param name="propname">The name of the property</param>
        [MethodImpl(Inline)]
        public static T propval<T>(object o, string propname)
            => (T)propval(o, propname);

        /// <summary>
        /// Gets the value of a name-identified property on an object instance
        /// </summary>
        /// <param name="o">The object whose property will be set</param>
        /// <param name="propname">The property that will be set</param>
        /// <param name="value">The value of the property</param>
        [MethodImpl(Inline)]
        public static void propval(object o, string propname, object value)
            => GetProperty(o,propname)?.SetValue(o, value);

        /// <summary>
        /// Gets the CLR runtime type of the identified property
        /// </summary>
        /// <param name="o">An instance of the type on which the property is defined</param>
        /// <param name="propname">The name of the property</param>
        [MethodImpl(Inline)]
        public static Type proptype(object o, string propname)
            => o.GetType().GetProperty(propname).PropertyType;

        /// <summary>
        /// Searches a type for an instance constructor that matches a specified signature
        /// </summary>
        /// <param name="declaringType">The type to search</param>
        /// <param name="argTypes">The method parameter types in ordinal position</param>
        [MethodImpl(Inline)]
        public static Option<ConstructorInfo> ctor(Type declaringType, params Type[] argTypes)
            => declaringType.GetConstructor(BF_Instance, null, argTypes, new ParameterModifier[]{});

        /// <summary>
        /// Searches a type for an instance constructor that matches a specified signature
        /// </summary>
        /// <param name="argTypes">The method parameter types in ordinal position</param>
        /// <typeparam name="T">The type to search</typeparam>
        [MethodImpl(Inline)]
        public static Option<ConstructorInfo> ctor<T>(params Type[] argTypes)
            => ctor(typeof(T), argTypes);

        [MethodImpl(Inline)]
        public static string myname([CallerMemberName] string name = null)
            => name ?? string.Empty;

        [MethodImpl(Inline)]
        public static string myfile([CallerFilePath] string path = null)
            => path ?? string.Empty;

        [MethodImpl(Inline)]
        public static int myline([CallerLineNumber] int? line = null)
            => line ?? 0;

        /// <summary>
        /// Retrieves metadata for a name-identifed method on an object instance
        /// </summary>
        /// <param name="o">The object on which the method is defined</param>
        /// <param name="name">The method name</param>
        static MethodInfo GetDelaredMethod(this object o, string name)
            => o.GetType().GetMethod(name, BF_DeclaredInstance);

        /// <summary>
        /// Dynamically invokes a named method on an object
        /// </summary>
        /// <param name="o">The object that defines the method</param>
        /// <param name="methodName">The method to invoke</param>
        /// <param name="parms">The parameters to pass to the method</param>
        [MethodImpl(Inline)]
        public static void invoke(object o, string methodName, params object[] parms)
            => o.GetDelaredMethod(methodName).Invoke(o, parms);

        /// <summary>
        /// Finds the first method declared by a type that matches a specified name
        /// </summary>
        /// <param name="name">The method name</param>
        /// <param name="t">A type representative</param>
        /// <typeparam name="T">The declaring type</typeparam>
        [MethodImpl(Inline)]
        public static MethodInfo method<T>(string name, T t = default)
            => typeof(T).DeclaredMethods().First(m => m.Name == name);        
    }
}