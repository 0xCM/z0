//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_ntz : t_bitcore<t_sb_ntz>
    {        
        public void sb_ntz_basecase()
        {
            Claim.eq(3, gbits.ntz((byte)0b111000));
            Claim.eq(2, gbits.ntz(0b0001011000100u));
            Claim.eq(5, gbits.ntz(0b000101100000u));
            Claim.eq(3, gbits.lsbpos(Pow2.pow(3)));            
        }

        public void sb_ntz_8()
            => sb_ntz_check<byte>();

        public void sb_ntz_16()
            => sb_ntz_check<ushort>();

        public void sb_ntz_32()
            => sb_ntz_check<uint>();

        public void sb_ntz_64()
            => sb_ntz_check<ulong>();
    }

}