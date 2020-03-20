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

    partial class RootReflections
    {
        /// <summary>
        /// Gets the value of a member attribute if it exists 
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="m">The member</param>
        public static Option<A> Tag<A>(this Type t) 
            where A : Attribute
                => t.GetCustomAttribute<A>();

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

   }
}