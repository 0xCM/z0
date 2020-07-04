//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    
    public readonly struct HexFormatter<T> : IHexFormatter<T>
        where T : unmanaged
    {
        static HexFormatConfig DefaultConfig 
            => HexFormatConfig.Define();

        static HexSeqFormatConfig DefaultSeqConfig 
            => HexSeqFormatConfig.Define(DefaultConfig);

        readonly ISystemHexFormatter<T> BaseFormatter;
        
        [MethodImpl(Inline)]
        internal HexFormatter(ISystemHexFormatter<T> formatter)
        {
            this.BaseFormatter = formatter;
        }
        
        [MethodImpl(Inline)]
        public string FormatItem(T src)
            => FormatItem(src, DefaultConfig);

        [MethodImpl(Inline)]
        public string FormatItem(T src, in HexFormatConfig hex)
            => string.Concat(
                hex.Specifier && hex.Specifier ? HexSpecs.PreSpec : string.Empty, 
                hex.ZPad ? BaseFormatter.Format(src, hex.FormatCode).PadLeft(Unsafe.SizeOf<T>()*2, '0') : BaseFormatter.Format(src, hex.FormatCode),
                hex.Specifier && !hex.PreSpec ? HexSpecs.PostSpec : string.Empty
                );

        public ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src, in HexSeqFormatConfig config)
        {
            Span<string> dst = new string[src.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = FormatItem(src[i], config.HexFormat);
            return dst;
        }

        public string Format(ReadOnlySpan<T> src, in HexSeqFormatConfig seq, in HexFormatConfig hex)
        {            
            var result = string.Empty.Build();

            for(var i = 0; i<src.Length; i++)
            {
                var formatted = HexFormat.scalar(src[i], hex.ZPad, hex.Specifier, hex.Uppercase, hex.PreSpec);
                result.Append(formatted);
                if(i != src.Length - 1)
                    result.Append(seq.Delimiter);
            }
                        
            return result.ToString();
        }

        public string Format(ReadOnlySpan<T> src, in HexSeqFormatConfig seq)
        {
            var result = string.Empty.Build();
            var config = seq.HexFormat;

            for(var i = 0; i<src.Length; i++)
            {
                var formatted = HexFormat.scalar(src[i], config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);
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
    }
}