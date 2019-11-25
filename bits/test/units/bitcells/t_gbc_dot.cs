//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_gbc_dot : t_bc<t_gbc_dot>
    {
        public void gbc_dot_10x32()
            => gbc_dot_check<uint>(10);

        public void gbc_dot_20x32()
            => gbc_dot_check<uint>(20);

        public void gbc_dot_63x64()
            => gbc_dot_check<uint>(63);

        public void gbc_dot_84x64()
            => gbc_dot_check<ulong>(84);

        public void gbc_dot_87x64()
            => gbc_dot_check<ulong>(87);

        public void gbc_dot_87x8()
            => gbc_dot_check<byte>(87);

        public void gbc_dot_128x16()
            => gbc_dot_check<ushort>(128);

        public void gbc_dot_25x16()
            => gbc_dot_check<ushort>(25);

        public void gbc_dot_256x64()
            => gbc_dot_check<ulong>(256);

        public void gbc_dot_2048x32()
            => gbc_dot_check<uint>(2048);
    }
}

