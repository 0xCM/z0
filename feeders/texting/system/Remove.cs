//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Textual;

    partial class XText
    {
        /// <summary>
        /// Removes a substring from the source string if it exists
        /// </summary>
        /// <param name="s">The string to manipulate</param>
        /// <param name="substring">The substring to remove</param>
        public static string Remove(this string s, string substring)
            => s.Replace(substring,string.Empty);

        /// <summary>
        /// Removes all occurences of a substring from the source strings where extant
        /// </summary>
        /// <param name="s">The strings to manipulate</param>
        /// <param name="substring">The substring to remove</param>
        public static IEnumerable<string> RemoveSubstring(this IEnumerable<string> src, string substring)
            => from s in src
                let r = s.Remove(substring)
                select r;

        /// <summary>
        /// Erases a specified set of character occurrences in a string
        /// </summary>
        /// <param name="s">The string to manipulate</param>
        /// <param name="removals">The characters to remove</param>
        public static string RemoveAny(this string s, IEnumerable<char> removals)
        {
            if (s.ContainsAny(removals))
            {
                var dst = String.Empty;
                var src = s.ToCharArray();
                for (int i = 0; i < s.Length; i++)
                    if (!removals.Contains(src[i]))
                        dst += src[i];
                return dst;
            }
            else
                return s;
        }

        /// <summary>
        /// Erases a specified set of character occurrences in a string
        /// </summary>
        /// <param name="s">The string to manipulate</param>
        /// <param name="removals">The characters to remove</param>
        public static string RemoveAny(this string s, params char[] removals)
            => s.RemoveAny(removals as IEnumerable<char>);

        /// <summary>
        /// Creates a new string from the first n - 1 characters of a string of length n
        /// </summary>
        /// <param name="s">The source string</param>
        [MethodImpl(Inline)]
        public static string RemoveLast(this string s)
            => string.IsNullOrWhiteSpace(s) ? string.Empty : s.Substring(0, s.Length - 1);
    }
}