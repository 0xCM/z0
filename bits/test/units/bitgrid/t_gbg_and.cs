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
    
    public class t_gbg_and : t_bg<t_gbg_and>
    {        
        public void gbg_and_8x8x8()
            => gbg_and_check(n8,n8,z8);

        public void gbg_and_8x16x8()
            => gbg_and_check(n8,n16,z8);

        public void gbg_and_50x50x16()
            => gbg_and_check(n50,n50,z16);

        public void gbg_and_64x64x16()
            => gbg_and_check(n64,n64,z16);

        public void gbg_and_256x128x64()
            => gbg_and_check(n256,n128,z64);

        public void gbg_and_64x128x32()
            => gbg_and_check(n64,n128,z32);

        public void gbg_and_64x64x64()
            => gbg_and_check(n64,n64,z64);

        public void gbg_and_256x256x64()
            => gbg_and_check(n256,n256,z64);

        public void gbg_and_512x512x64()
            => gbg_and_check(n512,n512,z64);

        public void gbg_and_1024x1024x64()
            => gbg_and_check(n1024,n1024,z64);


   }

}