//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Control;    

    /// <summary>
    /// Configurable bit data type formatter
    /// </summary>
    public readonly struct BitFormatter<T> : IBitFormatter<T>
        where T : struct
    {                                    
        public string Format(ReadOnlySpan<byte> src, in BitFormatConfig config)
        {
            
            const char zero = Chars.D0;

            var bits = src.Length*8;
            Span<char> dst = stackalloc char[bits];
            dst.Fill(zero);

            BitFormatter.Service.Format(src,config.MaxBitCount,dst);
            
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
            var zero = Chars.D0;
            var bytes = Control.bytes(src);
            return Format(bytes,config);
        }

        public string Format(T src)
            => Format(src, BitFormatConfig.Default);
    }
}