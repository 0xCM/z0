//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_butterfly : t_sb<t_bit_partition>    
    {
        public void bfly_4x2()
        {


        }

        //[0 1 2 3] -> [0 2 1 3]
        public void butterfly_16x64u()
        {
            for(var i=0; i< SampleCount; i++)
            {
                var x = Random.Next<ulong>();
                var y = gbits.bfly(n16, x);
                Bits.split(x, out var x0, out var x1, out var x2, out var x3);
                Bits.split(y, out var y0, out var y1, out var y2, out var y3);
                Claim.eq(x0,y0);
                Claim.eq(x1,y2);
                Claim.eq(x2,y1);
                Claim.eq(x3,y3);
            }
        }        

        // [0 1 2 3] -> [0 2 1 3]
        public void butterfly_32x8()
        {
            for(var i=0; i< SampleCount; i++)
            {
                var x = Random.Next<uint>();
                var y = gbits.bfly(n8, x);
                Bits.split(x, out var x0, out var x1, out var x2, out var x3);
                Bits.split(y, out var y0, out var y1, out var y2, out var y3);
                Claim.eq(x0,y0);
                Claim.eq(x1,y2);
                Claim.eq(x2,y1);
                Claim.eq(x3,y3);
            }
        }        

        /*
        swaps the interior 4-bit segments of each 16-bit segment.
        [0 | 1 2 | 3 || 4 | 5 6 | 7] -> 
        [0 | 2 1 | 3 || 4 | 6 5 | 7]            
        */

        public void butterfly_32x4()
        {
            for(var i=0; i< SampleCount; i++)
            {
                var a = Random.Next<uint>();
                var b = bitstring(Bits.bfly(n4, a));
                var c = bitstring(a);

                Claim.eq(BitString.scalar<byte>(c[0..3]), BitString.scalar<byte>(b[0..3]));
                Claim.eq(BitString.scalar<byte>(c[4..7]), BitString.scalar<byte>(b[8..11]));
                Claim.eq(BitString.scalar<byte>(c[8..11]), BitString.scalar<byte>(b[4..7]));
                Claim.eq(BitString.scalar<byte>(c[12..15]), BitString.scalar<byte>(b[12..15]));
                Claim.eq(BitString.scalar<byte>(c[16..19]), BitString.scalar<byte>(b[16..19]));
                Claim.eq(BitString.scalar<byte>(c[20..23]), BitString.scalar<byte>(b[24..27]));
                Claim.eq(BitString.scalar<byte>(c[24..27]), BitString.scalar<byte>(b[20..23]));
                Claim.eq(BitString.scalar<byte>(c[28..31]), BitString.scalar<byte>(b[28..31]));                            
            }

        }

    }
}