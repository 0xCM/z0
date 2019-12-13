//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vinc : t_vinx<t_vinc>
    {
        public void vinc_128x8u()
            => vinc_check<byte>(n128);

        public void vinc_128x8i()
            => vinc_check<sbyte>(n128);

        public void vinc_128x16i()
            => vinc_check<short>(n128);

        public void vinc_128x16u()
            => vinc_check<ushort>(n128);

        public void vinc_128x32i()
            => vinc_check<int>(n128);

        public void vinc_128x32u()
            => vinc_check<uint>(n128);

        public void vinc_128x64i()
            => vinc_check<long>(n128);

        public void vinc_128x64u()
            => vinc_check(n128,z64);

        public void vinc_256x8u()
            => vinc_check(n256,z8);

        public void vinc_256x8i()
            => vinc_check(n256,z8i);

        public void vinc_256x16i()
            => vinc_check(n256,z16i);

        public void vinc_256x16u()
            => vinc_check(n256,z16);

        public void vinc_256x32i()
            => vinc_check(n256,z32i);

        public void vinc_256x32u()
            => vinc_check(n256,z32);

        public void vinc_256x64i()
            => vinc_check(n256,z64i);

        public void vinc_256x64u()
            => vinc_check(n256,z64);
    }
}