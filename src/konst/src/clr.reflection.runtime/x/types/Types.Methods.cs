//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    partial class XClrQuery
    {
        /// <summary>
        /// Selects all methods from the source types
        /// </summary>
        /// <param name="src">The types to search</param>
        public static MethodInfo[] Methods(this Type[] src)
            => src.SelectMany(x => x.Methods()).ToArray();
    }
}