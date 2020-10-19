//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XTend
    {
        /// <summary>
        /// Applies a function to a value
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="X">The source value type</typeparam>
        /// <typeparam name="Y">The output value type</typeparam>
         [MethodImpl(Inline)]
         static Y apply<X,Y>(X x, Func<X,Y> f)
            => f(x);

        /// <summary>
        /// Gets the string to the left of, but not including, a specified index
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="idx">The index</param>
        [TextUtility]
        public static string LeftOfIndex(this string s, int idx)
            => (idx >= s.Length - 1) ? EmptyString : s.Substring(0, idx);

        /// <summary>
        /// Gets the string to the right of, but not including, a specified index
        /// </summary>
        /// <param name="src">The string to search</param>
        /// <param name="idx">The index</param>
        [TextUtility]
        public static string RightOfIndex(this string src, int idx)
            => (idx >= src.Length - 1) ? EmptyString : src.Substring(idx + 1) ?? EmptyString;

        /// <summary>
        /// Gets the string to the left of, but not including, the first instance of a specified character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character</param>
        [TextUtility]
        public static string LeftOfFirst(this string s, char c)
            => s.Substring(0, apply(s.IndexOf(c), idx => idx == -1 ? s.Length - 1 : idx));

        /// <summary>
        /// Gets the string to the left of, but not including, a specified substring
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="substring">The substring to match</param>
        [TextUtility]
        public static string LeftOfFirst(this string s, string substring)
        {
            var idx = s.IndexOf(substring);
            if (idx != -1)
                return s.LeftOfIndex(idx);
            else
                return string.Empty;
        }

        /// <summary>
        /// Gets the string to the right of, but not including, the first instance of a specified character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character</param>
        [TextUtility]
        public static string RightOfFirst(this string s, char c)
            => s.RightOfIndex(s.IndexOf(c));

        /// <summary>
        /// Extracts content demarcated by left/right character boundaries
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="left">The left marker</param>
        /// <param name="right">THe right marker</param>
        [TextUtility]
        public static string Unfence(this string src, char left, char right)
            => src.RightOfFirst(left).LeftOfLast(right);

        /// <summary>
        /// Gets the string to the right of, but not including, a specified substring
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="substring">The substring to match</param>
        [TextUtility]
        public static string RightOf(this string s, string substring)
        {
            var idx = s.IndexOf(substring);
            if (idx != -1)
                return s.RightOfIndex(idx + substring.Length);
            else
                return string.Empty;
        }

        /// <summary>
        /// Retrieves the substring that follows the last occurrence of a marker
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="match">The substring to match</param>
        [TextUtility]
        public static string RightOfLast(this string s, string match)
        {
            var idx = s.LastIndexOf(match);
            if (idx != -1)
                return s.Substring(idx + match.Length);
            else
                return string.Empty;
        }

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