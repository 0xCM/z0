//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct SpanFormatter<T> : ISpanFormatter<T>
        where T : ICustomFormattable
    {
        readonly SeqFormatConfig Config;

        [MethodImpl(Inline)]
        internal SpanFormatter(SeqFormatConfig config)
        {
            this.Config = config;
        }

        public string Format(ReadOnlySpan<T> src)
            => FormatItems(src).Concat(Config.Delimiter);

        public ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src)
        {
            var dst = new string[src.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = src[i].Format();
            return dst;
        }        
    }
}