//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;
    
    public partial class HostCaptureWorkflow : IHostCaptureWorkflow
    {
        public IAsmContext Context {get;}

        public IHostCaptureEventBroker EventBroker {get;}

        public IHostCaptureRunner Runner {get;}
        
        [MethodImpl(Inline)]
        public static IHostCaptureWorkflow Create(IAsmContext context)
            => new HostCaptureWorkflow(context);      

        [MethodImpl(Inline)]
        HostCaptureWorkflow(IAsmContext context)
        {
            this.Context = context;
            this.EventBroker = HostCaptureBroker.Create(context);
            this.Runner = new HostCaptureRunner(context,EventBroker);
        }
 
        public void Run(HostCaptureConfig dst) => Runner.Run(dst);
    }
}