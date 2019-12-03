//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_blsr : t_sb<t_sb_blsr>
    {
        public void blsr_8()
            => sb_blsr_check<byte>();

        public void sb_blsr_16()
            => sb_blsr_check<ushort>();

        public void sb_blsr_32()
            => sb_blsr_check<uint>();

        public void sb_blsr_64()
            => sb_blsr_check<ulong>();
    }
}
