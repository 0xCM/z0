//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;


    public class t_delgate : AsmOpTest<t_delgate>
    {        

        public void add_128x8u_bench()
            => add_bench<byte>();


        void add_bench<T>(SystemCounter subject = default, N128 n = default, SystemCounter compare = default)
            where T : unmanaged
        {
            var last = default(Vector128<T>);
            var del = new BinaryOp128<T>(ginx.vadd);
            
            for(var i=0; i<OpCount; i++)
            {
                var a = Random.CpuVector<T>(n);
                var b = Random.CpuVector<T>(n);
                subject.Start();
                last = del(a,b);
                subject.Stop();

                var c = Random.CpuVector<T>(n);
                var d = Random.CpuVector<T>(n);
                compare.Start();
                last = ginx.vadd(c,d);
                compare.Stop();

            }

            Benchmark($"add{moniker<T>()}_del", subject);
            Benchmark($"add{moniker<T>()}", compare);
        }

    }

}


