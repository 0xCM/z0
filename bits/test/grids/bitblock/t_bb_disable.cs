//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Nats;

    public class t_bb_disable : t_bitblock<t_bb_disable>
    {
        public void bb_disable_16x16()
            => bitblock_disable_check<N16,ushort>();

        public void bb_disable_32x32()
            => bitblock_disable_check<uint>(32);

        public void bb_disable_n32x32()
            => bitblock_disable_check<N32,uint>();

        public void bb_disable_64x64()
            => bitblock_disable_check<ulong>(64);

        public void bb_disable_n64x64()
            => bitblock_disable_check<N64,ulong>();

        public void bb_disable_213x8()
            => bitblock_disable_check<byte>(213);

        public void bb_disable_213x16()
            => bitblock_disable_check<ushort>(213);

        public void bb_disable_213x32()
            => bitblock_disable_check<uint>(213);

        public void bb_disable_213x64()
            => bitblock_disable_check<ulong>(213);
        
        public void bb_disable_n213x8()
            => bitblock_disable_check(n213, z8);

        public void bb_disable_n213x16()
            => bitblock_disable_check(n213, z16);

        public void bb_disable_n213x32()
            => bitblock_disable_check(n213, z32);

        public void nbc_disable_213x64()
            => bitblock_disable_check(n213, z64);

        void bb_disable_n707x64u()
        {
            var n707 = TypeNats.seq(n7,n0,n7);
            Claim.eq(707,(int)n707.NatValue);
            bitblock_disable_check(n707, (ulong)0);
        }
    }

}