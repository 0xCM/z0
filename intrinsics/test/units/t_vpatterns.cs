//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vpatterns : t_vinx<t_vpatterns>
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
            => vunits_check<uint>(n128,z32);

        public void vunits_128x64u()
            => vunits_check<ulong>(n128);

        public void vunits_256x8i()
            => vunits_check<sbyte>(n256,z8i);

        public void vunits_256x8u()
            => vunits_check<byte>(n256,z8);

        public void vunits_256x16u()
            => vunits_check<ushort>(n256,z16);

        public void vunits_256x16i()
            => vunits_check<short>(n256);

        public void vunits_256x32i()
            => vunits_check<int>(n256);

        public void vunits_256x32u()
            => vunits_check<uint>(n256);

        public void vunits_256x64u()
            => vunits_check<ulong>(n256);

        public void valt_256x8u()
        {
            var n = n256;
            var x = CpuVector.valt(n, 0xAA, 0x55);
            var xs = x.ToSpan();
            for(var i=0; i<xs.Length; i++)
                Claim.eq(even(i) ? 0xAA : 0x55,  xs[i]);
        }

   }
}