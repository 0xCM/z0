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
    using static Reg;
    //using static Asm;

    public class t_vpermd : UnitTest<t_vpermd>
    {

        public void represent()
        {
            var r = Perm8.Reverse;
            var f = r.ToPerm();

            for(int i=0, j=7; i<8; i++, j--)
            {
                var x = (Perm8)f[i];
                var y = (Perm8)j;
                Claim.eq(x,y);

            }
            
        }

        public void perm256u8()
        {

            var x = Vec256Pattern.Increasing<byte>();
            var y = Vec256Pattern.Decreasing<byte>();
            var z = dinx.permute(x,y);
            for(var i=0; i<31; i++)
                Claim.eq(x[31 - i], z[i]);
        
        }

        public void perm4_reverse_check()
        {
            const Perm4  p = Perm4.DCBA;            
            const string pbs_expect = "00011011";
            const string pformat_epect = "[00 01 10 11]: ABCD -> DCBA";

            var pbs_actual = BitString.FromScalar((byte)p);            
            Claim.eq(pbs_expect, pbs_actual);
            
            var p_assembled = Perm.Assemble(Perm4.D, Perm4.C, Perm4.B, Perm4.A);            
            Claim.eq(p, p_assembled);            
            
            var pformat_actual = p.FormatMap();
            Claim.eq(pformat_epect, pformat_actual);

            var vIn = Vec128.FromParts(0,1,2,3);
            var vExpect = Vec128.FromParts(3,2,1,0);
            var vActual = dinx.perm4x32(vIn,p);
            Claim.eq(vExpect, vActual);

                                
        }
        
    }
}