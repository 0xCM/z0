//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vsrl : t_vinx<t_vsrl>
    {
        public void vsrl_128x8u()
            => vsrl_check<byte>(n128);

        public void vsrl_128x16u()
            => vsrl_check<ushort>(n128);

        public void vsrl_128x32u()
            => vsrl_check<uint>(n128);

        public void vsrl_128x64u()
            => vsrl_check<ulong>(n128);

        public void vsrl_256x8u()
            => vsrl_check<byte>(n256);

        public void vsrl_256x16u()
            => vsrl_check<ushort>(n256);

        public void vsrl_256x32u()
            => vsrl_check<uint>(n256);

        public void vsrl_256x64u()
            => vsrl_check<ulong>(n256);

        public void vsrl_128x8u_bench()
            => vsrl_bench<byte>(n128);

        public void vsrl_128x16u_bench()
            => vsrl_bench<ushort>(n128);

        public void vsrl_128x32u_bench()
            => vsrl_bench<uint>(n128);

        public void vsrl_128x64u_bench()
            => vsrl_bench<ulong>(n128);

        public void vsrl_256x8u_bench()
            => vsrl_bench<byte>(n256);

        public void vsrl_256x16u_bench()
            => vsrl_bench<ushort>(n256);

        public void vsrl_256x32u_bench()
            => vsrl_bench<uint>(n256);

        public void vsrl_256x64u_bench()
            => vsrl_bench<ulong>(n256);
    }
}