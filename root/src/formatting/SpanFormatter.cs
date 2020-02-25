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
            where T : ICustomFormattable
                => new SpanFormatter<T>(SeqFormatConfig.Define(delimiter ?? DefaultSeqFormatConfig.Default.Delimiter));
    }

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

    public readonly struct SpanFormatter<T, C> : ISpanFormatter<T, C>
        where T : ICustomFormattable
        where C : ISeqFormatConfig
    {
        public string Format(ReadOnlySpan<T> src, in C config)
            => FormatItems(src).Concat(config.Delimiter);

        public string Format(ReadOnlySpan<T> src)
            => FormatItems(src).Concat(DefaultSeqFormatConfig.Default.Delimiter);

        public ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src, in C config)
            => FormatItems(src);

        public ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src)
        {
            var dst = new string[src.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = src[i].Format();
            return dst;
        }        
    }

}