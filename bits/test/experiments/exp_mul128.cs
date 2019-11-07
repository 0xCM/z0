//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static dinx;

    public class exp_mul128 : BitVectorTest<exp_mul128>
    {

        public void mul_no_overflow()
        {
            var x = Random.Span<ulong>(SampleSize, 0u, uint.MaxValue);
            var y = Random.Span<ulong>(SampleSize, 0u, uint.MaxValue);                                
            Span<Pair<ulong>> z = new Pair<ulong>[SampleSize];
            math.mul(x,y,z);
            for(var i=0; i<SampleSize; i++)
                Claim.eq(x[i] * y[i], z[i].A);
        }


    }

}