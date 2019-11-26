//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_bitmap : t_sb<t_sb_bitmap>
    {            
        public void sb_clear_8()
            => gsb_clear_check<byte>();

        public void sb_clear_16()
            => gsb_clear_check<ushort>();

        public void sb_clear_32()
            => gsb_clear_check<uint>();

        public void sb_clear_64()
            => gsb_clear_check<ulong>();


        public void bitspan_rand_check()
        {
            var dst = span<bit>(1024);
            var on = 0;
            var off = 0;
            for(var j = 0; j < Pow2.T04; j++)
            {
                Random.Fill(dst);
                for(var i=0; i<dst.Length; i++)
                    if(dst[i]) 
                        on++; 
                    else 
                        off++;                
            }
            var ratio = fmath.div(on,off);
            var error = fmath.abs(ratio - 1.0f);
            Claim.lt(error,.1);            
        }

        public void sb_bitmap_8x64()
        {
            var dst = 0ul;
            byte srclen = 8;
            byte srcOffset = 0;
            BitVector64 src = 0b11110000110011001010101011111111ul;
            
            Bits.bitmap(src.Byte(0), srcOffset, srclen, 0, ref dst);
            Bits.bitmap(src.Byte(1), srcOffset, srclen, 8, ref dst);
            Bits.bitmap(src.Byte(2), srcOffset, srclen, 8, ref dst);
            Bits.bitmap(src.Byte(3), srcOffset, srclen, 8, ref dst);

            BitVector64 expect = 0b11111111101010101100110011110000ul;
            BitVector64 actual = dst;

            Claim.eq(expect, actual);        
        }

        public void sb_inject_basecase()
        {
            ulong src = 0b10101010;
            ulong dst = 0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_11111111;   
            ulong exp = 0b11111111_11111111_11111111_11111111_11111111_10101010_11111111_11111111;            
            byte start = 16;
            byte len = 8;
            var result = Bits.inject(src, dst, start,len);
            Claim.eq(exp,result);            
        }

        public void sb_inject_64()
        {
            byte start = 16;
            byte len = 12;
            for(var i=0; i<SampleSize; i++)
            {
                BitVector64 src = 0b111111111111;
                BitVector64 dst = Random.Next<ulong>();
                BitVector64 x = Bits.inject(src, dst, start, len);
                BitVector64 y = dst;
                for(int j=start, k=0; j< start + len; j++,k++)
                    y[j] = src[k];
                if(x != y)
                {
                    Trace(x.Format(blockWidth:8));
                    Trace(y.Format(blockWidth:8));
                }
                Claim.eq(x,y);

                var bs = dst.ToBitString().Inject(src.ToBitString(), start,len);
                Claim.eq(bs, y.ToBitString());
            }
        }

        public void sb_inject_32()
        {
            byte start = 16;
            byte len = 12;
            for(var i=0; i<SampleSize; i++)
            {
                BitVector32 src = 0b111111110101;
                BitVector32 dst = Random.Next<uint>();
                BitVector32 x = Bits.inject(src, dst, start, len);
                BitVector32 y = dst;
                for(int j=start, k=0; j< start + len; j++,k++)
                    y[j] = src[k];
                Claim.eq(x,y);

                var bs = dst.ToBitString().Inject(src.ToBitString(), start,len);
                Claim.eq(bs, y.ToBitString());
            }
        }
    }
}