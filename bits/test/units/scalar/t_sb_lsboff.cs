//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;

    public class t_sb_lsboff : t_sb<t_sb_lsboff>
    {
        public void sb_lsboff_8()
            => sb_lsboff_check<byte>();

        public void sb_lsboff_16()
            => sb_lsboff_check<ushort>();

        public void sb_lsboff_32()
            => sb_lsboff_check<uint>();

        public void sb_lsboff_64()
            => sb_lsboff_check<ulong>();
    }
}
