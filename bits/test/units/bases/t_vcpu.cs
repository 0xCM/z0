//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static BitVector;

    public abstract class t_vcpu<X> : t_bits<X>
        where X : t_vcpu<X>, new()
    {

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