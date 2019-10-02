//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class t_vandn : UnitTest<t_vandn>
    {

        void vandn_check<T>()
            where T : unmanaged
        {
            var vZero = Vec128<T>.Zero;
            for(var i=0; i<SampleSize; i++)
            {
                var x1 = Random.CpuVector128<T>();                    
                var y1 = Random.CpuVector128<T>();                    
                var z1 = gbits.andn(in x1, in y1);
                var z2 = gbits.andn(in x1, in x1);
                var z1s = z1.ToSpan();
                var z2s = z2.ToSpan();

                var z = PrimalInfo.Get<T>().Zero;
                for(var j = 0; j<z1s.Length; j++)
                {
                    gbits.or(in z, z1s[j], ref z);
                    Claim.nea(gmath.nonzero(z2s[j]));
                }
                
                Claim.yea(gmath.nonzero(z));

                Claim.yea(z2 == vZero);
            }
        }




    }

}