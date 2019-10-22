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

    public class tv_extract : UnitTest<tv_extract>
    {     
        public void extract128()
        {
            extract128_check<byte>();
            extract128_check<sbyte>();
            extract128_check<short>();
            extract128_check<ushort>();
            extract128_check<int>();
            extract128_check<uint>();
            extract128_check<long>();
            extract128_check<ulong>();

        }

        public void extract256()
        {
            extract256_check<byte>();
            extract256_check<sbyte>();
            extract256_check<short>();
            extract256_check<ushort>();
            extract256_check<int>();
            extract256_check<uint>();
            extract256_check<long>();
            extract256_check<ulong>();
            
        }

        void extract128_check<T>()
            where T : unmanaged
        {

            var len = Vec128<T>.Length;
            var src = Random.CpuVector128<T>();
            var actual = src.ToSpan();
            var expect = span<T>(len);
            src.StoreTo(expect);
            for(byte i = 0; i< len; i++)
                Claim.eq(expect[i], actual[i]);

        }
            
        public void extract256_check<T>()
            where T : unmanaged
        {

            var len = Vec256<T>.Length;
            var half = len >> 1;
            var src = Random.CpuVector256<T>();
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