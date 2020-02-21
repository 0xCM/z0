//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static RootShare;

    public static class SpanFormatter
    {
        [MethodImpl(Inline)]
        public static SpanFormatter<T> @default<T>(char? delimiter = null)
            where T : IFormattable<T>
                => default(SpanFormatter<T>);
    }

    public readonly struct SpanFormatter<T> : ISpanFormatter<T>
        where T : IFormattable<T>
    {
        public char? Delimiter {get;}

        [MethodImpl(Inline)]
        internal SpanFormatter(char? delimiter)
        {
            this.Delimiter = delimiter;
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
    }
}