//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class XTend
    {
        /// <summary>
        /// Gets the string to the right of, but not including, the first instance of a specified character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character</param>
        public static string RightOf(this string s, char c)
            => s.RightOf(s.IndexOf(c));

        /// <summary>
        /// Extracts content demarcated by left/right character boundaries
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="left">The left marker</param>
        /// <param name="right">THe rigt marker</param>
        public static string Unfence(this string src, char left, char right)
            => src.RightOf(left).LeftOfLast(right);

        /// <summary>
        /// Gets the string to the right of, but not including, a specified index
        /// </summary>
        /// <param name="src">The string to search</param>
        /// <param name="idx">The index</param>
        public static string RightOf(this string src, int idx)
            => (idx >= src.Length - 1) 
             ? String.Empty 
             : src.Substring(idx + 1) ?? string.Empty;

        /// <summary>
        /// Gets the string to the right of, but not including, a specified substring
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="substring">The substring to match</param>
        public static string RightOf(this string s, string substring)
        {
            var idx = s.IndexOf(substring);
            if (idx != -1)
                return s.RightOf(idx + substring.Length);
            else
                return string.Empty;
        }

        /// <summary>
        /// Retrieves the substring that follows the last occurrence of a marker
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="match">The substring to match</param>
        public static string RightOfLast(this string s, string match)
        {
            var idx = s.LastIndexOf(match);
            if (idx != -1)
                return s.Substring(idx + match.Length);
            else
                return string.Empty;
        }
 
        public static string LeftOfLast(this string s, string match)
        {
            var idx = s.LastIndexOf(match);
            if (idx != -1)
                return s.Substring(0, idx);
            else
                return string.Empty;
        }

        /// <summary>
        /// Retrieves the substring that precedes the last occurence of a marker
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="match">The substring to match</param>
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