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
    
    using static zfunc;

    public class t_vperm : UnitTest<t_vperm>
    {
        public void perm_2x128_check()
        {
            var x = Vec256Pattern.Increasing<ulong>(0,2);
            var y = Vec256Pattern.Increasing<ulong>(1,2);

            Claim.eq(cpuvec(1ul,3,0,2), dinx.vperm2x128(x,y,Perm2x128.AC));
            Claim.eq(cpuvec(5ul,7,0,2), dinx.vperm2x128(x,y,Perm2x128.AD));
            Claim.eq(cpuvec(1ul,3,4,6), dinx.vperm2x128(x,y,Perm2x128.BC));
            Claim.eq(cpuvec(5ul,7,4,6), dinx.vperm2x128(x,y,Perm2x128.BD));
            Claim.eq(cpuvec(0ul,2,1,3), dinx.vperm2x128(x,y,Perm2x128.CA));
            Claim.eq(cpuvec(4ul,6,1,3), dinx.vperm2x128(x,y,Perm2x128.CB));
            Claim.eq(cpuvec(0ul,2,5,7), dinx.vperm2x128(x,y,Perm2x128.DA));
            Claim.eq(cpuvec(4ul,6,5,7), dinx.vperm2x128(x,y,Perm2x128.DB));
        }

        public void swaphl_2x128()
        {
            for(var i=0; i < SampleSize; i++)
            {
                var x = Random.CpuVector<byte>(n256);
                var y = dinx.vswaphl_ref(x);
                var z = dinx.vswaphl(x);
                Claim.eq(y,z);
            }
        }


        public void perm256u8()
        {

            var x = Vec256Pattern.Increasing<byte>();
            var y = Vec256Pattern.Decreasing<byte>();
            var z = dinx.reverse(dinx.vpermvar32x8(x,y));
            Claim.eq(x,z);

        }

        public void perm4_reverse_check()
        {
            const Perm4  p = Perm4.DCBA;            
            const string pbs_expect = "00011011";
            const string pformat_epect = "[00 01 10 11]: ABCD -> DCBA";

            var pbs_actual = BitString.FromScalar((byte)p);            
            Claim.eq(pbs_expect, pbs_actual);
            
            var p_assembled = Perm4Spec.Assemble(Perm4.D, Perm4.C, Perm4.B, Perm4.A);            
            Claim.eq(p, p_assembled);            
            
            var pformat_actual = p.FormatMap();
            Claim.eq(pformat_epect, pformat_actual);

            var vIn = cpuvec(0,1,2,3);
            var vExpect = cpuvec(3,2,1,0);
            var vActual = dinx.vshuffle(vIn,p);
            Claim.eq(vExpect, vActual);                                
        }        
    }
}