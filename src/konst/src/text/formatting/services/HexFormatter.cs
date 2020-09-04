//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using api = Render;

    public readonly struct HexFormatter<T> : ISpanFormatter<T,HexSeqFormat,HexFormatConfig>
        where T : unmanaged
    {
        readonly ISystemFormatter<T> BaseFormatter;

        [MethodImpl(Inline)]
        public HexFormatter(ISystemFormatter<T> formatter)
            => BaseFormatter = formatter;

        [MethodImpl(Inline)]
        public string FormatItem(T src)
            => FormatItem(src, DefaultConfig);

        [MethodImpl(Inline)]
        public string FormatItem(T src, in HexFormatConfig hex)
            => string.Concat(
                hex.Specifier && hex.Specifier ? HexFormatSpecs.PreSpec : string.Empty,
                hex.ZPad ? BaseFormatter.Format(src, hex.FormatCode).PadLeft(Unsafe.SizeOf<T>()*2, '0') : BaseFormatter.Format(src, hex.FormatCode),
                hex.Specifier && !hex.PreSpec ? HexFormatSpecs.PostSpec : string.Empty
                );

        public ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src, in HexSeqFormat config)
        {
            Span<string> dst = new string[src.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = FormatItem(src[i], config.HexFormat);
            return dst;
        }

        public string Format(ReadOnlySpan<T> src, in HexSeqFormat seq, in HexFormatConfig hex)
        {
            var result = string.Empty.Build();

            for(var i = 0; i<src.Length; i++)
            {
                var formatted = api.hex(src[i], hex.ZPad, hex.Specifier, hex.Uppercase, hex.PreSpec);
                result.Append(formatted);
                if(i != src.Length - 1)
                    result.Append(seq.Delimiter);
            }

            return result.ToString();
        }

        public string Format(ReadOnlySpan<T> src, in HexSeqFormat seq)
        {
            var result = text.build();
            var config = seq.HexFormat;

            for(var i=0; i<src.Length; i++)
            {
                var formatted = api.hex(src[i], config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);
                result.Append(formatted);
                if(i != src.Length - 1)
                    result.Append(seq.Delimiter);
            }

            return result.ToString();
        }

        public string Format(ReadOnlySpan<T> src)
            => Format(src, DefaultSeqConfig);

        public ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src)
            => FormatItems(src, DefaultSeqConfig);

        static HexFormatConfig DefaultConfig
            => FormatOptions.hex();

        static HexSeqFormat DefaultSeqConfig
            => HexSeqFormat.define(DefaultConfig);
    }
}