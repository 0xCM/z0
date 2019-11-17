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


    public class t_bv_part : BitVectorTest<t_bv_part>
    {
        public void bvpart_32x16()
        {
            Span<BitVector16> dst = stackalloc BitVector16[2];
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n32);
                BitVector.partition(x, dst);
                Claim.eq(dst[0], x.Lo);
                Claim.eq(dst[1], x.Hi);
            }
        }

        public void bvpart_32x4()
        {
            Span<BitVector4> dst = stackalloc BitVector4[8];
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.BitVector(n32);
                BitVector.partition(x,dst);
                for(int j=0,k=0; j<28; j+=4, k++)
                {
                    var y = (BitVector4)x[j,j+4];
                    Claim.eq(y, dst[k]);

                }
            }         
        }

    }
}
