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
        ITestValidator,
        ISpeedTest, 
        IStopClocks,
        ISpeedTestSink,
        IPolyrandProvider, 
        ICheckAction,
        IAppMsgContext, 
        IService<ITestContext>, 
        ITestResultSink, 
        IAppMsgTrace,
        ITestQueueControl,
        IConsoleNotifier
    {
        
    }
}