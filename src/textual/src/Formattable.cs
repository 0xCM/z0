//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using static Seed;
        
    public static class Formattable
    {
        /// <summary>
        /// Formats a type that provides intrinsic format capability
        /// </summary>
        /// <param name="src">The value to format</param>
        /// <typeparam name="T">The formattable value type</typeparam>
        [MethodImpl(Inline)]
        public static string format<T>(T src)
            where T : ITextual
                => src.Format();

        [MethodImpl(Inline)]
        public static string format<T>(ReadOnlySpan<T> src, string delimiter = null)
            where T : ITextual
                => span<T>(delimiter).Format(src);

        public static IEnumerable<string> items<F>(IEnumerable<F> items)
            where F : ITextual
                => items.Select(m => m.Format());                

        [MethodImpl(Inline)]
        public static string numeric<F>(F src)
            where F : unmanaged, INumericFormatProvider<F>
                => src.Formatter.Format(src);

        [MethodImpl(Inline)]
        public static string numeric<F>(F src, NumericBaseKind @base)
            where F : unmanaged, INumericFormatProvider<F>
                => src.Formatter.Format(src, @base);

        /// <summary>
        /// Formats a sequence of formattable things as delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="sep">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <param name="offset">The index of the source element at which formatting will begin</param>
        /// <typeparam name="T">A formattable type</typeparam>
        [MethodImpl(Inline)]        
        public static string list<T>(ReadOnlySpan<T> src, char sep = Chars.Comma, int offset = 0)
            where T : ITextual
        {
            if(src.Length == 0)
                return string.Empty;
            
            var dst = new StringBuilder();
            
            for(var i = offset; i< src.Length; i++)
            {
                if(i!=offset)
                {
                    dst.Append(sep);
                    dst.Append(Chars.Space);
                }
                dst.Append(src[i].Format());
            }
            return dst.ToString();
        }

        /// <summary>
        /// Formats a sequence of formattable things as delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter, if specified; otherwise, a system default is chosen</param>
        /// <param name="offset">The index of the source element at which formatting will begin</param>
        /// <typeparam name="T">A formattable type</typeparam>
        [MethodImpl(Inline)]        
        public static string list<T>(IEnumerable<T> src, char? delimiter = null, int offset = 0)
            where T : ITextual
                => string.Join(delimiter ?? Chars.Comma, src.Skip(0).Select(x => x.Format()));                

        [MethodImpl(Inline)]
        static SpanFormatter<T> span<T>(string delimiter = null)
            where T : ITextual
                => new SpanFormatter<T>(SeqFormatConfig.Define(delimiter ?? DefaultSeqFormatConfig.Default.Delimiter));
    }
}