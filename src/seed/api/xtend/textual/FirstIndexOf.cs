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
        /// Searches a string for the first occurrence of a specified character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="match">The character to match</param>
        public static Option<int> FirstIndexOf(this string s, char match)
        {
            var idx = s.IndexOf(match);
            return idx != -1 ? idx : Option.none<int>();
        }

        /// <summary>
        /// Searches a string for the first occurrence of a specified substring
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="match">The substring to match</param>
        public static Option<int> FirstIndexOf(this string s, string match)
        {
            var idx = s.IndexOf(match);
            return idx != -1 ? idx : Option.none<int>();
        }
    }
}