//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vhi : t_vinx<t_vhi>
    {   
        public void vhi_128x8u()
            => vhi_check<byte>(n128);

        public void vhi_128x8i()
            => vhi_check<sbyte>(n128);

        public void vhi_128x16i()
            => vhi_check<short>(n128);

        public void vhi_128x16u()
            => vhi_check<ushort>(n128);

        public void vhi_128x32i()
            => vhi_check<int>(n128);

        public void vhi_128x32u()
            => vhi_check<uint>(n128);

        public void vhi_128x64i()
            => vhi_check<long>(n128);

        public void vhi_128x64u()
            => vhi_check<ulong>(n128);

        public void vhi_128x32f()
            => vhi_check<float>(n128);

        public void vhi_128x64f()
            => vhi_check<double>(n128);

        public void vhi_256x8u()
            => vhi_check<byte>(n256);

        public void vhi_256x8i()
            => vhi_check<sbyte>(n256);

        public void vhi_256x16i()
            => vhi_check<short>(n256);

        public void vhi_256x16u()
            => vhi_check<ushort>(n256);

        public void vhi_256x32i()
            => vhi_check<int>(n256);

        public void vhi_256x32u()
            => vhi_check<uint>(n256);

        public void vhi_256x64i()
            => vhi_check<long>(n256);

        public void vhi_256x64u()
            => vhi_check<ulong>(n256);

        public void vhi_256x32f()
            => vhi_check<float>(n256);

        public void vhi_256x64f()
            => vhi_check<double>(n256);
    }

}