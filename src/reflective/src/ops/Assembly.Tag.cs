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
    
    partial class XTend
    {
        /// <summary>
        /// Determines whether an assembly has an attribute of a given type
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="T">The attribute type</typeparam>
        public static bool Tagged<T>(this Assembly a) 
            where T : Attribute
                => System.Attribute.IsDefined(a, typeof(T));

        /// <summary>
        /// Gets the identified assembly attribute if present, otherwise NULL
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="A">The type of attribute for which to search</typeparam>
        public static A Tag<A>(this Assembly a) 
            where A : Attribute
                => (A)System.Attribute.GetCustomAttribute(a, typeof(A));

        /// <summary>
        /// Gets the value of <see cref="AssemblyProductAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static string Product(this Assembly a)
            => a.Tag<AssemblyProductAttribute>()?.Product ?? string.Empty;

        /// <summary>
        /// Gets the value of <see cref="AssemblyTitleAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static string Title(this Assembly a)
            => a.Tag<AssemblyTitleAttribute>()?.Title ?? string.Empty;

        /// <summary>
        /// Gets the value of <see cref="AssemblyCompanyAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static string Company(this Assembly a)
            => a.Tag<AssemblyCompanyAttribute>()?.Company ?? string.Empty;

        /// <summary>
        /// Gets the value of <see cref="AssemblyDefaultAliasAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static string DefaultAlias(this Assembly a)
            => a.Tag<AssemblyDefaultAliasAttribute>()?.DefaultAlias ?? string.Empty;
 
        /// <summary>
        /// Gets the type attributions for the specified assembly
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static IDictionary<Type, A> TaggedTypeIndex<A>(this Assembly a, Func<Type,bool> pred = null)
            where A : Attribute
        {
            var f = pred ?? (t => true);
            var q = from t in a.GetTypes()
                    where System.Attribute.IsDefined(t, typeof(A)) && f(t)
                    let attrib = t.GetCustomAttribute<A>()
                    select new
                    {
                        Type = t,
                        Attribute = attrib
                    };
            return q.ToDictionary(x => x.Type, x => x.Attribute);
        }

        /// <summary>
        /// Gets the simple name of an assembly
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static string GetSimpleName(this Assembly a)
            => a?.GetName()?.Name ?? string.Empty;

        /// <summary>
        /// Convenience accessor for the assembly's version
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static Version AssemblyVersion(this Assembly a)
            => a.GetName().Version;

        public static Type[] Types(this Assembly a)
            => a.GetTypes();

        public static Type[] Interfaces(this Assembly a)
            => a.Types().Interfaces();

        public static Type[] Structs(this Assembly a)
            => a.Types().Structs();

        public static Type[] NestedTypes(this Assembly a)
            => a.Types().Nested();

        public static Type[] StaticTypes(this Assembly a)
            => a.Types().Static();

        public static IEnumerable<Type> PublicTypes(this Assembly a)
            => a.Types().Public();

        public static IEnumerable<Type> NonPublicTypes(this Assembly a)
            => a.Types().NonPublic();
    }
}