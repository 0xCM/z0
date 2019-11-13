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
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vperm : UnitTest<t_vperm>
    {
        public void perm_2x128_check()
        {
            var n = n256;
            var x = dinx.vparts(n, 0, 1, 2, 3);
            var y = dinx.vparts(n, 4, 5, 6, 7);

            Claim.eq(dinx.vparts(n, 0, 1, 4, 5), ginx.vperm2x128(x,y, Perm2x4.AC));
            Claim.eq(dinx.vparts(n, 4, 5, 0, 1), ginx.vperm2x128(x,y, Perm2x4.CA));

            Claim.eq(dinx.vparts(n, 0, 1, 6, 7), ginx.vperm2x128(x,y, Perm2x4.AD));
            Claim.eq(dinx.vparts(n, 6, 7, 0, 1), ginx.vperm2x128(x,y, Perm2x4.DA));

            Claim.eq(dinx.vparts(n, 2, 3, 4, 5), ginx.vperm2x128(x,y, Perm2x4.BC));
            Claim.eq(dinx.vparts(n, 4, 5, 2, 3), ginx.vperm2x128(x,y, Perm2x4.CB));

            Claim.eq(dinx.vparts(n, 2, 3, 6, 7), ginx.vperm2x128(x,y, Perm2x4.BD));
            Claim.eq(dinx.vparts(n, 6, 7, 2, 3), ginx.vperm2x128(x,y, Perm2x4.DB));
        }

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vswaphl(Vector256<byte> x)
        {
            Vector256<byte> y = default;
            y = dinx.vinsert(dinx.vhi(x), y, 0);
            y = dinx.vinsert(dinx.vlo(x), y, 1);
            return y;
        }

        public void swaphl_2x128()
        {
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = vswaphl(x);
                var z = dinx.vswaphl(x);
                Claim.eq(y,z);
            }
        }


        public void perm256u8()
        {

            var x = ginx.vincrements<byte>(n256);
            var y = ginx.vdecrements<byte>(n256,31);
            var z = dinx.vreverse(dinx.vshuf32x8(x,y));
            Claim.eq(x,z);

        }

        public void perm4_reverse_check()
        {
            const Perm4  p = Perm4.DCBA;            
            const string pbs_expect = "00011011";
            const string pformat_epect = "[00 01 10 11]: ABCD -> DCBA";

            var pbs_actual = BitString.FromScalar((byte)p);            
            Claim.eq(pbs_expect, pbs_actual);
            
            var p_assembled = Perm4Spec.assemble(Perm4.D, Perm4.C, Perm4.B, Perm4.A);            
            Claim.eq(p, p_assembled);            
            
            var pformat_actual = p.FormatMap();
            Claim.eq(pformat_epect, pformat_actual);

            var vIn = dinx.vparts(0,1,2,3);
            var vExpect = dinx.vparts(3,2,1,0);
            var vActual = dinx.vperm4x32(vIn,p);
            Claim.eq(vExpect, vActual);                                
        }        
    }
}