//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class XClrQuery
    {
        /// <summary>
        /// Convenience accessor for the assembly's version
        /// </summary>
        /// <param name="a">The source assembly</param>
        public static Version AssemblyVersion(this Assembly a)
            => a.GetName().Version;
    }
}