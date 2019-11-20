//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static zfunc;

    public class t_vextract : IntrinsicTest<t_vextract>
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

        public void extract256()
        {
            vextract_check<byte>(n256);
            vextract_check<sbyte>(n256);
            vextract_check<short>(n256);
            vextract_check<ushort>(n256);
            vextract_check<int>(n256);
            vextract_check<uint>(n256);
            vextract_check<long>(n256);
            vextract_check<ulong>(n256);
            
        }

        void vextract_check<T>(N128 n)
            where T : unmanaged
        {

            var len = vcount<T>(n);
            var src = Random.CpuVector<T>(n);
            var actual = src.ToSpan();
            var expect = span<T>(len);
            src.Store(expect);
            for(byte i = 0; i< len; i++)
                Claim.eq(expect[i], actual[i]);
        }
            
        void vextract_check<T>(N256 n)
            where T : unmanaged
        {
            var len = vcount<T>(n);
            var half = len >> 1;
            var src = Random.CpuVector<T>(n);
            var srcData = src.Store(span<T>(len));
            
            var x0 = ginx.vlo(src);
            var y0 = x0.Store(span<T>(half));
            var z0 = srcData.Slice(0, half);
            Claim.eq(y0,z0);

            var x1 = ginx.vhi(src);
            var y1 = x1.Store(span<T>(half));
            var z1 = srcData.Slice(half);
            Claim.eq(y1,z1);

        }
    }
}