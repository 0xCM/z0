//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static z;

    partial class VexExamples
    {
        [Op(ExampleGroups.Cover)]
        public void covers()
        {
            var x1 = cpu.vparts(4,8);
            var y1 = cpu.vparts(w128,4,4,4,4, 4,4,4,4, 8,8,8,8, 8,8,8,8);
            var z1 = vcover(x1, out Vector128<byte> _);
            Claim.veq(y1,z1);

            var x2 = cpu.vparts(w128, 4u,5,6,7);
            var y2 = cpu.vparts(w128, 4, 4, 4, 4,5,5,5,5, 6,6,6,6, 7,7,7,7);
            var z2 = vcover(x2, out Vector128<byte> _);
            Claim.veq(y2, z2);

            var x3 = cpu.vparts(w128,4,5,6,7);
            var y3 = cpu.vparts(w128,4,4, 5,5, 6,6, 7,7);
            var z3 = vcover(x3, out Vector128<ushort> _);
            Claim.veq(y3, z3);

            var x4 = cpu.vparts(4,5);
            var y4 = cpu.vparts(w128,4,4, 5,5);
            var z4 = vcover(x4, out Vector128<uint> _);
            Claim.veq(y4,z4);

            var x5 =cpu.vparts(w256, 0ul,1,2,3);
            var y5 = cpu.vparts(w256,
                 0, 0, 0, 0, 0, 0, 0, 0,
                 1, 1, 1, 1, 1, 1, 1, 1,
                 2, 2, 2, 2, 2, 2, 2, 2,
                 3, 3, 3, 3, 3, 3, 3, 3);
            vcover(x5, out Vector256<byte> z5);
            Claim.veq(y5, z5);

            var x6 = cpu.vparts(1,2,3,4,5,6,7,8);
            var y6 = cpu.vparts(w256,
                 1, 1, 1, 1, 2, 2, 2, 2,
                 3, 3, 3, 3, 4, 4, 4, 4,
                 5, 5, 5, 5, 6, 6, 6, 6,
                 7, 7, 7, 7, 8, 8, 8, 8);
            vcover(x6, out Vector256<byte> z6);
            Claim.veq(y6, z6);
        }
    }
}