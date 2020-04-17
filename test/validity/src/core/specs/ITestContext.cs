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
        ISpeedTest, 
        IPolyrandProvider, 
        IActionValidator,
        IAppMsgContext, 
        IService<ITestContext>, 
        IEvaluationSink, 
        IAppMsgTrace,
        ITestQueueControl,
        IConsoleNotifier          
    {
        string CaseName(ISFuncApi f);

        Type HostType {get;}

        bool Enabled {get;}
    }
}