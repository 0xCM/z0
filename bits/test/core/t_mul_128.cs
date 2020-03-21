//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Nats;

    public class t_mul128 : t_bitcore<t_mul128>
    {
        public void mul_no_overflow()
        {
            var x = Random.Span<ulong>(RepCount, z32, uint.MaxValue);
            var y = Random.Span<ulong>(RepCount, z32, uint.MaxValue);                                
            Span<Pair<ulong>> z = new Pair<ulong>[RepCount];
            math.mul64x128(x,y,z);
            for(var i=0; i<RepCount; i++)
                Claim.eq(x[i] * y[i], z[i].Left);
        }
    }
}