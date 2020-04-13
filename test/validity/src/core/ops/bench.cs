//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Seed;

    partial class TestContext<U>
    {
        protected void bench<T>(UnaryOp<T> f, UnaryOp<T> cf, string opname,  SystemCounter clock = default)
            where T :unmanaged
        {
            const int SampleSize = 256;
            var last = default(T);
            
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

                ReportBenchmark(SubjectId<T>(opname),oc,clock);

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

                ReportBenchmark(BaselineId<T>(opname),oc,clock);            
            }

            run_cf();            
            
            clock.Reset();
            
            run_f();
        }

        protected void bench<T>(BinaryOp<T> cf, BinaryOp<T> f, string opname, SystemCounter clock = default)
            where T :unmanaged
        {
            const int SampleSize = 256;
            var last = default(T);
            
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

                ReportBenchmark(SubjectId<T>(opname),oc,clock);
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

                ReportBenchmark(BaselineId<T>(opname),oc,clock);            
            }

            run_cf();            
            
            clock.Reset();
            
            run_f();
        }
    }
}