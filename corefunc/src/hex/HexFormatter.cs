//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Text;
    
    using static Root;

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
        static HexFormat DefaultConfig => HexFormat.Define();

        static HexSeqFormat DefaultSeqConfig => HexSeqFormat.Define(DefaultConfig);

        readonly IBaseHexFormatter<T> BaseFormatter;
        
        [MethodImpl(Inline)]
        internal HexFormatter(IBaseHexFormatter<T> formatter)
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
        public string FormatItem(T src, in HexFormat hex)
            => text.concat(
                hex.Specifier && hex.Specifier ? HexFormat.PreSpecString : string.Empty, 
                hex.ZPad ? BaseFormatter.Format(src, hex.FormatString).PadLeft(size<T>()*2, '0') : BaseFormatter.Format(src, hex.FormatString),
                hex.Specifier && !hex.PreSpec ? HexFormat.PostSpecString : string.Empty
                );

        public ReadOnlySpan<string> FormatItems(ReadOnlySpan<T> src, in HexSeqFormat config)
        {
            Span<string> dst = new string[src.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = FormatItem(src[i], config.HexFormat);
            return dst;
        }

        public string Format(ReadOnlySpan<T> src, in HexSeqFormat seq, in HexFormat hex)
        {            
            var result = new StringBuilder();

            for(var i = 0; i<src.Length; i++)
            {
                var formatted = Hex.format(src[i], hex.ZPad, hex.Specifier, hex.Uppercase, hex.PreSpec);
                result.Append(formatted);
                if(i != src.Length - 1)
                    result.Append(seq.Delimiter);
            }
                        
            return result.ToString();
        }

        public string Format(ReadOnlySpan<T> src, in HexSeqFormat seq)
        {
            var result = new StringBuilder();
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