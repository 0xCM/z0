//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bv_xor : BitVectorTest<t_bv_xor>
    {
        public void bv_xor_4()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n4);
                var y = Random.BitVector(n4);
                var z = x ^ y;
                var xbs = x.ToBitString();
                Claim.eq(4, xbs.Length);

                var ybs = y.ToBitString();
                Claim.eq(4, ybs.Length);

                var zbs = xbs.Xor(ybs);

                Claim.eq(zbs, z.ToBitString());
            }
        }

        public void bv_xor_g8x7w()
            => bv_xor_check<byte>(7);

        public void bv_xor_g16x13w()
            => bv_xor_check<ushort>(13);

        public void bv_xor_g32x22w()
            => bv_xor_check<uint>(22);

        public void bv_xor_g64x19w()
            => bv_xor_check<ulong>(19);

        public void bv_xor_g64x53w()
            => bv_xor_check<ulong>(53);

        public void bvxor_n13x8u_check()
        {
            var x0 = Random.BitVector<N13,byte>();
            var y0 = Random.BitVector<N13,byte>();
            var z0 = x0 ^ y0;
            var x1 = x0.ToPrimal(n16);
            var y1 = y0.ToPrimal(n16);
            var z1 = x1 ^ y1;
            Claim.eq(z0.ToPrimal(n16),z1);
        }

        public void bv_xor_128()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var x = Random.BitVector(n128);
                var y = Random.BitVector(n128);
                var z = x ^ y;

                var xbs = x.ToBitString();
                var ybs = y.ToBitString();
                var zbs = xbs ^ ybs;

                Claim.eq(zbs, z.ToBitString());
            }
        }

        void bv_xor_check<T>(int width)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector<T>(width);
                Claim.lteq(BitVector.effwidth(x),width);
                
                var y = Random.BitVector<T>(width);
                Claim.lteq(BitVector.effwidth(y),width);

                var z = x ^ y;
                Claim.eq(gmath.xor(x.Data, y.Data), z.Data);

                var xbs = x.ToBitString().Truncate(width);
                Claim.eq(width, xbs.Length);

                var ybs = y.ToBitString().Truncate(width);
                Claim.eq(width, ybs.Length);

                var zbs = xbs.Xor(ybs);

                Claim.eq(zbs, z.ToBitString().Truncate(width));
            }
        }
    }
}