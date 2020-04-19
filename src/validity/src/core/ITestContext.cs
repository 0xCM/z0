//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    public interface ISpeedTestSink : IRecordSink<BenchmarkRecord>          
    {
        void ReportBenchmark(string name, long opcount, TimeSpan duration)
            => Deposit(BenchmarkRecord.Define(opcount, duration, name));
    }

    public interface ITestQueue : ITestResultSink, ISpeedTestSink, IAppMsgQueue
    {
        IEnumerable<BenchmarkRecord> TakeBenchmarks();

        IEnumerable<TestCaseRecord> TakeOutcomes();
    }
    
    public interface IExplicitTest : IUnitTest, IExecutable
    {
        
    }        

    public interface IUnitTest : ITestContext 
    {
    }    

    public interface ITestContext : 
        IServiceAllocation,
        IStopClocks,
        IPolyrandProvider, 
        ICheckAction,
        IService<ITestContext>,         
        ITestQueue,
        ITestOptions, 
        ITestCaseIdentity, 
        IValidator, 
        IPolyrandContext        
    {
        ICheckNumeric Numeric => ICheckNumeric.Checker;

        ICheckEquatable Equatable => ICheckEquatable.Checker;
    }
}