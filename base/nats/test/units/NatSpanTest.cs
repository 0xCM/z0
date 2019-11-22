//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.ComponentModel;

    using static nfunc;
    using static zfunc;

    public class NatSpanTest : UnitTest<NatSpanTest>
    {
        
        public void Transpose()
        {
            
            var m = nati<N4>();
            var n = nati<N3>();
            var src = Random.Grid(n4, n5, closed(1,1000));
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
