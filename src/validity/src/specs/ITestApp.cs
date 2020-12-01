//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;

    using static Konst;

    public interface ITestApp
    {
        void EmitLogs();

        Type[] FindHosts();

        MethodInfo[] FindTests(Type host);

        void PostTestResults(IEnumerable<TestCaseRecord> outcomes);

        void PostBenchResult(IEnumerable<BenchmarkRecord> outcomes);

        Duration RunCase(IUnitTest unit, MethodInfo method, IList<TestCaseRecord> cases);

        TestCaseRecord[] SortResults();

        BenchmarkRecord[] SortBenchmarks();

        void RunUnit(Type host, IUnitTest unit);
    }
}