//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_sb_rot : t_sb<t_sb_rot>
    {
        public void gsb_rotl_8()
            => sb_rotl_check<byte>();

        public void gsb_rotl_16()
            => sb_rotl_check<ushort>();

        public void gsb_rotl_32()
            => sb_rotl_check<uint>();

        public void gsb_rotl_64()
            => sb_rotl_check<ulong>();
    }
}