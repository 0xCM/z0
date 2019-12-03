//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_lsbpos : t_sb<t_sb_lsbpos>
    {
        
        public void sb_lsbpos_basecase()
        {
            Claim.eq(3, gbits.lsbpos((byte)0b111000));
            Claim.eq(2, gbits.lsbpos(0b0001011000100u));
            Claim.eq(5, gbits.lsbpos(0b000101100000u));
        }

        public void sb_lsbpos_8()
            => sb_lsbpos_check<byte>();

        public void sb_lsbpos_16()
            => sb_lsbpos_check<ushort>();

        public void sb_lsbpos_32()
            => sb_lsbpos_check<uint>();

        public void sb_lsbpos_64()
            => sb_lsbpos_check<ulong>();
    }

}