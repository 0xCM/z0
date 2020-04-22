//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Seed;

    public interface ITestResultSink : IService, IRecordSink<TestCaseRecord>
    {
        void ReportCaseResult(string casename, bool succeeded, TimeSpan duration)
            => Deposit(TestCaseRecord.Define(casename,succeeded,duration));
    }
}