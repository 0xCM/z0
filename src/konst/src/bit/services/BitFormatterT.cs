//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static z;
    
    /// <summary>
    /// Configurable bit data type formatter
    /// </summary>
    public readonly struct BitFormatter<T> : IBitFormatter<T>
        where T : struct
    {                                  
        const char zero = Chars.D0;

        public string Format(ReadOnlySpan<byte> src, in BitFormatConfig config)
        {            
            var bits = src.Length*8;
            var dst = span<char>(bits);
            dst.Fill(zero);

            BitFormatter.Service.Format(src, config.MaxBitCount,dst);
            
            dst.Reverse();
            
            var bs = new string(dst);                
            
            if(config.TrimLeadingZeros)
                bs = bs.TrimStart(zero);
            
            if(config.ZPad != 0)
                bs = bs.PadLeft(config.ZPad, zero);
            
            if(config.BlockWidth != 0)
                bs = string.Join(config.BlockSep, bs.Partition(config.BlockWidth));
            
            return config.SpecifierPrefix ? "0b" + bs : bs;
        }
        
        public string Format(T src, in BitFormatConfig config)
        {
            var bytes = z.bytes(src);
            return Format(bytes,config);
        }

        public string Format(T src)
            => Format(src, BitFormatter.configure());
    }
}