//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;
    
    public class BitFormatter
    {
        [MethodImpl(Inline)]
        public static string format<T>(T src)
            where T : struct
                => create<T>().Format(src);

        [MethodImpl(Inline)]
        public static string format<T>(T src, BitFormatConfig config)
            where T : struct
                => create<T>().Format(src, config);

        [MethodImpl(Inline)]
        public static BitFormatter<T> create<T>()
            where T : struct
                => new BitFormatter<T>();
    }

    /// <summary>
    /// Configurable bit data type formatter
    /// </summary>
    public readonly struct BitFormatter<T> : IFormatter<BitFormatConfig,T>
        where T : struct
    {            
        
        public string Format(T src, in BitFormatConfig config)
        {
            var bytes = Bytes.from(ref src);
            var bits = bytes.Length*8;
            Span<char> dst = stackalloc char[bits];
            dst.Fill(bit.Zero);

            var k=0;
            for(var i=0; i<bytes.Length; i++)
            {
                for(var j=0; j<8; j++,k++)
                {                
                    if(k>=config.MaxBitCount)
                        break;

                    seek(dst, k) = bit.test(skip(bytes, i), j).ToChar();            
                }
                if(k >= config.MaxBitCount)
                    break;
            }
            
            dst.Reverse();
            
            var bs =new string(dst);                
            
            if(config.TrimLeadingZeros)
                bs = bs.TrimStart(bit.Zero);
            
            if(config.ZPad != 0)
                bs = bs.PadLeft(config.ZPad, bit.Zero);
            
            if(config.BlockWidth != 0)
                bs = string.Join(config.BlockSep, bs.Partition(config.BlockWidth));
            
            return config.SpecifierPrefix ? "0b" + bs : bs;                
        }

        public string Format(T src)
            => Format(src, BitFormatConfig.Default);
    }
}