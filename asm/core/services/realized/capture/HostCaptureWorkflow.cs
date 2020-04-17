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
    
    static partial class HostCaptureSteps
    {


    }    
    
    sealed class HostCaptureBroker : EventBroker, IHostCaptureBroker
    {
        [MethodImpl(Inline)]
        public new static IHostCaptureBroker Create()
            => new HostCaptureBroker();
    }

    public class HostCaptureWorkflow : IHostCaptureWorkflow
    {
        readonly CaptureWorkflowContext Context;

        public IHostCaptureBroker EventBroker {get;}
        
        [MethodImpl(Inline)]
        public static IHostCaptureWorkflow Create(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory writerfactory)
            => new HostCaptureWorkflow(context, decoder, formatter, writerfactory);      

        [MethodImpl(Inline)]
        HostCaptureWorkflow(IAsmContext context, IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory writerfactory)
        {
            this.EventBroker = HostCaptureBroker.Create();
            this.Context = new CaptureWorkflowContext(context,context.ApiSet, decoder, formatter, writerfactory, context.HostExtractor(), context.ExtractParser(), EventBroker);
        }
 
        public void Run(AsmWorkflowConfig config) 
        {
            DriveCatalogCapture.Create(Context).CaptureCatalogs(config);
        }
    }
}