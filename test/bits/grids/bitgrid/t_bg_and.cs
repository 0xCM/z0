//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Memories;
    
    public class t_bg_and : t_bg<t_bg_and>
    {        
        public void bg_and_n8x8x8()
            => bg_and_check(n8,n8,z8);

        public void bg_and_n8x16x8()
            => bg_and_check(n8,n16,z8);

        public void bg_and_n50x50x16()
            => bg_and_check(n50,n50,z16);

        public void bg_and_n51x51x8()
            => bg_and_check(n51,n51,z8);

        public void bg_and_n64x64x16()
            => bg_and_check(n64,n64,z16);

        public void bg_and_n256x128x64()
            => bg_and_check(n256,n128,z64);

        public void bg_and_n64x128x32()
            => bg_and_check(n64,n128,z32);

        public void bg_and_n64x64x64()
            => bg_and_check(n64,n64,z64);

        public void bg_and_g8x8x8()
            => bg_and_check(n8, (int)n8, z8);

        public void bg_and_8x16x8()
            => bg_and_check(n8, (int)n16, z8);

        public void bg_and_g50x50x16()
            => bg_and_check(n50, (int)n50, z16);

        public void bg_and_g64x64x16()
            => bg_and_check(n64, (int)n64, z16);

        public void bg_and_256x128x64()
            => bg_and_check(n256, (int)n128, z64);

        public void bg_and_g64x128x32()
            => bg_and_check(n64, (int)n128, z32);

        public void bg_and_g64x64x64()
            => bg_and_check(n64, (int)n64, z64);

        public void bg_and_g256x256x64()
            => bg_and_check(n256, (int)n256, z64);

        public void bg_and_g512x512x64()
            => bg_and_check(n512, (int)n512, z64);

        public void bg_and_1024x1024x64()
            => bg_and_check(n1024, (int)n1024, z64);
   }
}