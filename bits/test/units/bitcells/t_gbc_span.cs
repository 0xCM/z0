//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_gbc_span : t_bc<t_gbc_span>
    {
        public void gbc_span_124x8()
            => gbc_span_check<byte>(124);

        public void gbc_span_128x8()
            => gbc_span_check<byte>(128);

        public void gbc_span_13x16()
            => gbc_span_check<ushort>(13);

        public void gbc_span_125x16()
            => gbc_span_check<ushort>(125);

        public void gbc_span_128x16()
            => gbc_span_check<ushort>(128);

        public void gbc_span_13x32()
            => gbc_span_check<uint>(13);

        public void gbc_span_64x32()
            => gbc_span_check<uint>(64);

        public void gbc_span_125x32()
            => gbc_span_check<uint>(125);

        public void gbc_span_128x32()
            => gbc_span_check<uint>(128);

        public void gbc_span_63x64()
            => gbc_span_check<ulong>(63);

        public void gbc_span_127x64()
            => gbc_span_check<ulong>(127);

        public void gbc_span_128x64()
            => gbc_span_check<ulong>(128);
    }
}