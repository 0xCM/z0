//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;
        
    public class t_sb_bitwidth : t_sb<t_sb_bitwidth>
    {

        public void sb_width_base_case()
        {
            var x = (byte)0b0;
            var w = gbits.effwidth(x);
            Claim.eq(w,0);
            
            x = (byte)0b00010000;
            w = gbits.effwidth(x);
            Claim.eq(w,5);

            x = (byte)0b00000001;
            w = gbits.effwidth(x);
            Claim.eq(w,1);

            x = (byte)0b10000000;
            w = gbits.effwidth(x);
            Claim.eq(w,8);
        }
    }

}