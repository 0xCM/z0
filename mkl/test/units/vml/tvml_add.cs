//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl.Test
{
    using System;
    using System.Linq;

    public class tvml_add : t_mkl<tvml_add>
    {

        public void vaddF32()
        {
            var lhs = RVec<float>();
            var rhs = RVec<float>();
            var dst1 = RowVector.blockalloc<float>(lhs.Length);
            mkl.add(lhs,rhs, ref dst1);
            
            var dst2 = lhs.Replicate();
            gspan.add(lhs,rhs, dst2.Unblocked);
            Claim.require(dst1 == dst2);
        }

        public void vaddF64()
        {
            var lhs = RVec<double>();
            var rhs = RVec<double>();
            var dst1 = RowVector.blockalloc<double>(lhs.Length);
            mkl.add(lhs,rhs,ref dst1);
            
            var dst2 = lhs.Replicate();
            gspan.add(lhs, rhs, dst2.Unblocked);
            Claim.require(dst1 == dst2);
        }


        BenchMarkedPair vaddF32Perf(int samples, long cycles)
        {
            var lhs1 = RVec<float>(samples);
            var rhs1 = RVec<float>(samples);
            var dst1 = RowVector.blockalloc<float>(samples);

            var lhs2 = lhs1.Replicate();
            var rhs2 = rhs1.Replicate();
            var dst2 = dst1.Replicate();

            var sw1 = stopwatch();
            for(var i=0; i<cycles; i++)
                gspan.add(lhs1,rhs1, dst1.Unblocked);
            var time1 = BenchmarkRecord.Define(cycles, snapshot(sw1), "gmath");


            var sw2 = stopwatch();
            for(var i=0; i<cycles; i++)
                mkl.add(lhs2, rhs2, ref dst2);
            var time2 = BenchmarkRecord.Define(cycles, snapshot(sw2), "mkl");
            
            return (time1,time2);
            
        }

        BenchMarkedPair vaddF64Perf(int samples, long cycles)
        {
            var lhs1 = RVec<double>(samples);
            var rhs1 = RVec<double>(samples);
            var dst1 = RowVector.blockalloc<double>(samples);


            var sw1 = stopwatch();
            for(var i=0; i<cycles; i++)
                gspan.add(lhs1,rhs1,dst1.Unblocked);
            var time1 = BenchmarkRecord.Define(cycles, snapshot(sw1), "gmath");


            var lhs2 = lhs1.Replicate();
            var rhs2 = rhs1.Replicate();
            var dst2 = dst1.Replicate();

            var sw2 = stopwatch();
            for(var i=0; i<cycles; i++)
                mkl.add(lhs2, rhs2,ref dst2);
            var time2 = BenchmarkRecord.Define(cycles, snapshot(sw2), "mkl");
            
            return (time1,time2);
        }

        public void vAddF64Perf()
        {
            var n = Pow2.T08;
            var i = Pow2.T12;
            TracePerf(vaddF64Perf(n, i).Format());
            TracePerf(vaddF32Perf(n, i).Format());
            
        }

    }

}
