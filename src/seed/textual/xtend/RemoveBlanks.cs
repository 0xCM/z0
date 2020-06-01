//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Removes whitespace characters from a string
        /// </summary>
        /// <param name="src">The source string</param>
        public static string RemoveBlanks(this string src)
            => src.RemoveAny(Control.seq(Chars.Space, Chars.LineFeed, Chars.NL, Chars.Tab));
    }
}