//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    
    public class t_vector_ops : UnitTest<t_vector_ops>
    {
        protected override int CycleCount => Pow2.T08;

        public void vector_op128_bench()
        {
            vector_op128_bench<uint>(true);
            vector_op128_bench<uint>(false);
        }

        public void vector_op256_bench()
        {
            vector_op256_bench<uint>(true);
            vector_op256_bench<uint>(false);
        }

        protected void vector_op128_bench<T>(bool lookup, N128 n = default, SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"ops/vector128[{typename<T>()}]/lookup[{lookup}]";

            var x = Random.CpuVector<T>(n);
            var y = Random.CpuVector<T>(n);
            var result = default(Vector128<T>);
            var kinds = CpuOpApi.BinaryBitwiseKinds.ToArray();
            var opcount = 0;

            clock.Start();

            if(lookup)
            {
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< SampleCount; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                {
                    result = CpuOpApi.lookup<T>(n128,kinds[k])(x, y);
                    y = x;
                    x = result;
                }
            }
            else
            {                
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< SampleCount; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                {
                    result = CpuOpApi.eval(kinds[k],x, y);
                    y = x;
                    x = result;
                }
            }

            clock.Stop();

            Benchmark(opname, clock, opcount);
        }

        protected void vector_op256_bench<T>(bool lookup, N256 n = default, SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"ops/vector256[{typename<T>()}]/lookup[{lookup}]";

            var x = Random.CpuVector<T>(n);
            var y = Random.CpuVector<T>(n);
            var result = default(Vector256<T>);
            var kinds = CpuOpApi.BinaryBitwiseKinds.ToArray();
            var opcount = 0;

            clock.Start();

            if(lookup)
            {
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< SampleCount; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                {
                    result = CpuOpApi.lookup<T>(n256,kinds[k])(x, y);
                    y = x;
                    x = result;
                }
            }
            else
            {
                
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< SampleCount; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                {
                    result = CpuOpApi.eval(kinds[k],x, y);
                    y = x;
                    x = result;
                }

            }

            clock.Stop();

            Benchmark(opname, clock, opcount);
        }
    }

}