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
        public static IDictionary<FieldInfo, A> TaggedFieldIndex<A>(this Type src) 
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
        public static IReadOnlyDictionary<MethodInfo, A> TagedMethodIndex<A>(this Type t)
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
        public static IReadOnlyDictionary<PropertyInfo, A> TaggedPropertieIndex<A>(this Type t) 
            where A : Attribute
                => (from p in t.DeclaredProperties()
                    where p.Tagged<A>() 
                    let attrib = p.GetCustomAttribute<A>()
                    select (p,attrib)
                    ).ToDictionary();

        public static Option<MethodInfo> FirstMatchedMethod(this Type declarer, string name, params Type[] paramTypes)
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
        public static Option<ConstructorInfo> DefaultConstructor(this Type t)
            => t.GetConstructor(BF_DeclaredInstance, null, new Type[] { }, new ParameterModifier[] { });

        public static object FieldValue(this Type src, string name, object instance = null)
            => src.Fields().FirstOrDefault(f => f.Name == name)?.GetValue(instance);     

        /// <summary>
        /// Gets the value of a constant field if it exists; otherwise, returns a default value
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="name">The name of the field</param>
        /// <param name="@default">The value to return if the field is not found</param>
        /// <typeparam name="T">The field value type</typeparam>
        public static T LiteralFieldValue<T>(this Type t, string name, T @default = default)
        {
            var f = t.Fields().Literal().FirstOrDefault();
            if(f != null)
                return (T)f.GetRawConstantValue();
            else
                return @default;
        }

        [MethodImpl(Inline)]
        public static bool Ignore(this Type src)
            => src.IsAttributed<IgnoreAttribute>();

   }
}