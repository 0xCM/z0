//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    sealed class HostCaptureBroker : AppEventRelay, IHostCaptureWorkflowRelay
    {
        [MethodImpl(Inline)]
        public new static IHostCaptureWorkflowRelay Create()
            => new HostCaptureBroker();
    }

    public partial class HostCaptureWorkflow : IHostCaptureWorkflow
    {
        public IHostCaptureWorkflowRelay EventBroker {get;}

        public IHostCaptureRunner Runner {get;}
        
        [MethodImpl(Inline)]
        public static IHostCaptureWorkflow Create(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter,Func<FilePath, IAsmFormatter, IAsmFunctionWriter> writerfactory)
            => new HostCaptureWorkflow(context, decoder,formatter,writerfactory);      

        [MethodImpl(Inline)]
        HostCaptureWorkflow(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter,Func<FilePath, IAsmFormatter, IAsmFunctionWriter> writerfactory)
        {
            this.EventBroker = HostCaptureBroker.Create();
            this.Runner = new HostCaptureRunner(context,EventBroker,decoder,formatter,writerfactory);
        }
 
        public void Run(AsmWorkflowConfig dst) => Runner.Run(dst);
    }
}