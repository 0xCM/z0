//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XClrQuery
    {
        /// <summary>
        /// Gets the value of <see cref="AssemblyProductAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        [MethodImpl(Inline), Op]
        public static string Product(this Assembly a)
            => a.Tag<AssemblyProductAttribute>()?.Product ?? string.Empty;

        /// <summary>
        /// Gets the value of <see cref="AssemblyTitleAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        [MethodImpl(Inline), Op]
        public static string Title(this Assembly a)
            => a.Tag<AssemblyTitleAttribute>()?.Title ?? string.Empty;

        /// <summary>
        /// Gets the value of <see cref="AssemblyCompanyAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        [MethodImpl(Inline), Op]
        public static string Company(this Assembly a)
            => a.Tag<AssemblyCompanyAttribute>()?.Company ?? string.Empty;

        /// <summary>
        /// Gets the value of <see cref="AssemblyDefaultAliasAttribute"/> if it exists
        /// </summary>
        /// <param name="a">The source assembly</param>
        [MethodImpl(Inline), Op]
        public static string DefaultAlias(this Assembly a)
            => a.Tag<AssemblyDefaultAliasAttribute>()?.DefaultAlias ?? string.Empty;
    }
}