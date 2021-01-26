//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static HexConst;
    using static z;

    partial class VexExamples
    {
        [Op(ExampleGroups.Duplicate)]
        public void vduplicate()
        {
            var n = n256;
            var width = n32;

            var x0 = cpu.vparts(n, 0,1,2,3,4,5,6,(uint)7);
            var y0 = z.vduplicate(n0,width,x0);
            var z0 = z.vduplicate(n1,width,x0);
            Claim.veq(y0, cpu.vparts(n, 0,0,2,2,4,4,6,(uint)6));
            Claim.veq(z0, cpu.vparts(n, 1,1,3,3,5,5,7,(uint)7));

            var x1 = cpu.vparts(n,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var y1 = z.vduplicate(n0,width,x1);
            var z1 = z.vduplicate(n1,width,x1);
            Claim.veq(y1, cpu.vparts(n,0,1, 0,1, 4,5, 4,5, 8,9, 8,9, C,D, C,D));
            Claim.veq(z1, cpu.vparts(n,2,3, 2,3, 6,7, 6,7, A,B, A,B, E,F, E,F));

            var x2 = cpu.vparts(n,
                ulong.MaxValue & 0x55555555AAAAAAAA,
                ulong.MaxValue & 0xCCCCCCCC88888888,
                ulong.MaxValue & 0x3333333377777777,
                ulong.MaxValue & 0x2222222244444444);
            var y2 = z.vduplicate(n0, n64, x2);
            var z2 = z.vduplicate(n1,n64, x2);
        }
    }
}