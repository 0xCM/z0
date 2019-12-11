//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    public class t_vlt : t_vinx<t_vlt>
    {        
        public void vlt_128x8i()
            => vlt_check<sbyte>(n128);

        public void vlt_128x8u()
            => vlt_check<byte>(n128);

        public void vlt_128x16i()
            => vlt_check<short>(n128);

        public void vlt_128x16u()
            => vlt_check<ushort>(n128);

        public void vlt_128x32i()
            => vlt_check<int>(n128);

        public void vlt_128x32u()
            => vlt_check<uint>(n128); 

        public void vlt_128x64i()
            => vlt_check<long>(n128); 

        public void vlt_128x64u()
            => vlt_check<ulong>(n128); 

        public void vlt_256x8i()
            => vlt_check<sbyte>(n256);

        public void vlt_256x8u()
            => vlt_check<byte>(n256);

        public void vlt_256x16i()
            => vlt_check<short>(n256);

        public void vlt_256x16u()
            => vlt_check<ushort>(n256);

        public void vlt_256x32i()
            => vlt_check<int>(n256);

        public void vlt_256x32u()
            => vlt_check<uint>(n256);

        public void vlt_256x64i()
            => vlt_check<long>(n256);

        public void vlt_256x64u()
            => vlt_check<ulong>(n256);

    }
}