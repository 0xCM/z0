//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    
    public class t_extrema: UnitTest<t_extrema>
    {

        public void minval()
        {
            var samplesize = Pow2.T14;

            var s1Range = Interval.closed(350.0, 1000.0);
            var s1 = Random.Array<double>(samplesize, s1Range);
            var s1Max = Dataset.Load(s1).Max()[0];
            Claim.neq(s1Max,0.0);

            var zeroCount = s1.Count(x => x == 0);
            Notify($"Found {zeroCount} zeroes");
        }

        public void sumvals()
        {
            var src = Random.Stream<double>().Take(16000).ToArray();
            var expect = src.Sum().Round(4);
            var actual = Dataset.Load(src).Sum()[0].Round(4);
            Claim.yea(gmath.within(expect,actual,.01));
        }

        public void mean_bench()
        {
            run_mean_bench();
            run_mean_bench();
        }

        void run_mean_bench()
        {
            var cycles = Pow2.T12;
            var samples = Pow2.T14;
            var src = Random.Span<long>(samples, Interval.closed(-2000L, 2000L)).Convert<double>();
            var ds = Dataset.Load(src);
            var dst = 0.0;
            var last = 0.0;

            var sw1 = stopwatch();
            for(var i=0; i<cycles; i++)
                last = ds.Mean(ref dst);
            sw1.Stop();

            var sw2 = stopwatch();
            for(var i=0; i<cycles; i++)
                last = src.Avg();     
            sw2.Stop();

            ReportBenchmark("mkl-ssmean", cycles*samples, sw1.Elapsed);
            ReportBenchmark("direct", cycles*samples, sw2.Elapsed);

        }
        
        public void mean()
        {
            var src = Random.Span<long>(Pow2.T14, Interval.closed(-2000L, 2000L));
            var expect = gspan.avg(src);
            var converted = Cast.to<long,double>(src);
            var actual = (long)Dataset.Load(converted).Mean()[0];
            Claim.eq(expect,actual);
        }
    }
}