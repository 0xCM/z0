//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static Nats;

    partial class vexamples
    {
        public void vcover_basecase()
        {            
            var x1 = vgeneric.vparts(n128,4,8);
            var y1 = vgeneric.vparts(n128,4,4,4,4, 4,4,4,4, 8,8,8,8, 8,8,8,8);
            var z1 = dvec.vcover(x1, out Vector128<byte> _);
            Claim.veq(y1,z1);

            var x2 = vgeneric.vparts(n128,4,5,6,7);
            var y2 = vgeneric.vparts(n128,4,4,4,4, 5,5,5,5, 6,6,6,6, 7,7,7,7);
            var z2 = dvec.vcover(x2, out Vector128<byte> _);
            Claim.veq(y2,z2);

            var x3 = vgeneric.vparts(n128,4,5,6,7);
            var y3 = vgeneric.vparts(n128,4,4, 5,5, 6,6, 7,7);
            var z3 = dvec.vcover(x3, out Vector128<ushort> _);
            Claim.veq(y3,z3);

            var x4 = vgeneric.vparts(n128,4,5);
            var y4 = vgeneric.vparts(n128,4,4, 5,5);
            var z4 = dvec.vcover(x4, out Vector128<uint> _);
            Claim.veq(y4,z4);

            var x5 =vgeneric.vparts(n256,0,1,2,3);
            var y5 = vgeneric.vparts(n256,
                 0, 0, 0, 0, 0, 0, 0, 0,
                 1, 1, 1, 1, 1, 1, 1, 1, 
                 2, 2, 2, 2, 2, 2, 2, 2, 
                 3, 3, 3, 3, 3, 3, 3, 3);
            dvec.vcover(x5, out Vector256<byte> z5);
            Claim.veq(y5,z5);

            var x6 =vgeneric.vparts(n256,1,2,3,4,5,6,7,8);
            var y6 = vgeneric.vparts(n256,
                 1, 1, 1, 1, 2, 2, 2, 2, 
                 3, 3, 3, 3, 4, 4, 4, 4, 
                 5, 5, 5, 5, 6, 6, 6, 6, 
                 7, 7, 7, 7, 8, 8, 8, 8);
            dvec.vcover(x6, out Vector256<byte> z6);
            Claim.veq(y6,z6);

        }
    }
}