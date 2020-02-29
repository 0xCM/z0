//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface ITestContext : IRngContext, IMsgContext, ITestResultSink, ITestResultSource, IBenchResultSink, IBenchResultSource
    {
        ITestConfig Config {get;}

        void Configure(ITestConfig config);

        bool Enabled {get;}

        string CaseName(IFunc f);

        string CaseName(string fullname);

        int RepCount {get;}
    }

    public interface ITestContext<C> : ITestContext
        where C : ITestContext<C>
    {

    }

    public interface IUnitTest : ITestContext
    {

    }    

    public interface IExplicitTest : IUnitTest, IExecutable
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


    public interface ITestConfig<T> : ITestConfig, ISampleDefaults<T>
        where T : unmanaged
    {
        
    }    
}