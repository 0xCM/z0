//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;
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
            [Op]
            public static bit fenced(string src, char left, char right)
            {
                if(text.nonempty(src))
                {
                    var leftIndex = -1;
                    var rightIndex = -1;
                    var chars = span(src.Trim());
                    var count = chars.Length;
                    return first(chars) == left && skip(chars, count - 1) == right;
                }

                return false;
            }

            [Op]
            public static bool fenced(string src, Fence<char> fence, out Pair<int> location)
            {
                location = root.pair((int)NotFound,(int)NotFound);
                if(text.nonempty(src))
                {
                    var chars = span(src);
                    var count = chars.Length;
                    for(var i=0; i<count; i++)
                    {
                        ref readonly var c = ref skip(chars,i);
                        if(location.Left == NotFound)
                        {
                            if(c == fence.Left)
                                location.Left = i;
                        }

                        else if(location.Left != NotFound && location.Right == NotFound)
                        {
                            if(c == fence.Right)
                            {
                                location.Right = i;
                                break;
                            }
                        }

                    }
                }

                return location.Left != NotFound && location.Right != NotFound;
            }

            /// <summary>
            /// Determines whether the source string is contained betwee specified left and right markers
            /// </summary>
            /// <param name="s">The subject to test</param>
            /// <param name="left">The left marker</param>
            /// <param name="right">The right marker</param>
            /// <param name="compare">Th comparison type</param>
            [Op]
            public static bit fenced(string src, string left, string right)
                => src.StartsWith(left, InvariantCulture) && src.EndsWith(right, InvariantCulture);

            /// <summary>
            /// Determines whether the source text is enclosed by a specified fence
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="fence">The fence definition</param>
            [Op]
            public static bit fenced(string src, Fence<char> fence)
                => fenced(src, fence.Left, fence.Right);

            /// <summary>
            /// Determines whether the source text is enclosed by a specified fence
            /// </summary>
            /// <param name="src">The source text</param>
            /// <param name="fence">The fence definition</param>
            [Op]
            public static bit fenced(string src, Fence<string> fence)
                => fenced(src, fence.Left, fence.Right);
        }
    }
}