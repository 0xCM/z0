//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bsp_disable : t_bitspan<t_bsp_disable>
    {
        public void bsp_disable_16x16()
            => bitspan_disable_check<N16,ushort>();

        public void bsp_disable_32x32()
            => bitspan_disable_check<uint>(32);

        public void bsp_disable_n32x32()
            => bitspan_disable_check<N32,uint>();

        public void bsp_disable_64x64()
            => bitspan_disable_check<ulong>(64);

        public void bsp_disable_n64x64()
            => bitspan_disable_check<N64,ulong>();

        public void bsp_disable_213x8()
            => bitspan_disable_check<byte>(213);

        public void bsp_disable_213x16()
            => bitspan_disable_check<ushort>(213);

        public void bsp_disable_213x32()
            => bitspan_disable_check<uint>(213);

        public void bsp_disable_213x64()
            => bitspan_disable_check<ulong>(213);
        
        public void bsp_disable_n213x8()
            => bitspan_disable_check(n213, z8);

        public void bsp_disable_n213x16()
            => bitspan_disable_check(n213, z16);

        public void bsp_disable_n213x32()
            => bitspan_disable_check(n213, z32);

        public void nbc_disable_213x64()
            => bitspan_disable_check(n213, z64);

        void bsp_disable_n707x64u()
        {
            var n707 = nat(n7,n0,n7);
            Claim.eq(707,(int)n707.NatValue);
            bitspan_disable_check(n707, (ulong)0);
        }
    }

}