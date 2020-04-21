//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    public interface ITestQueue : ITestResultSink, IAppMsgQueue, IRecordSink<BenchmarkRecord>
    {
        IEnumerable<BenchmarkRecord> TakeBenchmarks();

        IEnumerable<TestCaseRecord> TakeOutcomes();

        void ReportBenchmark(string name, long opcount, TimeSpan duration)
            => Deposit(BenchmarkRecord.Define(opcount, duration, name));

    }
}