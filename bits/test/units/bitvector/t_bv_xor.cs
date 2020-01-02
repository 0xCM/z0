//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bv_xor : t_bv<t_bv_xor>
    {
        void bv_xor_4()
        {
            for(var i=0; i<RepCount; i++)
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


        public void nbc_xor_13x8()
        {
            var x0 = Random.BitBlock<N13,byte>();
            var y0 = Random.BitBlock<N13,byte>();
            var z0 = x0 ^ y0;
            var x1 = x0.ToBitVector(n16);
            var y1 = y0.ToBitVector(n16);
            var z1 = x1 ^ y1;
            Claim.eq(z0.ToBitVector(n16),z1);
        }

        void bv_xor_128()
        {
            for(var i=0; i< RepCount; i++)
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

    }
}