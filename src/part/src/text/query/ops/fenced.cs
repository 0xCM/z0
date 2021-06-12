//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Rules;
    using static core;
    using static TextRules;

    partial struct TextQuery
    {
        [Op]
        public static bool fenced(string src, Fence<char> fence, out Pair<int> location)
        {
            location = pair((int)NotFound,(int)NotFound);
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
        /// Determines whether the source text is enclosed by a specified fence
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="fence">The fence definition</param>
        [Op]
        public static bool fenced(string src, Fence<char> fence)
            => SymbolicQuery.fenced(src, fence.Left, fence.Right);

        /// <summary>
        /// Determines whether the source text is enclosed by a specified fence
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="fence">The fence definition</param>
        [Op]
        public static bool fenced(string src, Fence<string> fence)
            => SymbolicQuery.fenced(src, fence.Left, fence.Right);
    }
}