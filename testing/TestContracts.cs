//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface ITestResultSink
    {
        TestCaseRecord ReportOutcome(string opname, bool succeeded, TimeSpan duration);
    }

    public interface ITestResultSource
    {
        IEnumerable<TestCaseRecord> TakeOutcomes();
    }

    public interface ITestConfig<T> : ITestConfig, ISampleDefaults<T>
        where T : unmanaged
    {
        
    }

    public interface ITestContext : IContext, ITestResultSink, ITestResultSource
    {
        ITestConfig Config {get;}

        void Configure(ITestConfig config);

        IEnumerable<BenchmarkRecord> Benchmarks {get;}        

        bool Enabled {get;}
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