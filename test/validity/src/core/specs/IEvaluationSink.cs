//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    public interface IEvaluationSink : IService
    {
        void ReportBenchmark(string name, long opcount, TimeSpan duration);        

        void ReportOutcome(string casename, bool succeeded, TimeSpan duration);

        void ReportOutcome(TestCaseOutcome outcome)
            => ReportOutcome(outcome.CaseName, outcome.Succeeded, outcome.Duration);
    }
}