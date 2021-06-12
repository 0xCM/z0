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

    partial struct SymbolicQuery
    {
        /// <summary>
        /// Determines whether the source text is of the form {left:char}{content:string}{right:char}, ignoring leading/trailing whitespace
        /// </summary>
        /// <param name="src">The text to analyze</param>
        /// <param name="left">The left boundary</param>
        /// <param name="right">The right boundary</param>
        [Op]
        public static bool fenced(string src, char left, char right)
        {
            if(nonempty(src))
            {
                var leftIndex = -1;
                var rightIndex = -1;
                var chars = span(src.Trim());
                var count = chars.Length;
                return first(chars) == left && skip(chars, count - 1) == right;
            }

            return false;
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
            => src.StartsWith(left, Invariant) && src.EndsWith(right, Invariant);

    }
}