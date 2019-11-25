//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class t_bitmap : ScalarBitTest<t_bitmap>
    {            

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

        public void clear_8u()
            => clear_check<byte>();

        public void clear_16u()
            => clear_check<ushort>();

        public void clear_32u()
            => clear_check<uint>();

        public void clear_64u()
            => clear_check<ulong>();

        public void bitmap_8x64()
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

        public void inject_64u_basecase()
        {
            ulong src = 0b10101010;
            ulong dst = 0b11111111_11111111_11111111_11111111_11111111_11111111_11111111_11111111;   
            ulong exp = 0b11111111_11111111_11111111_11111111_11111111_10101010_11111111_11111111;            
            byte start = 16;
            byte len = 8;
            var result = Bits.inject(src, dst, start,len);
            Claim.eq(exp,result);            

        }

        public void inject_64()
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


        public void inject_32()
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

        void clear_check<T>()
            where T : unmanaged
        {
            var width = (int)bitsize<T>();
            var p0 = Random.Next(2, width/2 - 1);
            var p1 = Random.Next(width/2 + 1, width - 2);
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.Next<T>();
                var y = BitString.from(gbits.clear(x, p0,p1));
                var z = BitString.from(x).Clear(p0,p1);
                Claim.eq(y,z);            
            }

        }

    }

}