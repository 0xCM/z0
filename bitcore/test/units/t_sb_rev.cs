//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_bitrev : t_sb<t_sb_bitrev>
    {
        public void sb_bitrev_8()
            => sb_bitrev_check<byte>();

        public void sb_bitrev_16()
            => sb_bitrev_check<ushort>();
        
        public void sb_bitrev_32()
            => sb_bitrev_check<uint>();

        public void sb_bitrev_64()
            => sb_bitrev_check<ulong>();
        
    }
}