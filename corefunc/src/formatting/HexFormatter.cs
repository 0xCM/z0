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

    using static zfunc;


    public static class HexFormatter 
    {
        [MethodImpl(Inline)]
        public static HexFormatter<T> Define<T>()
            where T : unmanaged
                => new HexFormatter<T>(BaseHexFormatters.Create<T>());                   
    }

    public interface IHexFormatter<T> : IFormatter<T,HexFormat>
        where T : struct
         
    {
        string Format(ReadOnlySpan<T> src, in HexFormat config);
    }    
    
    public readonly struct HexFormatter<T> : IHexFormatter<T>
        where T : unmanaged
    {
        static HexFormat DefaultFormat => HexFormat.Define();

        readonly IBaseHexFormatter<T> BaseFormatter;
        
        [MethodImpl(Inline)]
        internal HexFormatter(IBaseHexFormatter<T> formatter)
        {
            this.BaseFormatter = formatter;
        }

        [MethodImpl(Inline)]
        public string Format(T src)
            => Format(src,DefaultFormat);

        [MethodImpl(Inline)]
        public string Format(T src, in HexFormat config)
            => concat(
                config.Specifier && config.Specifier ? HexFormat.PreSpecString : string.Empty, 
                config.ZPad ? BaseFormatter.Format(src,config.FormatString).PadLeft(size<T>()*2, '0') : BaseFormatter.Format(src,config.FormatString),
                config.Specifier && !config.PreSpec ? HexFormat.PostSpecString : string.Empty
                );

        public string Format(ReadOnlySpan<T> src, in HexFormat config)
        {            
            var result = new StringBuilder();

            for(var i = 0; i<src.Length; i++)
            {
                var formatted = Hex.format(src[i], config.ZPad, config.Specifier, config.Uppercase, config.PreSpec);
                result.Append(formatted);
                if(i != src.Length - 1)
                    result.Append(config.Delimiter);
            }
                        
            return result.ToString();
        }
    }
}