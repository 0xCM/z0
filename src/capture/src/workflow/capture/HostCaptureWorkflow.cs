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
        public static IHostCaptureBroker Create()
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
            var factory = context.Factory;
            this.EventBroker = HostCaptureBroker.Create();
            this.Context = new CaptureWorkflowContext(
                context, 
                context.ApiSet, 
                decoder, 
                formatter, 
                writerfactory, 
                AsmStatelessCore.Factory.HostExtractor(),
                StatelessExtract.Factory.ExtractParser(), 
                EventBroker);
        }
 
        public void Run(AsmWorkflowConfig config) 
        {
            DriveCatalogCapture.Create(Context).CaptureCatalogs(config);
        }
    }
}