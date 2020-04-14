//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    public interface ITestContext : 
        ISpeedTest, 
        IPolyrandProvider, 
        IActionValidator,
        IAppContext, 
        IService<ITestContext>, 
        IEvaluationSink, 
        IDisposable,
        ITracer,
        ITestQueueControl,
        IConsoleNotifier          
    {
        string CaseName(ISFuncApi f);

        Type HostType {get;}

        bool Enabled {get;}
    }
}