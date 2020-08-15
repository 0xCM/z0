//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    public readonly struct HexFormatter<T> : ISpanFormatter<T,HexSequenceFormatConfig,HexFormatConfig>
        where T : unmanaged
    {
        readonly ISystemHexFormatter<T> BaseFormatter;
        
        [MethodImpl(Inline)]
        internal HexFormatter(ISystemHexFormatter<T> formatter)
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

        public ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src, in HexSequenceFormatConfig config)
        {
            Span<string> dst = new string[src.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = FormatItem(src[i], config.HexFormat);
            return dst;
        }

        public string Format(ReadOnlySpan<T> src, in HexSequenceFormatConfig seq, in HexFormatConfig hex)
        {            
            var result = string.Empty.Build();

            for(var i = 0; i<src.Length; i++)
            {
                var formatted = Hex.format(src[i], hex.ZPad, hex.Specifier, hex.Uppercase, hex.PreSpec);
                result.Append(formatted);
                if(i != src.Length - 1)
                    result.Append(seq.Delimiter);
            }
                        
            return result.ToString();
        }

        public string Format(ReadOnlySpan<T> src, in HexSequenceFormatConfig seq)
        {
            var result = text.build();
            var config = seq.HexFormat;

            for(var i=0; i<src.Length; i++)
            {
                var formatted = Hex.format(src[i], config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);
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
            => HexFormat.configure();

        static HexSequenceFormatConfig DefaultSeqConfig 
            => HexSequenceFormatConfig.define(DefaultConfig);    
    }
}