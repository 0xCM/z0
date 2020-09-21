//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Searches for the last index of a specified character in a string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="match">The character to match</param>
        public static Option<int> LastIndexOf(this string s, char match)
        {
            var idx = s.LastIndexOf(match);
            return idx != -1 ? idx : Option.none<int>();
        }

        /// <summary>
        /// Searches for the last index of a specified character in a string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="match">The substring to match</param>
        public static Option<int> LastIndexOf(this string s, string match)
        {
            var idx = s.LastIndexOf(match);
            return idx != -1 ? idx : Option.none<int>();
        }

    }
}