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
        /// Gets the string to the left of, but not including, a specified index
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="idx">The index</param>
        public static string LeftOf(this string s, int idx)
            => (idx >= s.Length - 1) ? String.Empty : s.Substring(0, idx);

        /// <summary>
        /// Gets the string to the left of, but not including, the first instance of a specified character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character</param>
        public static string LeftOf(this string s, char c)
            => s.Substring(0, apply(s.IndexOf(c), idx => idx == -1 ? s.Length - 1 : idx));

        /// <summary>
        /// Gets the string to the left of, but not including, a specified substring
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="substring">The substring to match</param>
        public static string LeftOf(this string s, string substring)
        {
            var idx = s.IndexOf(substring);
            if (idx != -1)
                return s.LeftOf(idx);
            else
                return string.Empty;
        }
    }
}