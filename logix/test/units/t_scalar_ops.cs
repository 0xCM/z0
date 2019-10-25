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
    

    public class t_scalar_ops : UnitTest<t_scalar_ops>
    {
        protected override int CycleCount => Pow2.T08;

        public void scalar_op_bench()
        {
            scalar_op_bench<uint>(true);
            scalar_op_bench<uint>(false);
        }

        void scalar_op_bench<T>(bool lookup, SystemCounter clock = default)
            where T : unmanaged
        {
            var opname = $"ops/scalar[{typename<T>()}]/lookup[{lookup}]";

            var lhsSamples = Random.Array<T>(SampleSize);
            var rhsSamples = Random.Array<T>(SampleSize);
            var result = default(T);
            var kinds = ScalarOpApi.BinaryBitwiseKinds.ToArray();
            var opcount = 0;

            clock.Start();

            if(lookup)
            {
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< SampleSize; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                    result = ScalarOpApi.lookup<T>(kinds[k])(lhsSamples[sample], rhsSamples[sample]);
            }
            else
            {
                for(var i=0; i<CycleCount; i++)
                for(var sample=0; sample< SampleSize; sample++)
                for(var k=0; k< kinds.Length; k++, opcount++)
                    result = ScalarOpApi.eval(kinds[k],lhsSamples[sample], rhsSamples[sample]);
            }

            clock.Stop();

            Benchmark(opname, clock, opcount);
        }


    }

}