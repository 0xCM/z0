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
            /// Determines whether the source text is of the form {left:char}{content:string}{right:char}, ignoring leading/trailing whitespace
            /// </summary>
            /// <param name="src">The text to analyze</param>
            /// <param name="left">The left boundary</param>
            /// <param name="right">The right boundary</param>
            [MethodImpl(Inline), Op]
            public static bool fenced(string src, char left, char right)
            {
                var result = false;
                if(nonempty(src))
                {
                    var x = span(src.Trim());
                    var length = x.Length;
                    result = first(x) == left && skip(x,length - 1) == right;
                }

                return result;
            }

            /// <summary>
            /// Determines whether the source string is contained betwee specified left and right markers
            /// </summary>
            /// <param name="s">The subject to test</param>
            /// <param name="left">The left marker</param>
            /// <param name="right">The right marker</param>
            /// <param name="compare">Th comparison type</param>
            [Op]
            public static bool fenced(string src, string left, string right)
                => src.StartsWith(left, InvariantCulture) && src.EndsWith(right, InvariantCulture);
        }
    }
}