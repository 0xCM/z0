//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IHostCaptureWorkflow : IService
    {
        IHostCaptureRunner Runner {get;}

        IHostCaptureWorkflowRelay EventBroker {get;}
    }
}