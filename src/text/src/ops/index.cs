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
        /// Returns the index of the first source charcter that satisfies the match predicate or, -1
        /// if no match is found
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="offset">The index at which to begin the search</param>
        /// <param name="match">The character to match</param>
        [MethodImpl(Inline), Op]
        public static int index(ReadOnlySpan<char> src, int offset, char match)
        {
            ref readonly var c = ref first(src);
            for(var i=offset; i<src.Length; i++)
                if(skip(c, i) == match)
                    return i;
            return NotFound;
        }

        [MethodImpl(Inline), Op]
        public static int index(ReadOnlySpan<char> src, char match)
            => index(src, 0, match);

        /// <summary>
        /// Returns the index of first source character that matches the specified predicate
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="a">A match</param>
        /// <param name="b">A match</param>
        [MethodImpl(Inline), Op]
        public static int index(ReadOnlySpan<char> src, char a, char b)
            => src.IndexOfAny(a,b);

        /// <summary>
        /// Returns the index of first source character that matches the specified predicate
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="a">A match</param>
        /// <param name="b">A match</param>
        [MethodImpl(Inline), Op]
        public static int index(ReadOnlySpan<char> src, int offset, char a, char b)
            => core.slice(src,0,offset).IndexOfAny(a,b);

        [Op]
        public static int index(ReadOnlySpan<char> src, ReadOnlySpan<char> match)
            => src.IndexOf(match);

        [Op]
        public static int index(ReadOnlySpan<char> src, int offset, ReadOnlySpan<char> match)
            => core.slice(src, 0, offset).IndexOf(match);

        [Op]
        public static TextIndex index(ReadOnlySpan<char> src, TextMarker match)
            => index(src, match.Content);
    }
}