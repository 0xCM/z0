//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

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
            var dst = span<string>(count);
            for(var i=0u; i<count; i++)
                seek(dst, i) = skip(src,i).ToString();
            return dst;
        }
    }
}