//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class t_vnegate : IntrinsicTest<t_vnegate>
    {

        public void vnegate_g128x8i_check()
        {
            vnegate_g128_check<sbyte>();
        }


        public void vnegate_g128x16i_check()
        {
            vnegate_g128_check<short>();
        }

        public void vnegate_g128x16u_check()
        {
            vnegate_g128_check<ushort>();
        }

        public void vnegate_g128x32i_check()
        {
            vnegate_g128_check<int>();
        }

        public void vnegate_g128x32u_check()
        {
            vnegate_g128_check<uint>();
        }

        public void vnegate_g128x64i_check()
        {
            vnegate_g128_check<long>();
        }

        public void vnegate_g128x64u_check()
        {
            vnegate_g128_check<ulong>();
        }

        public void vnegate_g128x32f_check()
        {
            vnegate_g128_check<float>();
        }

        public void vnegate_g128x64f_check()
        {
            vnegate_g128_check<double>();
        }

        public void vnegate_g256x8i_check()
        {
            vnegate_g256_check<sbyte>();
        }

        public void vnegate_g256x8u_check()
        {
            vnegate_g256_check<byte>();
        }

        public void vnegate_g256x16i_check()
        {
            vnegate_g256_check<short>();
        }

        public void vnegate_g256x16u_check()
        {
            vnegate_g256_check<ushort>();
        }

        public void vnegate_g256x32i_check()
        {
            vnegate_g256_check<int>();
        }

        public void vnegate_g256x32u_check()
        {
            vnegate_g256_check<uint>();
        }

        public void vnegate_g256x64i_check()
        {
            vnegate_g256_check<long>();
        }

        public void vnegate_g256x64u_check()
        {
            vnegate_g256_check<ulong>();
        }

        public void vnegate_g256x32f_check()
        {
            vnegate_g256_check<float>();
        }

        public void vnegate_g256x64f_check()
        {
            vnegate_g256_check<double>();
        }


        void vnegate_g128_check<T>(N128 n = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n);
                var y = ginx.vnegate(x);
                var z = x.ToSpan().Map(gmath.negate).LoadVector(n);
                Claim.eq(y,z);
            }
        }

        void vnegate_g256_check<T>(N256 n = default)
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var x = Random.CpuVector<T>(n);
                var y = ginx.vnegate(x);
                var z = x.ToSpan().Map(gmath.negate).LoadVector(n);
                Claim.eq(y,z);
            }

        }

    }

}