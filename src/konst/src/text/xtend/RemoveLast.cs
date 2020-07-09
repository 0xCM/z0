//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Creates a new string from the first n - 1 characters of a string of length n
        /// </summary>
        /// <param name="s">The source string</param>
        public static string RemoveLast(this string s)
            => string.IsNullOrWhiteSpace(s) ? string.Empty : s.Substring(0, s.Length - 1);
    }
}