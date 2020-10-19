//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class text
    {
        /// <summary>
        /// Returns the indices of the first occurrences of the first and second characters in the source, if any
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="first">The first character to match</param>
        /// <param name="second">THe second character to match</param>

        [MethodImpl(Inline), Op]
        public static (int first, int second) indices(string src, char first, char second)
            => (src.IndexOf(first), src.IndexOf(second));

        /// <summary>
        /// Returns the indices of the first occurrences of the first and second strings in the source, if any
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="first">The first character to match</param>
        /// <param name="second">THe second character to match</param>
        [MethodImpl(Inline), Op]
        public static (int first, int second) indices(string src, string first, string second)
            => (src.IndexOf(first), src.IndexOf(second));
    }
}