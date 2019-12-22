//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_sb_msbpos : t_sb<t_sb_msbpos>
    {
        public void sb_msbpos_8()
            => sb_msbpos_check<byte>();

        public void sb_msbpos_16()
            => sb_msbpos_check<ushort>();

        public void sb_msbpos_32()
            => sb_msbpos_check<uint>();

        public void sb_msbpos_64()
            => sb_msbpos_check<ulong>();
    }

}