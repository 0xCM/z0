//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public class tbv_xor : BitVectorTest<tbv_xor>
    {


        public void bvxor_n13x8u_check()
        {
            var x0 = Random.BitVector<N13,byte>();
            var y0 = Random.BitVector<N13,byte>();
            var z0 = x0 ^ y0;
            var x1 = x0.ToPrimal16();
            var y1 = y0.ToPrimal16();
            var z1 = x1 ^ y1;
            Claim.eq(z0.ToPrimal16(),z1);
        }

        public void bvxor_g8_fixed()
        {
            bv_xor_check<BitVector8,byte>();
        }

        public void bvxor_g16_fixed()
        {
            bv_xor_check<BitVector16,ushort>();
        }

        public void bvxor_g32_fixed()
        {
            bv_xor_check<BitVector32,uint>();
        }


        public void bvxor_g64_fixed()
        {
            bv_xor_check<BitVector64,ulong>();
        }

        public void bv_xor128()
        {
            bv_xor128_check();
        }

        void bv_xor_check<V,S>()
            where V : unmanaged, IPrimalBitVector<V,S>
            where S : unmanaged
        {
            for(var i = 0; i< SampleSize; i++)
            {
                var x = Random.Next<S>();
                var y = Random.Next<S>();
                var z = gmath.xor(x, y);

                var v1 = PrimalBits.define<V,S>(x);
                var v2 = PrimalBits.define<V,S>(y);
                var v3 = v1 ^ v2;
                Claim.eq(v3.Scalar, z);
            }

        }

        void bv_xor128_check()
        {
            var vectors = Random.BitVectors(n128);
            for(var i=0; i< SampleSize; i++)
            {
                var x = vectors.First();
                var y = vectors.First();
                var z = x ^ y;

                var xbs = x.ToBitString();
                var ybs = y.ToBitString();
                var zbs = xbs ^ ybs;

                Claim.eq(zbs, z.ToBitString());
            }


        }

    }

}