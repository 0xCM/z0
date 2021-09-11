//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Root;

    public readonly struct TestResultSink : ISink<TestCaseRecord>
    {
        public void Deposit(TestCaseRecord src)
            => term.print(TestCaseRecords.format(src));
    }

    public interface ITestResultSink : ISink<TestCaseRecord>
    {
        void ReportCaseResult(string casename, bool succeeded, TimeSpan duration)
            => Deposit(TestCaseRecord.define(casename, succeeded, duration));

        void ISink<TestCaseRecord>.Deposit(TestCaseRecord src)
            => term.print(TestCaseRecords.format(src));
    }
}