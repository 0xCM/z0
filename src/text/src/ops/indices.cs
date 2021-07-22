//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial class text
    {
        /// <summary>
        /// Returns the indices of the first occurrences of the first and second characters in the source, if any
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="first">The first character to match</param>
        /// <param name="second">THe second character to match</param>
        [MethodImpl(Inline), Op]
        public static Pair<int> indices(string src, char first, char second)
            => pair(index(src, first), index(src,second));

        /// <summary>
        /// Returns the indices of the first occurrences of the first and second strings in the source, if any
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="first">The first character to match</param>
        /// <param name="second">THe second character to match</param>
        [MethodImpl(Inline), Op]
        public static Pair<int> indices(string src, string first, string second)
            => pair(src.IndexOf(first), src.IndexOf(second));

        [MethodImpl(Inline), Op]
        public static uint indices(ReadOnlySpan<char> src, char c, Span<uint> dst)
        {
            var max = (uint)dst.Length;
            var j = 0u;
            for(var i=0u; i<src.Length && j < max; i++)
            {
                if(skip(src,i) == c)
                    seek(dst, j++) = i;
            }
            return j;
        }
    }
}