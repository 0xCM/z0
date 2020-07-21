//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static z;
    
    partial class vexamples
    {
        public void vcover()
        {            
            var x1 = vparts(4,8);
            var y1 = vparts(w128,4,4,4,4, 4,4,4,4, 8,8,8,8, 8,8,8,8);
            var z1 = dvec.vcover(x1, out Vector128<byte> _);
            Claim.veq(y1,z1);

            var x2 = vparts(w128, 4u,5,6,7);
            var y2 = vparts(w128, 4, 4, 4, 4,5,5,5,5, 6,6,6,6, 7,7,7,7);
            var z2 = dvec.vcover(x2, out Vector128<byte> _);
            Claim.veq(y2,z2);

            var x3 = vparts(w128,4,5,6,7);
            var y3 = vparts(w128,4,4, 5,5, 6,6, 7,7);
            var z3 = dvec.vcover(x3, out Vector128<ushort> _);
            Claim.veq(y3,z3);

            var x4 = vparts(4,5);
            var y4 = vparts(w128,4,4, 5,5);
            var z4 = dvec.vcover(x4, out Vector128<uint> _);
            Claim.veq(y4,z4);

            var x5 =vparts(w256, 0ul,1,2,3);
            var y5 = vparts(w256, 
                 0, 0, 0, 0, 0, 0, 0, 0,
                 1, 1, 1, 1, 1, 1, 1, 1, 
                 2, 2, 2, 2, 2, 2, 2, 2, 
                 3, 3, 3, 3, 3, 3, 3, 3);
            dvec.vcover(x5, out Vector256<byte> z5);
            Claim.veq(y5,z5);

            var x6 =vparts(1,2,3,4,5,6,7,8);
            var y6 = vparts(w256,
                 1, 1, 1, 1, 2, 2, 2, 2, 
                 3, 3, 3, 3, 4, 4, 4, 4, 
                 5, 5, 5, 5, 6, 6, 6, 6, 
                 7, 7, 7, 7, 8, 8, 8, 8);
            dvec.vcover(x6, out Vector256<byte> z6);
            Claim.veq(y6,z6);
        }
    }
}