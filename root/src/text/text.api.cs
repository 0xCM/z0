//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text.RegularExpressions;
    using System.Text;

    using static Root;

    public static class text
    {
        /// <summary>
        /// Tests whether the source string is empty
        /// </summary>
        /// <param name="src">The string to evaluate</param>
        [MethodImpl(Inline)]
        public static bool isblank(string src)
            => string.IsNullOrWhiteSpace(src);

        /// <summary>
        /// A string-specific coalescing operation
        /// </summary>
        /// <param name="test">The subject string</param>
        /// <param name="replace">The replacement value if blank</param>
        [MethodImpl(Inline)]
        public static string ifblank(string test, string replace = null)
            => isblank(test) ? replace ?? string.Empty : test;

        /// <summary>
        /// Creates a span of replicated characters 
        /// </summary>
        /// <param name="src">The character to replicate</param>
        /// <param name="count">The replication count</param>
        public static ReadOnlySpan<char> replicate(char src, int count)
            => new string(src,count);


        /// <summary>
        /// Concatenates a sequence of strings
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        public static string concat(IEnumerable<string> src)
            => string.Concat(src);

        /// <summary>
        /// Concatenates a sequence of strings intersprsed by a character delimiter
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        public static string concat(IEnumerable<string> src, char sep)
            => string.Join(sep,src);

        /// <summary>
        /// Concatenates a sequence of characters
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        public static string concat(IEnumerable<char> src)
            => new string(src.ToArray());

        /// <summary>
        /// Joins the string representation of a sequence of values
        /// </summary>
        /// <param name="src">The values to be joined</param>
        /// <param name="sep">The value delimiter</param>
        public static string concat(IEnumerable<object> src, string sep)
            => string.Join(sep, src);

        /// <summary>
        /// Concatenates a character array
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        [MethodImpl(Inline)]
        public static string concat(params char[] src)
            => new string(src);

        /// <summary>
        /// Concatenates an array of strings
        /// </summary>
        /// <param name="src">The strings to concatenate</param>
        public static string concat(params string[] src)
            => string.Concat(src);
        
        /// <summary>
        /// Concatenates an arbitrary number of string representations
        /// </summary>
        /// <param name="src">The strings to be concatenated</param>
        public static string concat(params object[] src)    
            => string.Concat(src);

        public static string concat(ReadOnlySpan<string> src, string sep)
        {
            var sb = new StringBuilder();
            var lastix = src.Length - 1;
            for(var i=0; i<src.Length; i++)        
            {
                sb.Append(src[i]);
                if(i != lastix)
                    sb.Append(sep);
            }
            return sb.ToString();
        }

        public static string concat(Span<string> src, string sep)
            => concat(src.ReadOnly(), sep);

        /// <summary>
        /// Produces a line of content for each item in an array
        /// </summary>
        /// <param name="content">An content array</param>
        public static string lines(params string[] content)
        {
            var sb = new StringBuilder();
            foreach(var item in content)
                sb.AppendLine(item);
            return sb.ToString();
        }
    }
}
