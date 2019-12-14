//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_bsp_create : t_bitspan<t_bsp_create>
    {
        public void bc_span_124x8()
            => bitspan_create_check<byte>(124);

        public void bc_span_128x8()
            => bitspan_create_check<byte>(128);

        public void bc_span_13x16()
            => bitspan_create_check<ushort>(13);

        public void bc_span_125x16()
            => bitspan_create_check<ushort>(125);

        public void bc_span_128x16()
            => bitspan_create_check<ushort>(128);

        public void bc_span_13x32()
            => bitspan_create_check<uint>(13);

        public void bc_span_64x32()
            => bitspan_create_check<uint>(64);

        public void bc_span_125x32()
            => bitspan_create_check<uint>(125);

        public void bc_span_128x32()
            => bitspan_create_check<uint>(128);

        public void bc_span_63x64()
            => bitspan_create_check<ulong>(63);

        public void bc_span_127x64()
            => bitspan_create_check<ulong>(127);

        public void bc_span_128x64()
            => bitspan_create_check<ulong>(128);

        public void bc_span_n63x64u()
            => bitspan_create_check<N63,ulong>();

        public void bc_span_n13x16u()
            => bitspan_create_check<N13,ushort>();

        public void bc_span_n32x32u()
            => bitspan_create_check<N32,uint>();

    }
}