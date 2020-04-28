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
        
    public readonly struct HostCaptureWorkflow : IHostCaptureWorkflow
    {
        readonly CaptureWorkflowContext Context;

        public IHostCaptureBroker EventBroker {get;}
        
        [MethodImpl(Inline)]
        internal HostCaptureWorkflow(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory writerfactory)
        {
            EventBroker = HostCaptureBroker.New;
            Context = new CaptureWorkflowContext(
                context, 
                context.ApiSet, 
                decoder, 
                formatter, 
                writerfactory, 
                AsmWorkflows.Stateless.HostExtractor(),
                Extract.Services.ExtractParser(), 
                EventBroker);
        }
 
        public void Run(AsmWorkflowConfig config, params PartId[] parts) 
        {
            var step = new CaptureCatalogStep(Context);
            step.CaptureCatalogs(config, parts);
        }
    }
}