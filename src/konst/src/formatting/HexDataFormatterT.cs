//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static z;
    
    public readonly struct HexDataFormatter<T>
        where T : unmanaged
    {            
        public readonly HexFormatConfig Config;

        public readonly byte CellSize;
    
        [MethodImpl(Inline)]
        public HexDataFormatter(in HexFormatConfig config)
        {
            Config = config;
            CellSize = (byte)size<T>();
        }

        [MethodImpl(Inline)]
        public void Symbols(in T src, Span<HexSymLo> dst)
        {
            ref readonly var b = ref z.@as<T,byte>(src);
            for(var i=0u; i<CellSize; i++)
            {
                var symbols = Hex.symbols(skip(b,i), LowerCase);
                for(var j=0u; j<CellSize; j++)
                    seek(dst,j) = skip(symbols, j);
            }                    
        }
        
        public string Format(ReadOnlySpan<T> src)
        {
            var result = text.build();

            for(var i=0; i<src.Length; i++)
            {
                var formatted = Hex.format(src[i], Config.ZPad, Config.Specifier, Config.Uppercase, Config.PreSpec);
                result.Append(formatted);
                if(i != src.Length - 1)
                    result.Append(Config.Delimiter);
            }
                        
            return result.ToString();
        }
    }
}