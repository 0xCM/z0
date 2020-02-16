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

    using static ReflectionFlags;
    using static RootShare;

    partial class RootReflections
    {
        /// <summary>
        /// Retrieves the public and non-public static properties declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<PropertyInfo> DeclaredStaticProperties(this Type t)
            => t.GetProperties(BF_DeclaredStatic);

        /// <summary>
        /// Retrieves all properties declared by a by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<PropertyInfo> DeclaredProperties(this Type src)
            => src.GetProperties(BF_Declared);

        /// <summary>
        /// Retrieves all declared or inheraited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<PropertyInfo> Properties(this Type src)
            => src.GetProperties(BF_All);

        /// <summary>
        /// Gets the static methods defined on a specified type
        /// </summary>
        /// <param name="this">The type to examine</param>
        public static IEnumerable<PropertyInfo> StaticProperties(this Type src)
            => src.GetProperties(BF_AllStatic);

        /// <summary>
        /// Retrieves the type's properties together with applied attributes
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="t">The type to examine</param>
        public static IReadOnlyDictionary<PropertyInfo, A> PropertyAttributions<A>(this Type t) 
            where A : Attribute
                => (from p in t.DeclaredProperties()
                    where p.Attributed<A>() 
                    let attrib = p.GetCustomAttribute<A>()
                    select (p,attrib)
                    ).ToDictionary();

    }
}