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
        TClocked,
        IPolyrandProvider, 
        TCheckAction,
        ITestService,
        ITestQueue,
        TCheckOptions, 
        TTestCaseIdentity, 
        TValidator,
        IAppMsgContext        
    {
        
    }

    public interface ITestContext<U> : ITestContext
        where U : ITestContext<U>
    {
        Type TValidator.HostType => typeof(U);
    }
}