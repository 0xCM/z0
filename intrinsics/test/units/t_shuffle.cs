//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;
    
    using static zfunc;
    using static nfunc;

    public class t_vshuffle : IntrinsicTest<t_vshuffle>
    {
        const byte A = 0b00;
        
        const byte B = 0b01;

        const byte C = 0b10;

        const byte D = 0b11;

        public void perm4_digits_check()
        {
            var dABCD = Perm4.ABCD.Digits();
            Claim.eq(NatBlock.parts(n4, A, B, C, D), dABCD);

            var dDCBA = Perm4.DCBA.Digits();
            Claim.eq(NatBlock.parts(n4, D, C, B, A), dDCBA);

            var dACBD = Perm4.ACBD.Digits();
            Claim.eq(NatBlock.parts(n4, A, C, B, D), dACBD);

            var dCBDA = Perm4.CBDA.Digits();
            Claim.eq(NatBlock.parts(n4, C, B, D, A), dCBDA);

        }

        public void shuffle_hi_128x16u_check()
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
        }

        public void shuffle_lo_128x16u_check()
        {
            var x = ginx.vincrements<ushort>(n128);
            var xs = x.ToSpan();
            Claim.eq(Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]), x);

            var xABCD = dinx.vpermlo4x16(x, Perm4.ABCD);
            Claim.eq(xABCD, Vector128.Create(xs[A], xs[B], xs[C], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            var xDCBA = dinx.vpermlo4x16(x, Perm4.DCBA);
            Claim.eq(xDCBA, Vector128.Create(xs[D], xs[C], xs[B], xs[A], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));

            var xACBD = dinx.vpermlo4x16(x, Perm4.ACBD);
            Claim.eq(xACBD, Vector128.Create(xs[A], xs[C], xs[B], xs[D], xs[A + 4], xs[B + 4], xs[C + 4], xs[D + 4]));
            
        }
    }
}