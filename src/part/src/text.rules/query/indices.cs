//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static Rules;

    partial struct TextRules
    {
        partial struct Query
        {
            /// <summary>
            /// Returns the indices of the first occurrences of the first and second characters in the source, if any
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="first">The first character to match</param>
            /// <param name="second">THe second character to match</param>
            [MethodImpl(Inline), Op]
            public static Pair<int> indices(string src, char first, char second)
                => root.pair(index(src, first), index(src,second));

            /// <summary>
            /// Returns the indices of the first occurrences of the first and second strings in the source, if any
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="first">The first character to match</param>
            /// <param name="second">THe second character to match</param>
            [MethodImpl(Inline), Op]
            public static Pair<int> indices(string src, string first, string second)
                => root.pair(src.IndexOf(first), src.IndexOf(second));

            /// <summary>
            /// Returns the indices of the first occurrences of the first and second strings in the source, if any
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="first">The first character to match</param>
            /// <param name="second">THe second character to match</param>
            [MethodImpl(Inline), Op]
            public static Pair<int> indices(string src, Fence<string> fence)
                => root.pair(src.IndexOf(fence.Left), src.IndexOf(fence.Right));

            /// <summary>
            /// Returns the indicies of all locations of a specified character within specified text
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="match">The character to match</param>
            [Op]
            public static Index<int> indices(string src, char match)
            {
                var dst = root.list<int>();
                var count = src.Length;
                ref readonly var c = ref @char(src);
                for(var i=0; i<count; i++)
                    if(skip(c,i) == match)
                        dst.Add(i);
                return dst.ToArray();
            }

            /// <summary>
            /// Returns the indicies of all locations of a specified character within specified text
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="match">The character to match</param>
            /// <param name="matched">The matched index buffer</param>
            [Op]
            public static Span<int> indices(string src, char match, Span<int> matched)
            {
                var dst = root.list<int>();
                var count = src.Length;
                var max = matched.Length;

                ref readonly var c = ref @char(src);
                var j = 0;
                for(var i=0; i<count && j<max; i++)
                    if(skip(c,i) == match)
                        seek(matched, j++) = i;

                return j != 0 ? slice(matched,0,j) : Span<int>.Empty;
            }
        }
    }
}