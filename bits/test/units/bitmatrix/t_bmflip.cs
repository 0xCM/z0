//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;
    
    public class t_bmflip : BitMatrixTest<t_bmflip>
    {

        public void t_bmflip_32x32x32_check()
        {
            for(var i=0; i<SampleSize; i++)
            {
                var A = Random.BitMatrix(n32);
                var B = BitMatrix.flip(A);
                var C = BitMatrix32.From(mathspan.flip(A.Bytes.Replicate()));
                Claim.yea(B == C);
                
            }
        }

    }

}