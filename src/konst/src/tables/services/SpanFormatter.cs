//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct SpanFormatter<T> : ISpanFormatter<T>
    {
        readonly SeqFormatConfig Config;

        [MethodImpl(Inline)]
        public SpanFormatter(SeqFormatConfig config)
            => Config = config;

        [MethodImpl(Inline)]
        public string Format(ReadOnlySpan<T> src)
            => FormatItems(src).Concat(Config.Delimiter);

        [MethodImpl(Inline)]
        public ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src)
        {
            var count = src.Length;
            var dst = z.span<string>(count);
            for(var i=0u; i<count; i++)
                z.seek(dst, i) = z.skip(src,i).ToString();
            return dst;
        }
    }
}