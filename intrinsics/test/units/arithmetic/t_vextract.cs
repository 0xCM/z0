//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    public class t_vextract : t_vinx<t_vextract>
    {     
        public void vextract_128x8u()
            => vextract_check<byte>(n128);

        public void vextract_128x8i()
            => vextract_check<sbyte>(n128);

        public void vextract_128x16u()
            => vextract_check<ushort>(n128);

        public void vextract_128x16i()
            => vextract_check<short>(n128);

        public void vextract_128x32i()
            => vextract_check<int>(n128);

        public void vextract_128x32u()
            => vextract_check<uint>(n128);

        public void vextract_128x64i()
            => vextract_check<long>(n128);

        public void vextract_128x64u()
            => vextract_check<ulong>(n128);

        public void vextract_256x8i()
            => vextract_check<sbyte>(n256);

        public void vextract_256x8u()
            => vextract_check<byte>(n256);

        public void vextract_256x16u()
            => vextract_check<ushort>(n256);

        public void vextract_256x32i()
            => vextract_check<int>(n256);

        public void vextract_256x32u()
            => vextract_check<uint>(n256);

        public void vextract_256x64i()
            => vextract_check<long>(n256);

        public void vextract_256x64u()
            => vextract_check<ulong>(n256);

        protected void vextract_check<T>(N256 w, T t = default)
            where T : unmanaged
        {
            var len = zfunc.vcount<T>(w);
            var half = len >> 1;
            var src = Random.CpuVector<T>(w);
            var srcData = span<T>(len);
            src.StoreTo(srcData);
            
            var x0 = ginx.vlo(src);
            var y0 = span<T>(half);
            x0.StoreTo(y0);
            var z0 = srcData.Slice(0, half);
            Claim.eq(y0,z0);

            var x1 = ginx.vhi(src);
            var y1 = span<T>(half);
            x1.StoreTo(y1);
            var z1 = srcData.Slice(half);
            Claim.eq(y1,z1);

        }

    }
}