//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    
    using System;
    using System.Collections.Generic;

    public interface ITestContext : IDisposable, IPolyrandContext, IAppMsgContext
    {
        BenchmarkRecord ReportBenchmark(string name, long opcount, TimeSpan duration);        

        IEnumerable<BenchmarkRecord> TakeBenchmarks();

        ITestConfig Config {get;}

        void Configure(ITestConfig config);

        bool Enabled {get;}

        string CaseName(IFunc f);

        string CaseName(string fullname);

        int RepCount {get;}

        IEnumerable<TestCaseRecord> TakeOutcomes();

        TestCaseRecord ReportOutcome(string casename, bool succeeded, TimeSpan duration);

    }

    public interface IExternalTestContext : IPolyrandContext, IAppMsgContext
    {

    }

    public interface ITestContext<C> : ITestContext
    {

    }
}