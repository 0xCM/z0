//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class tv_mul : t_vinx<tv_mul>
    {
        public void mul256_u64()
        {
            var n = n256;
            for(var sample=0; sample < SampleSize; sample++)
            {
                var x = Random.CpuVector<ulong>(n, 0, uint.MaxValue);
                var y = Random.CpuVector<ulong>(n, 0, uint.MaxValue);

            }
        }

        public void umul64_check()
        {
            for(var i=0; i< SampleSize; i++)
            {
                var xi = Random.Next<uint>();
                var yi = Random.Next<uint>();
                var z = (ulong)xi * (ulong)yi;
                Claim.eq(z, Math128.mul(xi,yi));
            }
        }
    }
}