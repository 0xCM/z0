//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;
    using static z;
    using api = Render;
    
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
            ref readonly var b = ref @as<T,byte>(src);
            for(var i=0u; i<CellSize; i++)
            {
                var symbols = Hex.symbols(skip(b,i), LowerCase);
                for(var j=0u; j<CellSize; j++)
                    seek(dst,j) = skip(symbols, j);
            }                    
        }

        [MethodImpl(Inline)]
        public void Format(ReadOnlySpan<T> src, StringBuilder dst)
            => api.hex(src,Config,dst);
        
        public string Format(ReadOnlySpan<T> src)
        {
            var dst = text.build();
            Format(src,dst);                        
            return dst.ToString();
        }
    }
}