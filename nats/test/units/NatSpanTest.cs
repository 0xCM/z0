//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static nfunc;
    using static zfunc;

    public class NatSpanTest : UnitTest<NatSpanTest>
    {
        public void Transpose()
        {
            
            var m = nati<N4>();
            var n = nati<N3>();
            var src = Random.NatSpan(n4, n5, Interval.closed(1,1000));
            Claim.eq(src.Dim.I, m);
            Claim.eq(src.Dim.J, n);            

            var dst = src.Transpose();

            Claim.eq(dst.Dim.I, n);
            Claim.eq(dst.Dim.J, m);

            for(var i=0; i< m; i++)
            for(var j=0; j < n; j++)
                Claim.eq(src[i,j], dst[j,i]);            
        }        
    }
}
