//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Creates a new stringbuilder
        /// </summary>
        static StringBuilder build()
            => new StringBuilder();

        /// <summary>
        /// Joins the strings provided by the enumerable with an optional separator
        /// </summary>
        /// <param name="src">The source strings</param>
        /// <param name="sep">The separator, if any</param>
        public static string Concat(this IEnumerable<string> src, string sep = null)
            => string.Join(sep ?? string.Empty, src);

        public static string Concat(this IEnumerable<string> src, char sep)
            => string.Join(sep, src);

        public static string Concat(this ReadOnlySpan<string> src, string delimiter = null)
        {
            var dst = build();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0 && delimiter != null)
                    dst.Append(delimiter);                
                dst.Append(src[i]);            
            }
            return dst.ToString();
        }

        public static string Concat(this ReadOnlySpan<string> src, char? delimiter)
        {
            var dst = build();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0 && delimiter != null)
                    dst.Append(delimiter.Value);                
                dst.Append(src[i]);            
            }
            return dst.ToString();
        }

        /// <summary>
        /// Joins a sequence of source characters interspersed with a supplied separator
        /// </summary>
        /// <param name="chars">The characters to join</param>
        /// <param name="sep">The character to intersperse</param>
        public static string Concat(this IEnumerable<char> chars, char sep)
            => new string(chars.Intersperse(sep).ToSpan());

        /// <summary>
        /// Forms a string by source character justapostion
        /// </summary>
        /// <param name="src">The characters to concatenate</param>
        public static string Concat(this IEnumerable<char> src)
            => new string(src.ToArray());

        /// <summary>
        /// Forms a string from a character array
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]   
        public static string Concat(this char[] src)
            => new string(src);

        /// <summary>
        /// Forms a string by source character justapostion
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]   
        public static string Concat(this ReadOnlySpan<char> src)
            => new string(src);

        /// <summary>
        /// Forms a string by source character justapostion
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]   
        public static string Concat(this Span<char> src)
            => new string(src);

        /// <summary>
        /// Forms a string by source character justapostion
        /// </summary>
        /// <param name="src">The source span</param>
        [MethodImpl(Inline)]   
        public static ReadOnlySpan<char> Concat(this ReadOnlySpan<char> lhs, ReadOnlySpan<char> rhs)
            => lhs.Concat() + rhs.Concat();

        public static string Concat(this Span<string> src, string sep)
        {
            var dst = build();
            for(var i=0; i<src.Length; i++)   
            {
                ref var cell = ref src[i];
                if(i != src.Length - 1)
                    dst.Append($"{cell}{sep}");
                else
                    dst.Append(cell);
            }
            return dst.ToString();
        }

        /// <summary>
        /// Sequentially concatenates each indexed cell to the next without deimiters/interspersal
        /// </summary>
        /// <param name="src">The source text</param>
        public static string Concat(this Span<string> src)
            => src.Concat(string.Empty);

        /// <summary>
        /// Sequentially concatenates each indexed cell to the next, separated by a specified character
        /// </summary>
        /// <param name="src">The source text</param>
        public static string Concat(this Span<string> src, char sep)
            => src.Concat(sep.ToString()); 
    }
}