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

    public class t_reverse : IntrinsicTest<t_reverse>
    {
        public void vreverse_128x8u()
            => vreverse_check(n128,z8);

        public void vreverse_128x8i()
            => vreverse_check(n128,z8i);

        public void vreverse_128x16u()
            => vreverse_check(n128,z16);

        public void vreverse_128x16i()
            => vreverse_check(n128,z16i);

        public void vreverse_128x32u()
            => vreverse_check(n128,z32);

        public void vreverse_128x321()
            => vreverse_check(n128,z32i);

        public void vreverse_128x64u()
            => vreverse_check(n128,z64);

        public void vreverse_128x64i()
            => vreverse_check(n128,z64i);

        public void vreverse_256x8u()
            => vreverse_check(n256,z8);

        public void vreverse_256x8i()
            => vreverse_check(n256,z8i);

        public void vreverse_256x16u()
            => vreverse_check(n256,z16);

        public void vreverse_256x16i()
            => vreverse_check(n256,z16i);

        public void vreverse_256x32u()
            => vreverse_check(n256,z32);

        public void vreverse_256x32i()
            => vreverse_check(n256,z32i);

        public void vreverse_256x64u()
            => vreverse_check(n256,z64);

        public void vreverse_256x64i()
            => vreverse_check(n256,z64i);
   }

}