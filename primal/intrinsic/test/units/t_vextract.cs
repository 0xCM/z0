//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static zfunc;

    public class t_vextract : UnitTest<t_vextract>
    {     
        public void extract_128x8u()
            => extract_check<byte>(n128);

        public void extract_128x8i()
            => extract_check<sbyte>(n128);

        public void extract128()
        {
            
            extract_check<short>(n128);
            extract_check<ushort>(n128);
            extract_check<int>(n128);
            extract_check<uint>(n128);
            extract_check<long>(n128);
            extract_check<ulong>(n128);

        }

        public void extract256()
        {
            extract_check<byte>(n256);
            extract_check<sbyte>(n256);
            extract_check<short>(n256);
            extract_check<ushort>(n256);
            extract_check<int>(n256);
            extract_check<uint>(n256);
            extract_check<long>(n256);
            extract_check<ulong>(n256);
            
        }

        void extract_check<T>(N128 n)
            where T : unmanaged
        {

            var len = Vec128<T>.Length;
            var src = Random.CpuVector<T>(n128);
            var actual = src.ToSpan();
            var expect = span<T>(len);
            src.StoreTo(expect);
            for(byte i = 0; i< len; i++)
                Claim.eq(expect[i], actual[i]);
        }
            
        public void extract_check<T>(N256 n)
            where T : unmanaged
        {

            var len = Vec256<T>.Length;
            var half = len >> 1;
            var src = Random.CpuVector<T>(n256);
            var srcData = src.StoreTo(span<T>(len));
            
            var x0 = ginx.vlo(src);
            var y0 = x0.StoreTo(span<T>(half));
            var z0 = srcData.Slice(0, half);
            Claim.eq(y0,z0);

            var x1 = ginx.vhi(src);
            var y1 = x1.StoreTo(span<T>(half));
            var z1 = srcData.Slice(half);
            Claim.eq(y1,z1);

        }
    }
}