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
            => inc_check<byte>(n128);

        public void vinc_128x8i()
            => inc_check<sbyte>(n128);

        public void vinc_128x16i()
            => inc_check<short>(n128);

        public void vinc_128x16u()
            => inc_check<ushort>(n128);

        public void vinc_128x32i()
            => inc_check<int>(n128);

        public void vinc_128x32u()
            => inc_check<uint>(n128);

        public void vinc_128x64i()
            => inc_check<long>(n128);

        public void vinc_128x64u()
            => inc_check<ulong>(n128);

        public void vinc_256x8u()
            => inc_check<byte>(n256);

        public void vinc_256x8i()
            => inc_check<sbyte>(n256);

        public void vinc_256x16i()
            => inc_check<short>(n256);

        public void vinc_256x16u()
            => inc_check<ushort>(n256);

        public void vinc_256x32i()
            => inc_check<int>(n256);

        public void vinc_256x32u()
            => inc_check<uint>(n256);

        public void vinc_256x64i()
            => inc_check<long>(n256);

        public void vinc_256x64u()
            => inc_check<ulong>(n256);
    }
}