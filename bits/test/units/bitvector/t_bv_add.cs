//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;


    public class t_bv_add : BitVectorTest<t_bv_add>
    {

        public void bvadd_8()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n8);
                var y = Random.BitVector(n8);
                Claim.eq(math.add(x.Scalar,  y.Scalar), (x + y).Scalar);
                Claim.eq(math.add(x.Scalar,  (byte)1), (++x).Scalar);

            }
        }

        public void bvadd_16()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n16);
                var y = Random.BitVector(n16);
                Claim.eq(math.add(x.Scalar,  y.Scalar), (x + y).Scalar);
                Claim.eq(math.add(x.Scalar,  (ushort)1), (++x).Scalar);

            }
        }

        public void bvadd_32()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n32);
                var y = Random.BitVector(n32);
                Claim.eq(math.add(x.Scalar,  y.Scalar), (x + y).Scalar);
                Claim.eq(math.add(x.Scalar,  1), (++x).Scalar);

            }
        }

        public void bvadd_64()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n64);
                var y = Random.BitVector(n64);
                Claim.eq(math.add(x.Scalar,  y.Scalar), (x + y).Scalar);
                Claim.eq(math.add(x.Scalar,  1), (++x).Scalar);

            }
        }


    }

}