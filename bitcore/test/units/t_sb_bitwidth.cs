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
            var w = gbits.width(x);
            Claim.eq(w,0);
            
            x = (byte)0b00010000;
            w = gbits.width(x);
            Claim.eq(w,5);

            x = (byte)0b00000001;
            w = gbits.width(x);
            Claim.eq(w,1);

            x = (byte)0b10000000;
            w = gbits.width(x);
            Claim.eq(w,8);    

        }

        public void sb_width_8u()
            => sb_width_check<byte>();

        public void sb_width_16u()
            => sb_width_check<ushort>();

        public void sb_width_32u()
            => sb_width_check<uint>();

        public void sb_width_64u()
            => sb_width_check<ulong>();
    }
}