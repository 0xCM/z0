//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vpermhi : t_vinx<t_vpermhi>
    {
        const byte A = 0b00;
        
        const byte B = 0b01;

        const byte C = 0b10;

        const byte D = 0b11;

        public void perm4_digits_basecase()
        {
            var dABCD = Perm4.ABCD.Digits();
            Claim.eq(DataBlocks.natparts(n4, A, B, C, D), dABCD);

            var dDCBA = Perm4.DCBA.Digits();
            Claim.eq(DataBlocks.natparts(n4, D, C, B, A), dDCBA);

            var dACBD = Perm4.ACBD.Digits();
            Claim.eq(DataBlocks.natparts(n4, A, C, B, D), dACBD);

            var dCBDA = Perm4.CBDA.Digits();
            Claim.eq(DataBlocks.natparts(n4, C, B, D, A), dCBDA);
        }

        public void vpermhi_4x16_basecase()
        {
            var x = ginx.vincrements<ushort>(n128);
            var xs = x.ToSpan();
            Claim.eq(Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A+4], xs[B+ 4], xs[C + 4], xs[D + 4]), x);

            var xABCD = dinx.vpermhi4x16(x, Perm4.ABCD);
            Claim.eq(xABCD, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            var xDCBA = dinx.vpermhi4x16(x, Perm4.DCBA);
            Claim.eq(xDCBA, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[D + 4], xs[C + 4], xs[B + 4], xs[A + 4]));

            var xACBD = dinx.vpermhi4x16(x, Perm4.ACBD);
            Claim.eq(xACBD, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[C + 4], xs[B + 4], xs[D + 4]));            

            Claim.eq(dinx.vpermhi4x16(dinx.vparts(n128, 0,1,2,3,6,7,8,9), Perm4.ADCB), dinx.vparts(n128,0,1,2,3,6,9,8,7));

        }


    }
}