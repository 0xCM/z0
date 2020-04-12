//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public class t_bvsub : t_bitvectors<t_bvsub>
    {
        public void bvsub_8()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitVector(n8);
                var y = Random.BitVector(n8);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x - y).Scalar);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x + -y).Scalar);
                Claim.eq(math.sub(x.Scalar,  (byte)1), (--x).Scalar);
            }
        }

        public void bvsub_16()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitVector(n16);
                var y = Random.BitVector(n16);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x - y).Scalar);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x + -y).Scalar);
                Claim.eq(math.sub(x.Scalar,  (ushort)1), (--x).Scalar);
            }
        }

        public void bvsub_32()
        {
            for(var i=0; i<RepCount; i++)
            {
                var x = Random.BitVector(n32);
                var y = Random.BitVector(n32);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x - y).Scalar);
                Claim.eq(math.sub(x.Scalar,  y.Scalar), (x + -y).Scalar);
                Claim.eq(math.sub(x.Scalar,  1u), (--x).Scalar);
            }
        }

        public void bvsub_64()
        {
            for(var i=0; i<RepCount; i++)
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