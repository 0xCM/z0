//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public class t_vclear : t_vcpu<t_vclear>
    {

        public void vclear_128x8()
            => vclear_check(n128,z8);

        public void vclear_128x32()
            => vclear_check(n128,z32);

        public void vclear_256x8()
            => vclear_check(n256,z8);

        public void vclear_256x16()
            => vclear_check(n256,z16);

        public void vclear_256x32()
            => vclear_check(n256,z32);

        public void vclear_256x64()
            => vclear_check(n256,z16);

        protected void vclear_check<T>(N128 n, T t = default)
            where T : unmanaged
        {            
            for(var i=0; i< SampleSize; i++)
            {
                byte start = Random.Next<byte>(0, (byte)bitsize<T>());
                byte length = (byte)(bitsize<T>() - start);
                var cellcount = n/bitsize(t);
                var x = Random.CpuVector<T>(n);
                var x1 = gbits.vclear(x, start, length);                                    
                var x2 = ginx.vsrl(x1,start);
                Claim.nea(ginx.vnonz(x2));
            }
        }

        public void vclear_check<T>(N256 n, T t = default)
            where T : unmanaged
        {
            
            for(var i=0; i< SampleSize; i++)
            {
                byte start = Random.Next<byte>(0, (byte)bitsize<T>());
                byte length = (byte)(bitsize<T>() - start);
                var cellcount = n/bitsize(t);
                var x = Random.CpuVector<T>(n);
                var x1 = gbits.vclear(x, start, length);                                    
                var x2 = ginx.vsrl(x1,start);
                Claim.nea(ginx.vnonz(x2));
            }
        }
    }
}