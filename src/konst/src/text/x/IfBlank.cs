//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class XTend
    {
        /// <summary>
        /// Returns the source string if it is not blank; otherwise, returns an alternate string
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="alt">The alternate string</param>
        [TextUtility]
        public static string IfBlank(this string src, string alt)
            => string.IsNullOrWhiteSpace(src) ? alt : src;
    }
}