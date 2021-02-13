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

    public interface ITestApp
    {
        void EmitLogs();

        Type[] FindHosts();

        MethodInfo[] FindTests(Type host);

        Duration RunCase(IUnitTest unit, MethodInfo method, List<TestCaseRecord> cases);

        TestCaseRecord[] SortResults();

        BenchmarkRecord[] SortBenchmarks();

        void RunUnit(Type host, IUnitTest unit);

        Index<Type> SelectedHosts {get;}
    }
}