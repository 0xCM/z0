//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static HostCaptureSteps;
    
    sealed class HostCaptureBroker : AppEventRelay, IHostCaptureWorkflowRelay
    {
        [MethodImpl(Inline)]
        public new static IHostCaptureWorkflowRelay Create()
            => new HostCaptureBroker();
    }

    public partial class HostCaptureWorkflow : IHostCaptureWorkflow
    {
        readonly HostCaptureContext Context;

        public IHostCaptureWorkflowRelay EventBroker {get;}
        
        [MethodImpl(Inline)]
        public static IHostCaptureWorkflow Create(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory writerfactory)
            => new HostCaptureWorkflow(context, decoder, formatter, writerfactory);      

        [MethodImpl(Inline)]
        HostCaptureWorkflow(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory writerfactory)
        {
            this.EventBroker = HostCaptureBroker.Create();
            this.Context = new HostCaptureContext(context,context.ApiSet, decoder, formatter, writerfactory, context.HostExtractor(), context.ExtractParser(), EventBroker);
        }
 
        public void Run(AsmWorkflowConfig config) 
        {
            DriveCatalogCapture.Create(Context).CaptureCatalogs(config);
        }
    }
}