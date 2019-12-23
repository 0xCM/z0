//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vrot : t_vinx<t_vrot>
    {
        public void vrotl_128x8()
            => vrotl_check(n128,z8);

        public void vrotl_128x16()
            => vrotl_check(n128,z16);

        public void vrotl_128x32()
            => vrotl_check(n128,z32);

        public void vrotl_128x64()
            => vrotl_check(n128,z64);

        public void vrotr_128x8()
            => vrotr_check<byte>(n128);

        public void vrotr_128x16()
            => vrotr_check<ushort>(n128);

        public void vrotr_128x32()
            => vrotr_check<uint>(n128);

        public void vrotr_128x64()
            => vrotr_check<ulong>(n128);

        public void vrotl_256x8()
            => vrotl_check<byte>(n256);

        public void vrotl_256x16()
            => vrotl_check<ushort>(n256);

        public void vrotl_256x32()
            => vrotl_check<uint>(n256);

        public void vrotl_256x64()
            => vrotl_check<ulong>(n256);

        public void vrotr_256x8()
            => vrotr_check<byte>(n256);

        public void vrotr_256x16()
            => vrotr_check<ushort>(n256);

        public void vrotr_256x32()
            => vrotr_check<uint>(n256);

        public void vrotr_256x64()
            => vrotr_check<ulong>(n256);

    }
}