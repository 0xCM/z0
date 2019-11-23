//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bm_or : BitMatrixTest<t_bm_or>
    {                

        public void pbm_or_32()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix(n32);
                var B = Random.BitMatrix(n32);
                var C = A | B;

                var D = BitMatrix32.From(mathspan.or(A.Bytes, B.Bytes));
                Claim.yea(C == D);
            }
        }
    }

}