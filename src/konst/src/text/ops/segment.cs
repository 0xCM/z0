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
        /// Extracts an index-identified substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="i0">The index of the first character in the substring</param>
        /// <param name="i1">The index of the last character in the substring</param>
        [MethodImpl(Inline), Op]
        public static string segment(string src, int i0, int i1)
            => src.Substring(i0, i1 - i0 + 1);

        /// <summary>
        /// Extracts an index-identified substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="i0">The index of the first character in the substring</param>
        /// <param name="i1">The index of the last character in the substring</param>
        [MethodImpl(Inline), Op]
        public static string segment(string src, uint i0, uint i1)
            => segment(src,(int)i0, (int)i1);
    }
}