//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Collections.Concurrent;

    using static Konst;

    partial class TestApp<A>
    {

        void PostTestResults(IEnumerable<TestCaseRecord> outcomes)
            => TestResultQueue.Enqueue(outcomes);

        void PostTestResult(TestCaseRecord outcome)
            => TestResultQueue.Enqueue(outcome);

        void PostBenchResult(IEnumerable<BenchmarkRecord> outcomes)
            => BenchmarkQueue.Enqueue(outcomes);
    }
}