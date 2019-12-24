//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_vb_sub : t_bv<t_vb_sub>
    {
        public void pbv_sub_8()
        {
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.BitVector(n8);
                var y = Random.BitVector(n8);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x - y).Scalar);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x + -y).Scalar);
                Claim.eq(math.sub(x.Scalar,  (byte)1), (--x).Scalar);
            }
        }

        public void pbv_sub_16()
        {
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.BitVector(n16);
                var y = Random.BitVector(n16);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x - y).Scalar);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x + -y).Scalar);
                Claim.eq(math.sub(x.Scalar,  (ushort)1), (--x).Scalar);
            }
        }

        public void pbv_sub_32()
        {
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.BitVector(n32);
                var y = Random.BitVector(n32);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x - y).Scalar);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x + -y).Scalar);
                Claim.eq(math.sub(x.Scalar,  1u), (--x).Scalar);
            }
        }

        public void pbv_sub_64()
        {
            for(var i=0; i<SampleCount; i++)
            {
                var x = Random.BitVector(n64);
                var y = Random.BitVector(n64);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x - y).Scalar);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x + -y).Scalar);
                Claim.eq(math.sub(x.Scalar,  1ul), (--x).Scalar);
            }
        }
    }
}