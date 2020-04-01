//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Textual;

    partial class XTend
    {
        /// <summary>
        /// Searches for the last index of a specified character in a string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character to match</param>
        public static int? LastIndexOf(this string s, char c)
        {
            var idx = s.LastIndexOf(c);
            return idx != -1 ? idx : unvalued<int>();
        }

        /// <summary>
        /// Searches a string for the first occurrence of a specified character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The marking character</param>
        public static int? FirstIndexOf(this string s, char c)
        {
            var idx = s.IndexOf(c);
            return idx != -1 ? idx : unvalued<int>();
        }
    }
}