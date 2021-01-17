//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class XText
    {
        /// <summary>
        /// Searches for the last index of a specified character in a string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="match">The character to match</param>
        [TextUtility]
        public static Option<int> LastIndexOf(this string s, char match)
        {
            var idx = s.LastIndexOf(match);
            return idx != -1 ? idx : root.none<int>();
        }

        /// <summary>
        /// Searches for the last index of a specified character in a string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="match">The substring to match</param>
        [TextUtility]
        public static Option<int> LastIndexOf(this string s, string match)
        {
            var idx = s.LastIndexOf(match);
            return idx != -1 ? idx : root.none<int>();
        }
    }
}