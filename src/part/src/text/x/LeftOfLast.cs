//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XText
    {

        [TextUtility]
        public static string LeftOfLast(this string s, string match)
        {
            var idx = s.LastIndexOf(match);
            if (idx != -1)
                return s.Substring(0, idx);
            else
                return string.Empty;
        }

        /// <summary>
        /// Retrieves the substring that precedes the last occurrence of a marker
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="match">The substring to match</param>
        [TextUtility]
        public static string LeftOfLast(this string s, char match)
        {
            var idx = s.LastIndexOf(match);
            if (idx != -1)
                return s.Substring(0, idx);
            else
                return string.Empty;
        }
    }
}