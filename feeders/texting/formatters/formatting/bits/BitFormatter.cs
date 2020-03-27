//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static refs;
    using static Textual;

    
    public readonly struct BitFormatter<T> : IFormatter<T,BitFormatConfig>
        where T : struct
    {            
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
            => Format(src,BitFormatConfig.Default);
    }
}