//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    
    using static zfunc;

    public class t_vsllv : t_vinx<t_vsllv>
    {

        public void vsllv_128x8u()
            => vsllv_check(n128,z8);

        public void vsllv_128x16u()
            => vsllv_check(n128,z16);

        public void vsllv_128x32u()
            => vsllv_check(n128,z32);

        public void vsllv_128x64u()
            => vsllv_check(n128,z64);

        public void vsllv_256x8u()
            => vsllv_check(n256,z8);

        public void vsllv_256x16u()
            => vsllv_check(n256,z16);

        public void vsllv_256x32u()
            => vsllv_check(n256,z32);

        public void vsllv_256x64u()
            => vsllv_check(n256,z64);
    }

}