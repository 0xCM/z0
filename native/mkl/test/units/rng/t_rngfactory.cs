//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Mkl;

    public class t_rngfactory : UnitTest<t_rngfactory>
    {
        const uint Seed = 0x78941u;

        const double MinF64 = -350000;

        const double MaxF64 = 350000;

        const float MinF32 = -350000;

        const float MaxF32 = 350000;

        const int MinI32 = -350000;

        const int MaxI32 = 350000;

        static readonly Interval<int> RangeI32 = (MinI32, MaxI32);

        static readonly Interval<float> RangeF32 = (MinF32, MaxF32);

        static readonly Interval<double> RangeF64 = (MinF64, MaxF64);

        public void mcg31()
        {
            using var src = rng.mcg31(Seed);
            rng_bench(samplers.uniform(src, (RangeI32)));
            rng_bench(samplers.uniform(src, (RangeF32)));
            rng_bench(samplers.uniform(src, (RangeF64)));
        }

        public void mrg32K31()
        {
            using var src = rng.mrg32K31(Seed);
            rng_bench(samplers.uniform(src, (RangeI32)));
            rng_bench(samplers.uniform(src, (RangeF32)));
            rng_bench(samplers.uniform(src, (RangeF64)));
        }

        public void mcg59()
        {
            using var src = rng.mcg31(Seed);
            rng_bench(samplers.uniform(src, (RangeI32)));
            rng_bench(samplers.uniform(src, (RangeF32)));
            rng_bench(samplers.uniform(src, (RangeF64)));
        }

        public void r250()
        {
            using var src = rng.r250(Seed);
            rng_bench(samplers.uniform(src, (RangeI32)));
            rng_bench(samplers.uniform(src, (RangeF32)));
            rng_bench(samplers.uniform(src, (RangeF64)));
        }

        public void mt19937()
        {
            using var src = rng.mt19937(Seed);
            rng_bench(samplers.uniform(src, (RangeI32)));
            rng_bench(samplers.uniform(src, (RangeF32)));
            rng_bench(samplers.uniform(src, (RangeF64)));
        }

        public void sfmt19937()
        {
            using var src = rng.sfmt19937(Seed);
            rng_bench(samplers.uniform(src, (RangeI32)));
            rng_bench(samplers.uniform(src, (RangeF32)));
            rng_bench(samplers.uniform(src, (RangeF64)));
        }

        public void mt2203()
        {
            using var src = rng.mt2203(Seed);
            rng_bench(samplers.uniform(src, (RangeI32)));
            rng_bench(samplers.uniform(src, (RangeF32)));
            rng_bench(samplers.uniform(src, (RangeF64)));
        }

        public void philox()
        {
            using var src = rng.philox(Seed);
            rng_bench(samplers.uniform(src, (RangeI32)));
            rng_bench(samplers.uniform(src, (RangeF32)));
            rng_bench(samplers.uniform(src, (RangeF64)));
        }

        public void polyrand()
        {
            rng_bench(Rng.pcg64(Seed).Stream(RangeI32));
            rng_bench(Rng.pcg64(Seed).Stream(RangeF32));
            rng_bench(Rng.pcg64(Seed).Stream(RangeF64));
        }

        public void wh()
        {
            using var src = rng.wh(Seed);
            rng_bench(samplers.uniform(src, (RangeI32)));
            rng_bench(samplers.uniform(src, (RangeF32)));
            rng_bench(samplers.uniform(src, (RangeF64)));
        }

        public void ars5()
        {
            using var src = rng.ars5(Seed);
            rng_bench(samplers.uniform(src, (RangeI32)));
            rng_bench(samplers.uniform(src, (RangeF32)));
            rng_bench(samplers.uniform(src, (RangeF64)));
        }

        public void sobol()
        {
            using var src = rng.sobol(Seed);
            rng_bench(samplers.uniform(src, (RangeI32)));
            rng_bench(samplers.uniform(src, (RangeF32)));
            rng_bench(samplers.uniform(src, (RangeF64)));
        }

        void rng_bench<T>(IDataStream<T> stream, [CallerMemberName] string caller = null)
            where T : unmanaged
        {
            var segment = Pow2.T08;
            var total = Pow2.T17;
            var stats = StatCollector.Create(0.0);
            var sw = stopwatch(false);
            for(var i=0; i< total; i+= segment)
            {
                sw.Start();
                var sample = stream.TakeArray(segment);
                sw.Stop();
                for(var j=0; j< segment; j++)
                    stats.Collect(Numeric.force<T,double>(sample[j]));
            }

            var opname = $"{caller}<{typeof(T).DisplayName()}>";
            Deposit(BenchmarkRecord.Define(total, sw.Elapsed, opname));
        }
    }
}