//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    partial class TestApp<A>
    {
        TestCaseRecord[] SortResults()
        {
            var results = TestResultQueue.OrderBy(x => x.CaseName).Where(x => !x.Passed).Concat(TestResultQueue.Where(x => x.Passed)).Array();
            TestResultQueue.Clear();
            return results;
        }

        BenchmarkRecord[] SortBenchmarks()
        {
            var records = BenchmarkQueue.ToArray();
            BenchmarkQueue.Clear();
            Array.Sort(records);
            return records;
        }
    }
}