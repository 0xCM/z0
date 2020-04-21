//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    public interface ITestContext : 
        IServiceAllocation,
        IAppEnv,
        IStopClocks,
        IPolyrandProvider, 
        ICheckAction,
        ITestService,
        ITestQueue,
        ITestOptions, 
        ITestCaseIdentity, 
        IValidator         
    {
        
    }
}