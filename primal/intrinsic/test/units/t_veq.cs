//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    
    public class tv_eq : UnitTest<tv_eq>
    {        

        public void veq_128x8i_check()
        {
            
            veq_g128_check<sbyte>();
        }

        public void veq_128x8u_check()
        {
            
            veq_g128_check<byte>();
        }

        public void veq_128x16i_check()
        {
            
            veq_g128_check<short>();
        }

        public void veq_128x16u_check()
        {
            
            veq_g128_check<ushort>();
        }

        public void veq_128x32i_check()
        {
            
            veq_g128_check<int>();
        }

        public void veq_128x32u_check()
        {
            
            veq_g128_check<uint>();
        }

        public void veq_128x64i_check()
        {
            
            veq_g128_check<long>();
        }

        public void veq_128x64u_check()
        {
            
            veq_g128_check<ulong>();
        }

        public void veq_128x32f_check()
        {
            
            veq_g128_check<float>();
        }

        public void veq_128x64f_check()
        {
            
            veq_g128_check<double>();
        }

        public void veq_256x8i_check()
        {
            
            veq_g256_check<sbyte>();
        }

        public void veq_256x8u_check()
        {
            
            veq_g256_check<byte>();
        }


        public void veq_256x16i_check()
        {
            
            veq_g256_check<short>();
        }

        public void veq_256x16u_check()
        {
            
            veq_g256_check<ushort>();
        }

        public void veq_256x32i_check()
        {
            
            veq_g256_check<int>();
        }

        public void veq_256x32u_check()
        {
            
            veq_g256_check<uint>();
        }

        public void veq_256x64i_check()
        {
            
            veq_g256_check<long>();
        }

        public void veq_256x64u_check()
        {
            
            veq_g256_check<ulong>();
        }

        public void veq_256x32f_check()
        {
            
            veq_g256_check<float>();
        }

        public void veq_256x64f_check()
        {
            
            veq_g256_check<double>();
        }

        void veq_g128_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var v1 = Random.CpuVec128<T>();
                var v2 = Random.CpuVec128<T>();
                var eq = ginx.eq(in v1, in v2);
                Claim.nea(ginx.eq(in v1, in v2));
                Claim.yea(ginx.eq(in v1, in v1));
                Claim.yea(ginx.eq(in v2, in v2));    
            }

        }

        void veq_g256_check<T>()
            where T : unmanaged
        {
            for(var i=0; i<SampleSize; i++)
            {
                var v1 = Random.CpuVec256<T>();
                var v2 = Random.CpuVec256<T>();
                var eq = ginx.eq(in v1, in v2);
                Claim.nea(ginx.eq(in v1, in v2));
                Claim.yea(ginx.eq(in v1, in v1));
                Claim.yea(ginx.eq(in v2, in v2));    
            }

        }

    }

}