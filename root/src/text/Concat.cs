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

    using static Root;

    partial class TextExtensions
    {
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

        public static string Concat(this ReadOnlySpan<string> src, string delimiter = null)
        {
            var sb = new StringBuilder();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0 && delimiter != null)
                    sb.Append(delimiter);                
                sb.Append(src[i]);            
            }
            return sb.ToString();
        }

        public static string Concat(this ReadOnlySpan<string> src, char? delimiter)
        {
            var sb = new StringBuilder();
            for(var i=0; i<src.Length; i++)
            {
                if(i != 0 && delimiter != null)
                    sb.Append(delimiter.Value);                
                sb.Append(src[i]);            
            }
            return sb.ToString();
        }

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

        /// <summary>
        /// Joins a sequence of source characters with optional interspersed separator
        /// </summary>
        /// <param name="chars">The characters to join</param>
        /// <param name="sep">The character to intersperse</param>
        public static string Concat(this IEnumerable<char> chars, char? sep = null)
        {
            if(sep == null)
                return new string(chars.ToSpan());
            else
                return new string(chars.Intersperse(sep.Value).ToSpan());                        
        }
    }
}