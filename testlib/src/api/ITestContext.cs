//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    public readonly struct TestCaseOutcome
    {
        public static TestCaseOutcome Define(string name, bool succeeded, TimeSpan duration)
            => new TestCaseOutcome(name, succeeded, duration);

        TestCaseOutcome(string name, bool succeeded, TimeSpan duration)
        {
            this.CaseName = name;
            this.Succeeded = succeeded;
            this.Duration = duration;
        }

        public string CaseName {get;}

        public bool Succeeded {get;}

        public TimeSpan Duration {get;}
    }
    
    public interface ITestContext : IDisposable, IAppMsgSink, IPolyrandProvider, IAppContext
    {
        void ReportBenchmark(string name, long opcount, TimeSpan duration);        

        void ReportOutcome(string casename, bool succeeded, TimeSpan duration);

        string CaseName(ISFuncApi f);

        Type HostType {get;}

        void ReportOutcome(TestCaseOutcome outcome)
            => ReportOutcome(outcome.CaseName, outcome.Succeeded, outcome.Duration);
    }

    public interface IUnitTest : IDisposable, ITestContext, IService<ITestContext>
    {
        bool Enabled {get;}

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