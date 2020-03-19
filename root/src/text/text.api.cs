//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using System.Text;

    using static Root;

    public static partial class text
    {
        public static ITextFactory factory
        {
            [MethodImpl(Inline)]
            get => TextFactory.From(Root.factory<string>());
        }

        /// <summary>
        /// The non-null empty string
        /// </summary>
        public static string blank
        {
            [MethodImpl(Inline)]
            get => string.Empty;
        }

        /// <summary>
        /// Tests whether the source string is nonempty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool nonempty(string src)
            => !string.IsNullOrWhiteSpace(src);

        /// <summary>
        /// Tests whether the source string is empty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool empty(string src)
            => string.IsNullOrWhiteSpace(src);

        /// <summary>
        /// A string-specific coalescing operation
        /// </summary>
        /// <param name="test">The subject string</param>
        /// <param name="replace">The replacement value if blank</param>
        [MethodImpl(Inline)]
        public static string ifempty(string test, string replace)
            => empty(test) ? replace ?? string.Empty : test;

        /// <summary>
        /// If the test string is null, returns the empty string; otherwise, returns the test string
        /// </summary>
        /// <param name="test">The subject string</param>
        /// <param name="replace">The replacement value if blank</param>
        [MethodImpl(Inline)]
        public static string denullify(string test)
            => empty(test) ? string.Empty : test;

        /// <summary>
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="startidx">The index of the first character</param>
        [MethodImpl(Inline)]
        public static string slice(string src, int startidx)
            => denullify(src).Substring(startidx);        

        /// <summary>
        /// Extracts a substring
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="startidx">The index of the first character</param>
        /// <param name="length">The substring length</param>
        [MethodImpl(Inline)]
        public static string slice(string src, int startidx, int length)
            => denullify(src).Substring(startidx,length);        

        /// <summary>
        /// Splits the string, removing empty entries
        /// </summary>
        /// <param name="src">The source text</param>
        /// <param name="sep">The delimiter</param>
        [MethodImpl(Inline)]
        public static string[] split(string src, char sep)
            => denullify(src).Split(sep, StringSplitOptions.RemoveEmptyEntries);        

        [MethodImpl(Inline)]
        public static bool equals(string a, string b, bool cased = false)
            => string.Equals(a,b, cased ? StringComparison.InvariantCulture : StringComparison.InvariantCultureIgnoreCase);

        [MethodImpl(Inline)]
        public static int compare(string a, string b)
            => text.denullify(a).CompareTo(b);

        /// <summary>
        /// Creates a span of replicated characters 
        /// </summary>
        /// <param name="src">The character to replicate</param>
        /// <param name="count">The replication count</param>
        public static IEnumerable<char> replicate(char src, int count)
            => new string(src,count);

        /// <summary>
        /// Concatenates a sequence of values with no intervening delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        public static string concat(IEnumerable<object> src)    
            => string.Concat(src);

        /// <summary>
        /// Concatenates a sequence of characters with no intervening delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        public static string concat(IEnumerable<char> src)
            => new string(src.ToArray());

        /// <summary>
        /// Formats a custom-formattable elements
        /// </summary>
        /// <param name="src">The source element</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string format<T>(T src)
            where T : ICustomFormattable
                => denullify(src?.Format());

        /// <summary>
        /// Produces a sequence of formatted strings given a sequence of custom-formattable elements
        /// </summary>
        /// <param name="src">The source element</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<string> format<T>(IEnumerable<T> src)
            where T : ICustomFormattable
                => src.Select(x => x.Format());

        public static string format<T>(IEnumerable<T> src, string delimiter = null)
            where T : ICustomFormattable
        {
            var dst = factory.Builder();
            var count = 0;
            var sep = denullify(delimiter);
            void append(T item)
            {
                if(count != 0)
                    dst.Append(sep);
                 dst.Append(item.Format());   
            }

            return dst.ToString();
            
        }

        /// <summary>
        /// Concatenates a sequence of strings intersprsed by a character delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        public static string concat(char sep, IEnumerable<object> src)
            => string.Join(sep,src);

        /// <summary>
        /// Joins the string representation of a sequence of items interspersed by a separator
        /// </summary>
        /// <param name="sep">The value delimiter</param>
        /// <param name="src">The values to be joined</param>
        public static string concat(string sep, IEnumerable<object> src)
            => string.Join(sep, src);

        /// <summary>
        /// Joins the string representation of a sequence of items with no interspersed separator
        /// </summary>
        /// <param name="src">The values to be joined</param>
        public static string concat(params object[] src)    
            => string.Concat(src);

        public static string concat(string sep, ReadOnlySpan<string> src)
        {
            var builder = factory.Builder();
            var lastix = src.Length - 1;
            for(var i=0; i<src.Length; i++)        
            {
                builder.Append(src[i]);
                if(i != lastix)
                    builder.Append(sep);
            }
            return builder.ToString();
        }

        public static string concat(string sep, Span<string> src)
            => concat(sep, src.ReadOnly());

        /// <summary>
        /// Produces a line of content for each item in an array
        /// </summary>
        /// <param name="content">An content array</param>
        public static string lines(params string[] content)
        {
            var builder = factory.Builder();
            foreach(var item in content)
                builder.AppendLine(item);
            return builder.ToString();
        }

        /// <summary>
        /// Repeats a string a specified number of times
        /// </summary>
        /// <param name="src">The text content to replicate</param>
        /// <param name="count">The number of copies to produce</param>
        public static IEnumerable<string> replicate(string src, int count)
        {
            for(var i=0; i<count; i++)
                yield return src;
        }

        /// <summary>
        /// Creates a new string by weaving a specified character between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="c">The character to intersperse</param>
        public static string intersperse(string src, char c)
        {
            var builder = text.factory.Builder();
            foreach(var item in src)
            {
                builder.Append(item);
                builder.Append(c);
            }
            return builder.ToString();
        }

        /// <summary>
        /// Creates a new string by weaving a substring between each character in the source
        /// </summary>
        /// <param name="src">The source string</param>
        /// <param name="sep">The value to intersperse</param>
        public static string intersperse(string src, string sep)
        {
            var builder = text.factory.Builder();
            foreach(var item in src)
            {
                builder.Append(item);
                builder.Append(sep);
            }
            return builder.ToString();
        }

        /// <summary>
        /// Creates a complied regular expression and (c)aches it
        /// </summary>
        /// <param name="pattern">The regex pattern/></param>
        public static Regex regex(string pattern)
            => RegExCache.GetOrAdd(pattern, p => MakeRegEx(p));

        /// <summary>
        /// Creates a complied regular expression from the supplied pattern
        /// </summary>
        /// <param name="pattern">The regex pattern/></param>
        static Regex MakeRegEx(string pattern)
            => new Regex(pattern, RegexOptions.Compiled);

        static readonly ConcurrentDictionary<string, Regex> RegExCache
            = new ConcurrentDictionary<string, Regex>();
    }
}
