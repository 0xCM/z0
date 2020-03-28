//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    
    using static Textual;

    public static class HexFormatter 
    {
        [MethodImpl(Inline)]
        public static HexFormatter<T> Define<T>()
            where T : unmanaged
                => new HexFormatter<T>(BaseHexFormatters.Create<T>());                   
    }
    
    public readonly struct HexFormatter<T> : IHexFormatter<T>
        where T : unmanaged
    {
        static HexFormatConfig DefaultConfig => HexFormatConfig.Define();

        static HexSeqFormatConfig DefaultSeqConfig => HexSeqFormatConfig.Define(DefaultConfig);

        readonly ISystemHexFormatter<T> BaseFormatter;
        
        [MethodImpl(Inline)]
        internal HexFormatter(ISystemHexFormatter<T> formatter)
        {
            this.BaseFormatter = formatter;
        }

        [MethodImpl(Inline)]
        public string FormatItem(object item)
            => FormatItem((T)item);

        [MethodImpl(Inline)]
        public string FormatItem(object item, string format)
            => BaseFormatter.Format(item, format);
        
        [MethodImpl(Inline)]
        public string FormatItem(T src)
            => FormatItem(src, DefaultConfig);

        [MethodImpl(Inline)]
        public string FormatItem(T src, in HexFormatConfig hex)
            => text.concat(
                hex.Specifier && hex.Specifier ? HexFormatConfig.PreSpecString : string.Empty, 
                hex.ZPad ? BaseFormatter.Format(src, hex.FormatString).PadLeft(core.size<T>()*2, '0') : BaseFormatter.Format(src, hex.FormatString),
                hex.Specifier && !hex.PreSpec ? HexFormatConfig.PostSpecString : string.Empty
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
            var result = text.build();

            for(var i = 0; i<src.Length; i++)
            {
                var formatted = Hex.format(src[i], hex.ZPad, hex.Specifier, hex.Uppercase, hex.PreSpec);
                result.Append(formatted);
                if(i != src.Length - 1)
                    result.Append(seq.Delimiter);
            }
                        
            return result.ToString();
        }

        public string Format(ReadOnlySpan<T> src, in HexSeqFormatConfig seq)
        {
            var result = text.build();
            var config = seq.HexFormat;

            for(var i = 0; i<src.Length; i++)
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
    }
}