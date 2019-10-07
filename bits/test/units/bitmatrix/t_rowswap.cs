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
    
    public class t_bmrowswap : BitMatrixTest<t_bmrowswap>
    {
        
        
        public void bmrowswap_64u_check()
        {
            var A = Random.BitMatrix64();
            var a = A.Data.Replicate();

            Claim.eq(a.Length, 64);
            for(var sample=0; sample< SampleSize; sample++)
            {
                (var i, var j) = Random.NextPair(0,64);
                A.RowSwap(i,j);

                var tmp = a[i];
                a[i] = a[j];
                a[j] = tmp;
            }

            var B = BitMatrix64.From(a);
            Claim.yea(A == B);
            
        
        }
    }

}
