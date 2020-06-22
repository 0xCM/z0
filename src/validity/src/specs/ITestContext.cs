//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;

    public interface IUnitTest : ITestContext 
    {
    }    

    public interface IExplicitTest : IUnitTest, IExecutable
    {
        
    }        
    
    public interface ITestContext : 
        IServiceAllocation,
        TAppEnv,
        IClocked,
        IPolyrandProvider, 
        ICheckAction,
        ITestService,
        ITestQueue,
        ICheckOptions, 
        ITestCaseIdentity, 
        IValidator,
        IAppMsgContext        
    {
        
    }

    public interface ITestContext<U> : ITestContext
        where U : ITestContext<U>
    {
        Type IValidator.HostType => typeof(U);
    }
}