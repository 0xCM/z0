//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public class t_bb_create : t_bitspans<t_bb_create>
    {
        public void bb_create_124x8()
            => check_bitblock_create<byte>(124);

        public void bb_create_128x8()
            => check_bitblock_create<byte>(128);

        public void bb_create_13x16()
            => check_bitblock_create<ushort>(13);

        public void bb_create_125x16()
            => check_bitblock_create<ushort>(125);

        public void bb_create_128x16()
            => check_bitblock_create<ushort>(128);

        public void bb_create_13x32()
            => check_bitblock_create<uint>(13);

        public void bb_create_64x32()
            => check_bitblock_create<uint>(64);

        public void bb_create_125x32()
            => check_bitblock_create<uint>(125);

        public void bb_create_128x32()
            => check_bitblock_create<uint>(128);

        public void bb_create_63x64()
            => check_bitblock_create<ulong>(63);

        public void bb_create_127x64()
            => check_bitblock_create<ulong>(127);

        public void bb_create_128x64()
            => check_bitblock_create<ulong>(128);

        public void bb_create_n63x64u()
            => check_bitblock_range<N63,ulong>();

        public void bb_create_n13x16u()
            => check_bitblock_range<N13,ushort>();

        public void bb_create_n32x32u()
            => check_bitblock_range<N32,uint>();

    }
}