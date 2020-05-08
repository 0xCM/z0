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
    
    public static class BitFormatter
    {
        [MethodImpl(Inline)]
        public static IFormatter<BitFormatConfig,T> Define<T>(BitFormatConfig config = default)
            where T : struct
                => new BitFormatter<T>(config);
    }

    /// <summary>
    /// Configurable bit data type formatter
    /// </summary>
    public readonly struct BitFormatter<T> : IFormatter<BitFormatConfig,T>
        where T : struct
    {            
        readonly BitFormatConfig DefaultConfig;
        
        [MethodImpl(Inline)]
        internal BitFormatter(BitFormatConfig config)
        {
            DefaultConfig = config;
        }

        public string Format(T src, in BitFormatConfig config)
        {
            var bytes = Bytes.from(ref src);
            Span<char> dst = new char[bytes.Length*8];
            dst.Fill(bit.Zero);
            var k=0;
            for(var i=0; i<bytes.Length; i++)
            {
                for(var j=0; j<8; j++,k++)
                {                
                    if(k>=config.MaxBitCount)
                        break;

                    seek(dst,k) = bit.test(skip(bytes, i),j).ToChar();            
                }
                if(k >= config.MaxBitCount)
                    break;
            }
            
            dst.Reverse();
            var bs =new string(dst);                
            if(config.TrimLeadingZeros)
                bs = bs.TrimStart(bit.Zero);
            if(config.BlockWidth != 0)
                bs = string.Join(config.BlockSep, bs.Partition(config.BlockWidth));
            
            return config.SpecifierPrefix ? "0b" + bs : bs;                
        }

        public string Format(T src)
            => Format(src, DefaultConfig);
    }
}