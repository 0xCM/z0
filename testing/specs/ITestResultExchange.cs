//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    using static Root;

    public interface ITestResultSink : ISink<TestCaseRecord>
    {
        TestCaseRecord ReportOutcome(string casename, bool succeeded, TimeSpan duration);

        void ISink<TestCaseRecord>.Accept(in TestCaseRecord src)
            => ReportOutcome(src.Case, src.Status != 0, src.Duration);
    }

    public interface ITestResultSource
    {
        IEnumerable<TestCaseRecord> TakeOutcomes();
    }
}