//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vsll : t_vinx<t_vsll>
    {
        public void vsll_128x8u()
            => vsll_check<byte>(n128);

        public void vsll_128x16u()
            => vsll_check<ushort>(n128);

        public void vsll_128x32u()
            => vsll_check<uint>(n128);

        public void vsll_128x64u()
            => vsll_check<ulong>(n128);

        public void vsll_256x8u()
            => vsll_check<byte>(n256);

        public void vsll_256x16u()
            => vsll_check<ushort>(n256);

        public void vsll_256x32u()
            => vsll_check<uint>(n256);

        public void vsll_256x64u()
            => vsll_check<ulong>(n256);

        public void vsll_128x8u_bench()
            =>vsll_bench<byte>(n128);

        public void vsll_128x16u_bench()
            => vsll_bench<ushort>(n128);

        public void vsll_128x32u_bench()
            => vsll_bench<uint>(n128);

        public void vsll_128x64u_bench()
            => vsll_bench<ulong>(n128);

        public void vsll_256x8u_bench()
            => vsll_bench<byte>(n256);

        public void vsll_256x16u_bench()
            => vsll_bench<ushort>(n256);

        public void vsll_256x32u_bench()
            => vsll_bench<uint>(n256);

        public void vsll_256x64u_bench()
            => vsll_bench<ulong>(n256);
    }
}