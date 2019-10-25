//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    
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

        void vector_op128_bench<T>(bool lookup, SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"ops/vector128[{typename<T>()}]/lookup[{lookup}]";

            var x = Random.CpuVector128<T>();
            var y = Random.CpuVector128<T>();
            var result = default(Vector128<T>);
            var kinds = Cpu128OpApi.BinaryBitwiseKinds.ToArray();
            var opcount = 0;

            clock.Start();

            if(lookup)
            {
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< SampleSize; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                {
                    result = Cpu128OpApi.lookup<T>(kinds[k])(x, y);
                    y = x;
                    x = result;
                }
            }
            else
            {
                
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< SampleSize; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                {
                    result = Cpu128OpApi.eval(kinds[k],x, y);
                    y = x;
                    x = result;
                }

            }

            clock.Stop();

            Benchmark(opname, clock, opcount);
        }


        void vector_op256_bench<T>(bool lookup, SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"ops/vector256[{typename<T>()}]/lookup[{lookup}]";

            var x = Random.CpuVector256<T>();
            var y = Random.CpuVector256<T>();
            var result = default(Vector256<T>);
            var kinds = Cpu256OpApi.BinaryBitwiseKinds.ToArray();
            var opcount = 0;

            clock.Start();

            if(lookup)
            {
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< SampleSize; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                {
                    result = Cpu256OpApi.lookup<T>(kinds[k])(x, y);
                    y = x;
                    x = result;
                }
            }
            else
            {
                
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< SampleSize; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                {
                    result = Cpu256OpApi.eval(kinds[k],x, y);
                    y = x;
                    x = result;
                }

            }

            clock.Stop();

            Benchmark(opname, clock, opcount);
        }


    }

}