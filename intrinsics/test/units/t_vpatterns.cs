//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public class t_vpatterns : IntrinsicTest<t_vpatterns>
    {
        public void vones_128()
        {
            var n = n128;
            vones_check<byte>(n);            
            vones_check<ushort>(n);            
            vones_check<uint>(n);
            vones_check<ulong>(n);
            vones_check<sbyte>(n);            
            vones_check<short>(n);            
            vones_check<int>(n);
            vones_check<long>(n);
        }

        public void vones_256()
        {
            var n = n256;
            vones_check<byte>(n);            
            vones_check<ushort>(n);            
            vones_check<uint>(n);
            vones_check<ulong>(n);
            vones_check<sbyte>(n);            
            vones_check<short>(n);            
            vones_check<int>(n);
            vones_check<long>(n);
        }

        public void vunits_128x8i()
            => vunits_check<sbyte>(n128);

        public void vunits_128x8u()
            => vunits_check<byte>(n128);

        public void vunits_128x16u()
            => vunits_check<ushort>(n128);

        public void vunits_128x16i()
            => vunits_check<short>(n128);

        public void vunits_128x32i()
            => vunits_check<int>(n128);

        public void vunits_128x32u()
            => vunits_check<uint>(n128);

        public void vunits_128x64u()
            => vunits_check<ulong>(n128);

        public void vunits_256x8i()
            => vunits_check<sbyte>(n256);

        public void vunits_256x8u()
            => vunits_check<byte>(n256);

        public void vunits_256x16u()
            => vunits_check<ushort>(n256);

        public void vunits_256x16i()
            => vunits_check<short>(n256);

        public void vunits_256x32i()
            => vunits_check<int>(n256);

        public void vunits_256x32u()
            => vunits_check<uint>(n256);

        public void vunits_256x64u()
            => vunits_check<ulong>(n256);
   }
}