//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    partial class TestApp<A>
    {
        public void PostTestResults(IEnumerable<TestCaseRecord> outcomes)
            => TestResultQueue.Enqueue(outcomes);

        public void PostTestResult(TestCaseRecord outcome)
            => TestResultQueue.Enqueue(outcome);

        public void PostBenchResult(IEnumerable<BenchmarkRecord> outcomes)
            => BenchmarkQueue.Enqueue(outcomes);
    }
}