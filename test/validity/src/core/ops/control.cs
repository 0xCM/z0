//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Seed;

    partial class TestContext<U>
    {
        public void ReportOutcome(string casename, bool succeeded, TimeSpan duration)
        {
            var record = TestCaseRecord.Define(casename,succeeded,duration);
            Outcomes.Enqueue(record);
        }

        public void ReportBenchmark(string name, long opcount, TimeSpan duration)
        {
            var record = BenchmarkRecord.Define(opcount, duration, name);
            Benchmarks.Enqueue(record);
        }

        public void ReportBenchmark(BenchmarkRecord record)
            => Benchmarks.Enqueue(record);

        public IEnumerable<TestCaseRecord> TakeOutcomes()
        {
            while(Outcomes.Any())
                yield return Outcomes.Dequeue();
        }

        public IEnumerable<BenchmarkRecord> TakeBenchmarks()
        {
            while(Benchmarks.Any())
                yield return Benchmarks.Dequeue();
        }
    }
}