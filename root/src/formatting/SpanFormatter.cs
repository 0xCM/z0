//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class SpanFormatter
    {
        [MethodImpl(Inline)]
        public static SpanFormatter<T> @default<T>(string delimiter = null)
            where T : IFormattable<T>
                => new SpanFormatter<T>(delimiter);

        [MethodImpl(Inline)]
        public static SpanFormatter<T> @default<T>(char? delimiter)
            where T : IFormattable<T>
                => new SpanFormatter<T>(delimiter != null ? delimiter.Value.ToString() : string.Empty);
    }

    public readonly struct SpanFormatter<T> : ISpanFormatter<T>
        where T : IFormattable<T>
    {
        public string Delimiter {get;}

        [MethodImpl(Inline)]
        internal SpanFormatter(string delimiter)
        {
            this.Delimiter = delimiter ?? string.Empty;
        }

        public string Format(ReadOnlySpan<T> src)
            => FormatElements(src).Concat(Delimiter);

        public ReadOnlySpan<string> FormatElements(ReadOnlySpan<T> src)
        {
            var dst = new string[src.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = src[i].Format();
            return dst;
        }

        public string Format(object src)
            => throw new NotSupportedException("No can do; spans can never be objects! Use a better operand");
    }
}