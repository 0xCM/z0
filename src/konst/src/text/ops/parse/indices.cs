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

    public readonly partial struct TextRules
    {
        partial struct Parse
        {
            /// <summary>
            /// Returns the indices of the first occurrences of the first and second characters in the source, if any
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="first">The first character to match</param>
            /// <param name="second">THe second character to match</param>

            [MethodImpl(Inline), Op]
            public static Pair<int> indices(string src, char first, char second)
                => pair(src.IndexOf(first), src.IndexOf(second));

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
            public static int index(string src, char match)
            {
                var count = src.Length;
                ref readonly var c = ref @char(src);
                for(var i=0; i<count; i++)
                    if(skip(c,i) == match)
                        return i;
                return NotFound;
            }
        }
    }
}