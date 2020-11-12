//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    public class t_bg_xor : t_bitgrids<t_bg_xor>
    {
        public void nbg_xor_8x8x8()
            => bg_xor_check(n8,n8,z8);

        public void nbg_xor_8x16x8()
            => bg_xor_check(n8,n16,z8);

        public void nbg_xor_50x50x16()
            => bg_xor_check(n50,n50,z16);

        public void nbg_xor_64x64x16()
            => bg_xor_check(n64,n64,z16);

        public void nbg_xor_256x128x64()
            => bg_xor_check(n256,n128,z64);

        public void nbg_xor_64x128x32()
            => bg_xor_check(n64,n128,z32);

        public void nbg_xor_64x64x64()
            => bg_xor_check(n64,n64,z64);

        public void nbg_xor_1024x1024x32()
            => bg_xor_check(n1024,n1024,z32);

        public void nbg_xor_1024x1024x64()
            => bg_xor_check(n1024,n1024,z64);

   }
}