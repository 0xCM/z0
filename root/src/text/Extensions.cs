//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static RootShare;

    public static class TextExtensions
    {
        /// <summary>
        /// Applies a function to a value
        /// </summary>
        /// <param name="x">The source value</param>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="X">The source value type</typeparam>
        /// <typeparam name="Y">The output value type</typeparam>
        [MethodImpl(Inline)]   
        static Y apply<X,Y>(X x,Func<X,Y> f)
            => f(x);

        /// <summary>
        /// Tests whether the source string is nonempty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        static bool nonempty(string src)
            => !String.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Tests whether the source string is empty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        static bool empty(string src)
            => String.IsNullOrWhiteSpace(src);

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
        /// Gets the string to the right of, but not including, the first instance of a specified character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character</param>
        public static string RightOf(this string s, char c)
            => s.RightOf(s.IndexOf(c));

        /// <summary>
        /// Gets the string to the right of, but not including, a specified index
        /// </summary>
        /// <param name="src">The string to search</param>
        /// <param name="idx">The index</param>
        public static string RightOf(this string src, int idx)
            => (idx >= src.Length - 1) ? String.Empty : src.Substring(idx + 1);

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

        /// <summary>
        /// Determines whether a string starts with a value from a supplied set
        /// </summary>
        /// <param name="src">The string to examine</param>
        /// <param name="values">The characters for which to search</param>
        public static bool StartsWithAny(this string src, IEnumerable<string> values)
        {
            foreach (var v in values)
                if (src.StartsWith(v))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether a string terminates with a value from a supplied set
        /// </summary>
        /// <param name="src">The string to examine</param>
        /// <param name="values">The characters for which to search</param>
        public static bool EndsWithAny(this string src, IEnumerable<string> values)
        {
            foreach (var v in values)
                if (src.EndsWith(v))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether a string begins with a specific character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character to match</param>
        [MethodImpl(Inline)]
        public static bool StartsWith(this string s, char c)
            => nonempty(s) ? s.StartsWith(c.ToString()) : false;

        /// <summary>
        /// Determines whether a string ends with a specific character
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The character to match</param>
        [MethodImpl(Inline)]
        public static bool EndsWith(this string s, char c)
            => nonempty(s) ? s.EndsWith(c.ToString()) : false;

        /// <summary>
        /// Determines whether a string starts with a digit
        /// </summary>
        /// <param name="s">The string to search</param>
        [MethodImpl(Inline)]
        public static bool StartsWithDigit(this string s)
            => nonempty(s) ? Char.IsDigit(s.First()) : false;

        /// <summary>
        /// Determines whether a string ends with a digit
        /// </summary>
        /// <param name="s">The string to search</param>
        [MethodImpl(Inline)]
        public static bool EndsWithDigit(this string s)
            => nonempty(s) ? Char.IsDigit(s.Last()) : false;

        /// <summary>
        /// Determines whether a string leads with any of a specified set of characters
        /// </summary>
        /// <param name="src">The string to examine</param>
        /// <param name="chars">The characters for which to search</param>
        public static bool StartsWithAny(this string src, IEnumerable<char> chars)
            => empty(src) ? false : chars.Contains(src[0]);

        /// <summary>
        /// Determines whether a string contains any of the characters in a supplied sequence
        /// </summary>
        /// <param name="src">The string to test</param>
        /// <param name="chars">The characters for which to search</param>
        public static bool ContainsAny(this string src, IEnumerable<char> chars)
        {
            foreach (var c in chars)
                if (src.Contains(c))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether a string contains any of the supplied substrings
        /// </summary>
        /// <param name="src">The string to test</param>
        /// <param name="substrings">The characters for which to search</param>
        public static bool ContainsAny(this string src, params string[] substrings)
        {
            foreach (var c in substrings)
                if (src.Contains(c))
                    return true;
            return false;
        }

        /// <summary>
        /// Determines whether a string contains any of the supplied substrings
        /// </summary>
        /// <param name="src">The string to test</param>
        /// <param name="substrings">The characters for which to search</param>
        public static bool ContainsAny(this string src, IEnumerable<string> substrings)
            => substrings.Any(ss => src.Contains(ss));

        /// <summary>
        /// Selects the substring prior to the first occurrence of a specified character if it is found in the string; otherwise, 
        /// returns the original string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The marking character</param>
        public static string TakeBefore(this string s, char c)
        {
            var found = -1;
            for(var i=0; i<s.Length; i++)
            {
                if(s[i] == c)
                {
                    found = i;
                    break;
                }
            }
            return found != -1 ? s.Substring(0, found) : s;
        }

        /// <summary>
        /// Selects the substring after the first ocurrence of a specified character it is found in the string; otherwise, 
        /// returns the original string
        /// </summary>
        /// <param name="s">The string to search</param>
        /// <param name="c">The marking character</param>
        public static string TakeAfter(this string s, char c)
        {
            var found = -1;
            for(var i=0; i<s.Length; i++)
            {
                if(s[i] == c)
                {
                    found = i;
                    break;
                }
            }

            return found != -1 ? s.Substring(found + 1) : s;
        }

        public static string Concat(this Span<string> src, string sep)
        {
            var sb = new StringBuilder();
            for(var i=0; i<src.Length; i++)   
            {
                ref var cell = ref src[i];
                if(i != src.Length - 1)
                    sb.Append($"{cell}{sep}");
                else
                    sb.Append(cell);
            }
            return sb.ToString();
        }

        public static string Concat(this Span<string> src)
            => src.Concat(string.Empty);

        public static string Concat(this Span<string> src, char sep)
            => src.Concat(sep.ToString());

        /// <summary>
        /// Joins the strings provided by the enumerable with an optional separator
        /// </summary>
        /// <param name="src">The source strings</param>
        /// <param name="sep">The separator, if any</param>
        public static string Concat(this IEnumerable<string> src, string sep = null)
            => string.Join(sep ?? string.Empty, src);

        public static string Concat(this IEnumerable<string> src, char sep)
            => string.Join(sep, src);

        public static string Concat(this ReadOnlySpan<string> src, string sep = null)
        {
            var delimiter = sep ?? " | ";
            var sb = new StringBuilder();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0)
                    sb.Append(delimiter);                
                sb.Append(src[i]);            
            }
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if a string is null or whitespace; otherwise, returns false
        /// </summary>
        /// <param name="s">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool IsBlank(this string s)
            => String.IsNullOrWhiteSpace(s);

        /// <summary>
        /// Returns true if a string has at least one character that is not considered whitespace
        /// </summary>
        /// <param name="s">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool IsNotBlank(this string s)
            => !s.IsBlank();

        /// <summary>
        /// Returns the source string if it is not blank; otherwise, returns an alternate string
        /// </summary>
        /// <param name="src">The soruce string</param>
        /// <param name="alt">The alternate string</param>
        [MethodImpl(Inline)]
        public static string IfBlank(this string src, string alt)
            => String.IsNullOrWhiteSpace(src) ? alt : src;

        /// <summary>
        /// Invokes an action if the source string is nonempty
        /// </summary>
        /// <param name="s">The string to evaluate</param>
        /// <param name="f">The action to conditionally invoke</param>
        [MethodImpl(Inline)]
        public static void OnSome(this string s, Action<string> f)
        {
            if(s.IsNotBlank())
                f(s);
        }

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
        /// Creates a new string by weaving a specified character between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="c">The character to intersperse</param>
        public static string Intersperse(this string src, char c)
        {
            var sb = new StringBuilder();
            foreach(var item in src)
            {
                sb.Append(item);
                sb.Append(c);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Creates a new string by weaving a substring between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="sep">The value to intersperse</param>
        public static string Intersperse(this string src, string sep)
        {
            var sb = new StringBuilder();
            foreach(var item in src)
            {
                sb.Append(item);
                sb.Append(sep);
            }
            return sb.ToString();
        }
    }
}