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
        /// <summary>
        /// Gets the string to the right of, but not including, the first instance of a specified character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character</param>
        [TextUtility]
        public static string RightOfFirst(this string s, char c)
            => s.RightOfIndex(s.IndexOf(c));

        /// <summary>
        /// Gets the string to the right of, but not including, a specified substring
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="substring">The substring to match</param>
        [TextUtility]
        public static string RightOfFirst(this string s, string substring)
        {
            var idx = s.IndexOf(substring);
            if (idx != -1)
                return s.RightOfIndex(idx + substring.Length);
            else
                return string.Empty;
        }
    }
}