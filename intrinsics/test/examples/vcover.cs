//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    partial class vexamples
    {
        public void vcover_basecase()
        {            
            var x1 = CpuVector.vparts(n128,4,8);
            var y1 = CpuVector.vparts(n128,4,4,4,4, 4,4,4,4, 8,8,8,8, 8,8,8,8);
            var z1 = dinx.vcover(x1, out Vector128<byte> _);
            Claim.eq(y1,z1);

            var x2 = CpuVector.vparts(n128,4,5,6,7);
            var y2 = CpuVector.vparts(n128,4,4,4,4, 5,5,5,5, 6,6,6,6, 7,7,7,7);
            var z2 = dinx.vcover(x2, out Vector128<byte> _);
            Claim.eq(y2,z2);

            var x3 = CpuVector.vparts(n128,4,5,6,7);
            var y3 = CpuVector.vparts(n128,4,4, 5,5, 6,6, 7,7);
            var z3 = dinx.vcover(x3, out Vector128<ushort> _);
            Claim.eq(y3,z3);

            var x4 = CpuVector.vparts(n128,4,5);
            var y4 = CpuVector.vparts(n128,4,4, 5,5);
            var z4 = dinx.vcover(x4, out Vector128<uint> _);
            Claim.eq(y4,z4);

            var x5 =CpuVector.vparts(n256,0,1,2,3);
            var y5 = CpuVector.vparts(n256,
                 0, 0, 0, 0, 0, 0, 0, 0,
                 1, 1, 1, 1, 1, 1, 1, 1, 
                 2, 2, 2, 2, 2, 2, 2, 2, 
                 3, 3, 3, 3, 3, 3, 3, 3);
            dinx.vcover(x5, out Vector256<byte> z5);
            Claim.eq(y5,z5);

            var x6 =CpuVector.vparts(n256,1,2,3,4,5,6,7,8);
            var y6 = CpuVector.vparts(n256,
                 1, 1, 1, 1, 2, 2, 2, 2, 
                 3, 3, 3, 3, 4, 4, 4, 4, 
                 5, 5, 5, 5, 6, 6, 6, 6, 
                 7, 7, 7, 7, 8, 8, 8, 8);
            dinx.vcover(x6, out Vector256<byte> z6);
            Claim.eq(y6,z6);

        }
    }
}