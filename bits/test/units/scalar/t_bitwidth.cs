//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;

    using static zfunc;
        
    public class t_bitwidth : t_sb<t_bitwidth>
    {

        public void effwidth_8u()
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

        public void effwidth_32u()
        {
            var x = 0xFFu + 1u;
            var w = gbits.effwidth(x);
            Claim.eq(w,9);

            x = UInt32.MaxValue;
            w = gbits.effwidth(x);
            Claim.eq(w,32);
        }
    }

}