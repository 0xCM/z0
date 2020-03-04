//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

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