//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_sb_bitmap : t_sb<t_sb_bitmap>
    {            
        public void sb_bitmap_basecase()
        {
            Claim.eq(7, Bits.pop(gbits.lomask<uint>(6)));
            Claim.eq(12, Bits.pop(gbits.lomask<uint>(11)));

        }

        void sb_bitmap_64()
        {
            byte start = 16;
            byte len = 12;

            for(var i=0; i<SampleSize; i++)
            {
                var src = 0b111111111111ul;                
                var bvSrc = src.ToBitVector();
                var dst = Random.Next<ulong>();                
                var bvDst = dst.ToBitVector();

                for(int j=start, k=0; j< start + len; j++,k++)
                    bvDst[j] = bvSrc[k];

                var bvActual = gbits.bitmap(src, dst, start, len).ToBitVector();
                Claim.eq(bvDst, bvActual);

                var bsActual = dst.ToBitString().BitMap(src.ToBitString(), start, len);
                var bsExpect = bvActual.ToBitString();
                Claim.eq(bsActual, bsExpect);
            }
        }

        void sb_bitmap_32()
        {
            for(var sample = 0; sample < SampleSize; sample++)
            {
                var src = Random.Next<uint>();
                var dst = Random.Next<uint>();

                var start = Random.Next<int>(0, bitsize<uint>()/4);
                var count = Random.Next<int>(0, bitsize<uint>()/4);

                var bvSrc = src.ToBitVector();
                var bvDst = dst.ToBitVector();
                for(int j=start, k=0; j< start + count; j++,k++)
                    bvDst[j] = bvSrc[k];

                var expect = bvDst.Scalar;

                var bsActual = dst.ToBitString().BitMap(src.ToBitString(), start, count);
                var bsExpect = expect.ToBitString();
                Claim.eq(bsActual, bsExpect);

                var actual = gbits.bitmap(src, dst, start, count);
                Claim.eq(bsExpect,actual.ToBitString());

                
            }
        }
    }

}