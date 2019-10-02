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
            var r = Perm8Symbol.Reverse;
            var f = r.ToPerm();

            for(int i=0, j=7; i<8; i++, j--)
            {
                var x = (Perm8Symbol)f[i];
                var y = (Perm8Symbol)j;
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

        
    }
}