//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static nfunc;

    public class t_shuffle : IntrinsicTest<t_shuffle>
    {
        const byte A = 0b00;
        
        const byte B = 0b01;

        const byte C = 0b10;

        const byte D = 0b11;

        public void perm4_digits_check()
        {
            var dABCD = Perm4.ABCD.Digits();
            Claim.eq(NatSpan.Define(n4, A, B, C, D), dABCD);

            var dDCBA = Perm4.DCBA.Digits();
            Claim.eq(NatSpan.Define(n4, D, C, B, A), dDCBA);

            var dACBD = Perm4.ACBD.Digits();
            Claim.eq(NatSpan.Define(n4, A, C, B, D), dACBD);

            var dCBDA = Perm4.CBDA.Digits();
            Claim.eq(NatSpan.Define(n4, C, B, D, A), dCBDA);

        }

        public void shuffle_hi_128x16u_check()
        {
            var x = Vec128Pattern.Increments<ushort>();
            Claim.eq(v128(x[A], x[B], x[C], x[D], x[A+4], x[B+ 4], x[C + 4], x[D + 4]), x);

            var xABCD = dinx.vshufflehi(x, Perm4.ABCD);
            Claim.eq(xABCD, v128(x[A], x[B], x[C], x[D], x[A + 4], x[B + 4], x[C + 4], x[D + 4]));

            var xDCBA = dinx.vshufflehi(x, Perm4.DCBA);
            Claim.eq(xDCBA, v128(x[A], x[B], x[C], x[D], x[D + 4], x[C + 4], x[B + 4], x[A + 4]));

            var xACBD = dinx.vshufflehi(x, Perm4.ACBD);
            Claim.eq(xACBD, v128(x[A], x[B], x[C], x[D], x[A + 4], x[C + 4], x[B + 4], x[D + 4]));            
        }

        public void shuffle_lo_128x16u_check()
        {
            var x = Vec128Pattern.Increments<ushort>();
            Claim.eq(v128(x[A], x[B], x[C], x[D], x[A + 4], x[B + 4], x[C + 4], x[D + 4]), x);

            var xABCD = dinx.vshufflelo(x, Perm4.ABCD);
            Claim.eq(xABCD, v128(x[A], x[B], x[C], x[D], x[A + 4], x[B + 4], x[C + 4], x[D + 4]));

            var xDCBA = dinx.vshufflelo(x, Perm4.DCBA);
            Claim.eq(xDCBA, v128(x[D], x[C], x[B], x[A], x[A + 4], x[B + 4], x[C + 4], x[D + 4]));

            var xACBD = dinx.vshufflelo(x, Perm4.ACBD);
            Claim.eq(xACBD, v128(x[A], x[C], x[B], x[D], x[A + 4], x[B + 4], x[C + 4], x[D + 4]));
            
        }

        public void shuffle_128x8u_check()
        {
            var src = Vec128Pattern.Increments<byte>();
            var perm = Perm16Spec.Reverse.ToPerm();
            for(int i=0,j=15; i<perm.Length; i++, j--)
                Claim.eq(perm[i],j);

            var shufspec = perm.ToShuffleSpec();
            var dst = dinx.vshuffle(src,shufspec);
            var expect = Vec128Pattern.Decrements<byte>(15);
            Claim.eq(expect, dst);

            var dstPerm = dst.ToPerm();
            var expectPerm = expect.ToPerm();
            Claim.eq(dstPerm, expectPerm);

        }


    }
}