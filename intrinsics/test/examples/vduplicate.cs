//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static Gone;
    using static HexConst;

    partial class vexamples
    {     
        public void vduplicate_example()
        {
            var n = n256;
            var width = n32;

            var x0 = vgeneric.vparts(n, 0,1,2,3,4,5,6,(uint)7);
            var y0 = dvec.vduplicate(n0,width,x0);
            var z0 = dvec.vduplicate(n1,width,x0);
            Claim.veq(y0, vgeneric.vparts(n, 0,0,2,2,4,4,6,(uint)6));
            Claim.veq(z0, vgeneric.vparts(n, 1,1,3,3,5,5,7,(uint)7));            

            var x1 = vgeneric.vparts(n,0,1,2,3,4,5,6,7,8,9,A,B,C,D,E,F);
            var y1 = dvec.vduplicate(n0,width,x1);
            var z1 = dvec.vduplicate(n1,width,x1);
            Claim.veq(y1, vgeneric.vparts(n,0,1, 0,1, 4,5, 4,5, 8,9, 8,9, C,D, C,D));
            Claim.veq(z1, vgeneric.vparts(n,2,3, 2,3, 6,7, 6,7, A,B, A,B, E,F, E,F));
            
            var x2 = vgeneric.vparts(n,
                ulong.MaxValue & 0x55555555AAAAAAAA, 
                ulong.MaxValue & 0xCCCCCCCC88888888, 
                ulong.MaxValue & 0x3333333377777777,
                ulong.MaxValue & 0x2222222244444444);
            var y2 = dvec.vduplicate(n0, n64, x2);
            var z2 = dvec.vduplicate(n1,n64, x2);
        }    
    }
}