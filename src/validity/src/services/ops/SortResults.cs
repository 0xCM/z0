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
            static TestCaseRecord[] Sort(IEnumerable<TestCaseRecord> src)
                => src.OrderBy(x => x.Case).Where(x => x.Status == 0).Concat(src.Where(x => x.Status != 0)).ToArray();

            var results = Sort(TestResultQueue);
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