//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static partial class Reflections
    {
        /// <summary>
        /// Gets the identified assembly attribute if present, otherwise None
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="A">The type of attribute for which to search</typeparam>
        public static Option<A> TryGetAttribute<A>(this Assembly a) 
            where A : Attribute
                =>  a.Tag<A>();

        /// <summary>
        /// Gets the value of <see cref="AssemblyProductAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static Option<string> Product(this Assembly a)
            => from x in a.TryGetAttribute<AssemblyProductAttribute>() select x.Product;

        /// <summary>
        /// Gets the value of <see cref="AssemblyTitleAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static Option<string> Title(this Assembly a)
            => from x in a.TryGetAttribute<AssemblyTitleAttribute>() select x.Title;

        /// <summary>
        /// Gets the value of <see cref="AssemblyCompanyAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static Option<string> Company(this Assembly a)
            => from x in a.TryGetAttribute<AssemblyCompanyAttribute>() select x.Company;

        /// <summary>
        /// Gets the value of <see cref="AssemblyDefaultAliasAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static Option<string> DefaultAlias(this Assembly a)
            => from x in a.TryGetAttribute<AssemblyDefaultAliasAttribute>() select x.DefaultAlias;        
    }
}