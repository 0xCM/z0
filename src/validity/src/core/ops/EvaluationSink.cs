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
        public void Deposit(BenchmarkRecord record)
            => Benchmarks.Enqueue(record);

        public void Deposit(IAppMsg msg)
            => Messages.Deposit(msg);

        public void Deposit(TestCaseRecord result)
            => TestResults.Enqueue(result);
            
        // public void ReportCaseResult(string casename, bool succeeded, TimeSpan duration)
        //     => Deposit(TestCaseRecord.Define(casename,succeeded,duration));

        // public void ReportBenchmark(string name, long opcount, TimeSpan duration)
        //     => Deposit(BenchmarkRecord.Define(opcount, duration, name));
    }
}