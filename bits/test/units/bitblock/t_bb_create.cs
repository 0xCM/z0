//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bb_create : t_bitblock<t_bb_create>
    {
        public void bb_create_124x8()
            => bb_create_check<byte>(124);

        public void bb_create_128x8()
            => bb_create_check<byte>(128);

        public void bb_create_13x16()
            => bb_create_check<ushort>(13);

        public void bb_create_125x16()
            => bb_create_check<ushort>(125);

        public void bb_create_128x16()
            => bb_create_check<ushort>(128);

        public void bb_create_13x32()
            => bb_create_check<uint>(13);

        public void bb_create_64x32()
            => bb_create_check<uint>(64);

        public void bb_create_125x32()
            => bb_create_check<uint>(125);

        public void bb_create_128x32()
            => bb_create_check<uint>(128);

        public void bb_create_63x64()
            => bb_create_check<ulong>(63);

        public void bb_create_127x64()
            => bb_create_check<ulong>(127);

        public void bb_create_128x64()
            => bb_create_check<ulong>(128);

        public void bb_create_n63x64u()
            => bitspan_create_check<N63,ulong>();

        public void bb_create_n13x16u()
            => bitspan_create_check<N13,ushort>();

        public void bb_create_n32x32u()
            => bitspan_create_check<N32,uint>();

    }
}