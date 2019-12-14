//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bsp_dot : t_bitspan<t_bsp_dot>
    {
        public void gbc_dot_10x32()
            => bitspan_dot_check<uint>(10);

        public void gbc_dot_20x32()
            => bitspan_dot_check<uint>(20);

        public void gbc_dot_63x64()
            => bitspan_dot_check<uint>(63);

        public void gbc_dot_84x64()
            => bitspan_dot_check<ulong>(84);

        public void gbc_dot_87x64()
            => bitspan_dot_check<ulong>(87);

        public void gbc_dot_87x8()
            => bitspan_dot_check<byte>(87);

        public void gbc_dot_128x16()
            => bitspan_dot_check<ushort>(128);

        public void gbc_dot_25x16()
            => bitspan_dot_check<ushort>(25);

        public void gbc_dot_256x64()
            => bitspan_dot_check<ulong>(256);

        public void gbc_dot_2048x32()
            => bitspan_dot_check<uint>(2048);

        public void nbc_dot_8x8()
            => bitspan_dot_check<N8,byte>();

        public void nbc_dot_16x16()
            => bitspan_dot_check<N16,ushort>();

        public void nbc_dot_32x32()
            => bitspan_dot_check<N32,uint>();

        public void nbc_dot_64x64()
            => bitspan_dot_check<N64,ulong>();

        public void nbc_dot_10x32()
            => bitspan_dot_check<N10,uint>();

        public void nbc_dot_20x32()
            => bitspan_dot_check<N20,uint>();

        public void nbc_dot_25x32()
            => bitspan_dot_check<N25,uint>();

        public void nbc_dot_63x64()
            => bitspan_dot_check<N63,ulong>();

        public void nbc_dot_87x8()
            => bitspan_dot_check<N87,byte>();

        public void nbc_dot_128x16()
            => bitspan_dot_check<N128,ushort>();

        public void nbc_dot_217x16()
            => bitspan_dot_check(n217, z16);

        public void nbc_dot_217x32()
            => bitspan_dot_check(n217, z32);

        public void nbc_dot_217x64()
            => bitspan_dot_check(n217, z64);

        public void nbc_dot_256x32()
            => bitspan_dot_check(n256, z32);

        public void nbc_dot_256x64()
            => bitspan_dot_check(n256, z64);

    }
}

