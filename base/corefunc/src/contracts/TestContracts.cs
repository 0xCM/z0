//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface ITestResultSink
    {
        TestCaseRecord ReportOutcome(string casename, bool succeeded, TimeSpan duration);
    }

    public interface IBenchResultSink
    {
        BenchmarkRecord ReportBenchmark(string name, long opcount, TimeSpan duration);        
    }

    public interface ITestResultSource
    {
        IEnumerable<TestCaseRecord> TakeOutcomes();
    }

    public interface IBenchResultSource
    {
        IEnumerable<BenchmarkRecord> TakeBenchmarks();
    }

    public interface ITestConfig<T> : ITestConfig, ISampleDefaults<T>
        where T : unmanaged
    {
        
    }

    public interface ITestContext : IContext, ITestResultSink, ITestResultSource, IBenchResultSink, IBenchResultSource
    {
        ITestConfig Config {get;}

        void Configure(ITestConfig config);

        bool Enabled {get;}

        string CaseName(IFunc f);

        string CaseName(string fullname);

        int RepCount {get;}

    }

    public interface IUnitTest : ITestContext
    {

        

    }


    public interface ITestConfig : ISampleDefaults
    {
        ITestConfig<T> Get<T>()
            where T : unmanaged;
        
        ITestConfig WithSampleSize(int SampleSize);

        ITestConfig WithTrace();

        ITestConfig WithoutTrace();

        ITestConfig Replicate();

        bool TraceEnabled {get;}
    }    
}