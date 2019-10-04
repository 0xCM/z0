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
    
    public class t_bmor : BitMatrixTest<t_bmor>
    {

        public void t_bmor_32x32x32_check()
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