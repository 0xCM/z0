//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static Seed;

    public interface ITestResultSink : IService, IRecordSink<TestCaseRecord>
    {
        void ReportCaseResult(string casename, bool succeeded, TimeSpan duration)
            => Deposit(TestCaseRecord.Define(casename,succeeded,duration));
    }
    
    public interface ISpeedTestSink : IRecordSink<BenchmarkRecord>          
    {
        void ReportBenchmark(string name, long opcount, TimeSpan duration)
            => Deposit(BenchmarkRecord.Define(opcount, duration, name));
    }

    public interface ITestQueue : ITestResultSink, ISpeedTestSink, IAppMsgQueue
    {
        IEnumerable<BenchmarkRecord> TakeBenchmarks();

        IEnumerable<TestCaseRecord> TakeOutcomes();
    }
}
