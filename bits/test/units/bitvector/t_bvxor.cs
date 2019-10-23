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
            var x1 = x0.ToPrimal(n16);
            var y1 = y0.ToPrimal(n16);
            var z1 = x1 ^ y1;
            Claim.eq(z0.ToPrimal(n16),z1);
        }


        public void bv_xor128()
        {
            bv_xor128_check();
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