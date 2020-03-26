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

    using static Root;
    using static ReflectionFlags;

    partial class RootReflections
    {
        /// <summary>
        /// Retrieves the type's fields together with applied attributes
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="src">The type to examine</param>
        static IDictionary<FieldInfo, A> TaggedFieldIndex<A>(this Type src) 
            where A : Attribute
        {
            var selection = from f in src.DeclaredFields()
                            where f.Tagged<A>()
                            let a = f.GetCustomAttribute<A>()
                            select (f,a);
            return selection.ToDictionary();
        }

        /// <summary>
        /// Retrieves the attribution index for the identified methods declared by the type
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">The member instance type</param>
        static IReadOnlyDictionary<MethodInfo, A> TagedMethodIndex<A>(this Type t)
            where A : Attribute
                => (from p in t.DeclaredMethods()
                    where p.Tagged<A>() 
                    let attrib = p.GetCustomAttribute<A>()
                    select (p,attrib)
                    ).ToDictionary();

        /// <summary>
        /// Retrieves the type's properties together with applied attributes
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="t">The type to examine</param>
        static IReadOnlyDictionary<PropertyInfo, A> TaggedPropertieIndex<A>(this Type t) 
            where A : Attribute
                => (from p in t.DeclaredProperties()
                    where p.Tagged<A>() 
                    let attrib = p.GetCustomAttribute<A>()
                    select (p,attrib)
                    ).ToDictionary();

        static Option<MethodInfo> FirstMatchedMethod(this Type declarer, string name, params Type[] paramTypes)
        {
            foreach(var m in declarer.DeclaredMethods())
            {
                var pTypes = m.ParameterTypes(true).ToArray();
                if(pTypes.Length >= paramTypes.Length)
                {
                    var matched = false;
                    for(var i=0; i<paramTypes.Length; i++)
                        matched &= (pTypes[i] == paramTypes[i]);
                    if(matched)
                        return m;
                }
            }
            return none<MethodInfo>();
        }

        /// <summary>
        /// Retrieves a type's default constructor, if present; otherwise, none
        /// </summary>
        /// <param name="t">The type to examine</param>
        static Option<ConstructorInfo> DefaultConstructor(this Type t)
            => t.GetConstructor(BF_DeclaredInstance, null, new Type[] { }, new ParameterModifier[] { });

        static object FieldValue(this Type src, string name, object instance = null)
            => src.Fields().FirstOrDefault(f => f.Name == name)?.GetValue(instance);     

        /// <summary>
        /// Gets the value of a constant field if it exists; otherwise, returns a default value
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="name">The name of the field</param>
        /// <param name="@default">The value to return if the field is not found</param>
        /// <typeparam name="T">The field value type</typeparam>
        static T LiteralFieldValue<T>(this Type t, string name, T @default = default)
        {
            var f = t.Fields().Literal().FirstOrDefault();
            if(f != null)
                return (T)f.GetRawConstantValue();
            else
                return @default;
        }

        [MethodImpl(Inline)]
        static bool Ignore(this Type src)
            => src.IsAttributed<IgnoreAttribute>();

        /// <summary>
        /// Selects the fields accessible via a type but which the type itself does nto declare
        /// </summary>
        /// <param name="src">The type to examine</param>
        static IEnumerable<FieldInfo> UndeclaredFields(this Type src)
            => src.Fields().Except(src.DeclaredFields());

        /// <summary>
        /// Selects the public and non-public static fields declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        static IEnumerable<FieldInfo> DeclaredInstanceFields(this Type t)
            => t.GetFields(BF_DeclaredInstance);

        /// <summary>
        /// Attempts to retrieves a static field by name, irrespective of its visibility
        /// </summary>
        /// <param name="t">The declaring type</param>
        /// <param name="name">The name of the method</param>
        static IEnumerable<FieldInfo> DeclaredStaticFields(this Type t) 
            => t.DeclaredFields().Static();

        static IEnumerable<FieldInfo> InheritedFields(this Type t)
            => t.Fields().Except(t.DeclaredFields());
   }
}