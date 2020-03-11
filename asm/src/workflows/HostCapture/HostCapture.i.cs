//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    
    using static Root;
    
    public interface IHostCaptureRunner : IAsmWorkflowRunner<HostCaptureConfig, IHostCaptureEventBroker>
    {

    }

    public interface IHostCaptureWorkflow : IAsmWorkflow
    {

        IHostCaptureRunner Runner {get;}

        IHostCaptureEventBroker Broker {get;}        

    }
}