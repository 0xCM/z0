//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class t_bzhi : ScalarBitTest<t_blsic>
    {

        protected override int CycleCount => Pow2.T17;

        public void bzhi_64u_check()
        {
            bzhi_check<ulong>();
        }

        public void bzhi_32u_check()
        {
            bzhi_check<uint>();
        }

        public void bzhi_64u_bench()
        {
            bzhi_bench<ulong>();
        }

        public void bzhi_32u_bench()
        {
            bzhi_bench<uint>();
        }

        void bzhi_check<T>()
            where T : unmanaged
        {
            var width = bitsize<T>();
            for(var i= 0; i< SampleSize; i++)
            {
                var x = Random.Next<T>();
                var j = Random.Next(2u, width - width/2);
                var y = gbits.bzhi(x, j);

                var x0 = gbits.range(x,0,j - 1);
                var y0 = gbits.range(y,0,j - 1);
                var y1 = gbits.range(y,j, width - 1);
                Claim.eq(x0,y0);
                Claim.nea(gmath.nonzero(y1));            
                        
            }
        }

        void bzhi_bench<T>(SystemCounter counter = default)
            where T : unmanaged
        {
            var last = default(T);
            var width = bitsize<T>();
            var j = Random.Next(2u, width - width/2);
            for(var i=0; i< OpCount; i++)
            {
                var x = Random.Next<T>();
                counter.Start();
                last = gbits.bzhi(x, j);
                counter.Stop();
            }


            Benchmark($"bzhi_g{moniker<T>()}", counter);

        }

    }

}
