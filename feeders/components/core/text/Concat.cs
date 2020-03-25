//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    partial class ComponentOps
    {
        /// <summary>
        /// Joins the strings provided by the enumerable with an optional separator
        /// </summary>
        /// <param name="src">The source strings</param>
        /// <param name="sep">The separator, if any</param>
        public static string Concat(this IEnumerable<string> src, string sep = null)
            => string.Join(sep ?? string.Empty, src);

        public static string Concat(this IEnumerable<string> src, char sep)
            => string.Join(sep, src);
    }
}