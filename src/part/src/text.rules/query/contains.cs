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

    partial struct TextRules
    {
        partial struct Query
        {
            /// <summary>
            /// Tests whether a string contains a specified character
            /// </summary>
            /// <param name="src">The source string</param>
            /// <param name="match">The character to match</param>
            [Op]
            public static bool contains(string src, char match)
            {
                if(nonempty(src))
                    return(contains(span(src), match));
                else
                    return false;
            }

            /// <summary>
            /// Tests whether a character span contains a specified character
            /// </summary>
            /// <param name="src">The source string</param>
            /// <param name="match">The character to match</param>
            [Op]
            public static bool contains(ReadOnlySpan<char> src, char match)
            {
                var len = src.Length;
                for(var i=0; i<len; i++)
                    if(skip(src,i) == match)
                        return true;
                return false;
            }

            /// <summary>
            /// Tests whether a string contains a specified substring
            /// </summary>
            /// <param name="src">The source string</param>
            /// <param name="match">The string to match</param>
            [Op]
            public static bool contains(string src, string match)
                => src.Contains(match);
        }
    }
}