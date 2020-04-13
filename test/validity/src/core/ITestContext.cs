//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;
    
    public interface ITestContext : IDisposable, IAppMsgSink, IPolyrandProvider, IAppContext, IService<ITestContext>
    {
        void ReportBenchmark(string name, long opcount, TimeSpan duration);        

        void ReportOutcome(string casename, bool succeeded, TimeSpan duration);

        string CaseName(ISFuncApi f);

        Type HostType {get;}

        bool Enabled {get;}

        void ReportOutcome(TestCaseOutcome outcome)
            => ReportOutcome(outcome.CaseName, outcome.Succeeded, outcome.Duration);
    }

    public interface IUnitTest : ITestContext 
    {

    }    

    public interface IExplicitTest : IUnitTest, IExecutable
    {
        
    }        

    public interface ITestControl : IAppMsgQueue
    {
        IEnumerable<BenchmarkRecord> TakeBenchmarks();

        IEnumerable<TestCaseRecord> TakeOutcomes();
    }        
}