//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Seed;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    partial class TestContext<U>
    {
        /// <summary>
        /// Captures a duration and the number of operations executed within the period
        /// </summary>
        /// <param name="time">The running time</param>
        /// <param name="opcount">The operation count</param>
        /// <param name="label">The label associated with the measure, if specified</param>
        protected static BenchmarkRecord measured(long opcount, Duration time, [Caller] string label = null)
            => BenchmarkRecord.Define(opcount, time, label);

        public void Measure<T>(UnaryOp<T> f, UnaryOp<T> cf, string opname)
            where T :unmanaged
        {
            const int SampleSize = 256;
            var last = default(T);
            var clock = counter();
            
            void run_f()
            {
                var src = Random.Span<T>(SampleSize);
                byte j = 0;
                var oc = 0;

                clock.Start();
                for(var cycle = 0; cycle < CycleCount; cycle++)
                for(int rep=0; rep < RepCount; rep++, j++, oc++)
                {
                    ref readonly var x = ref refs.skip(src,j);
                    last = f(x);
                }
                clock.Stop();

                Context.ReportBenchmark(SubjectId<T>(opname),oc,clock);

            }

            void run_cf()
            {
                var src = Random.Span<T>(SampleSize);
                byte j = 0;
                var oc = 0;

                clock.Start();
                for(var cycle = 0; cycle < CycleCount; cycle++)
                for(int rep=0; rep < RepCount; rep++, j++, oc++)
                {
                    ref readonly var x = ref refs.skip(src,j);
                    last = cf(x);
                }            
                clock.Stop();

                Context.ReportBenchmark(BaselineId<T>(opname),oc,clock);            
            }

            run_cf();            
            
            clock.Reset();
            
            run_f();
        }

        public void Measure<T>(BinaryOp<T> cf, BinaryOp<T> f, string opname)
            where T :unmanaged
        {
            const int SampleSize = 256;
            var last = default(T);
            var clock = counter();
            void run_f()
            {
                var lhs = Random.Span<T>(SampleSize);
                var rhs = Random.Span<T>(SampleSize);
                byte j = 0;
                var oc = 0;

                clock.Start();
                for(var cycle = 0; cycle < CycleCount; cycle++)
                for(int rep=0; rep < RepCount; rep++, j++, oc++)
                {
                    ref readonly var x = ref refs.skip(lhs,j);
                    ref readonly var y = ref refs.skip(rhs,j);                
                    last = f(x,y);
                }
                clock.Stop();

                Context.ReportBenchmark(SubjectId<T>(opname),oc,clock);
            }

            void run_cf()
            {
                var lhs = Random.Span<T>(SampleSize);
                var rhs = Random.Span<T>(SampleSize);
                byte j = 0;
                var oc = 0;

                clock.Start();
                for(var cycle = 0; cycle < CycleCount; cycle++)
                for(int rep=0; rep < RepCount; rep++, j++, oc++)
                {
                    ref readonly var x = ref refs.skip(lhs,j);
                    ref readonly var y = ref refs.skip(rhs,j);                
                    last = cf(x,y);
                }            
                clock.Stop();

                Context.ReportBenchmark(BaselineId<T>(opname),oc,clock);            
            }

            run_cf();            
            
            clock.Reset();
            
            run_f();
        }
    }
}