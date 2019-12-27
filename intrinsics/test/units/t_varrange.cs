//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static HexConst;

    public class t_varrange : t_vinx<t_varrange>
    {     

        public void vduplicate32x0_256x32u_outline()
        {
            var n = n256;
            var width = n32;

            var x0 = CpuVector.vparts(n, 0,1,2,3,4,5,6,(uint)7);
            var y0 = dinx.vduplicate(n0,width,x0);
            var z0 = dinx.vduplicate(n1,width,x0);
            Claim.eq(y0, CpuVector.vparts(n, 0,0,2,2,4,4,6,(uint)6));
            Claim.eq(z0, CpuVector.vparts(n, 1,1,3,3,5,5,7,(uint)7));            

            var x1 = CpuVector.vparts(n,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var y1 = dinx.vduplicate(n0,width,x1);
            var z1 = dinx.vduplicate(n1,width,x1);
            Claim.eq(y1, CpuVector.vparts(n,0,1, 0,1, 4,5, 4,5, 8,9, 8,9, C,D, C,D));
            Claim.eq(z1, CpuVector.vparts(n,2,3, 2,3, 6,7, 6,7, A,B, A,B, E,F, E,F));
            
            var x2 = CpuVector.vparts(n,
                ulong.MaxValue & 0x55555555AAAAAAAA, 
                ulong.MaxValue & 0xCCCCCCCC88888888, 
                ulong.MaxValue & 0x3333333377777777,
                ulong.MaxValue & 0x2222222244444444);
            var y2 = dinx.vduplicate(n0, n64, x2);
            var z2 = dinx.vduplicate(n1,n64, x2);
        }
        

    }
}