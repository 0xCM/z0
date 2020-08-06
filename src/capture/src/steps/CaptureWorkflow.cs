//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
            
    public readonly struct CaptureWorkflow : ICaptureWorkflow
    {
        public ICaptureContext Context {get;}

        public ICaptureBroker Broker {get;}
        
        public CorrelationToken Ct {get;}
        
        public WfContext Wf {get;}
        
        [MethodImpl(Inline)]
        public CaptureWorkflow(IAsmContext asm, WfContext wf, 
            IAsmFunctionDecoder decoder, IAsmFormatter formatter, AsmWriterFactory writerfactory, IPartCaptureArchive archive, CorrelationToken ct)
        {
            Ct = ct;
            Wf = wf;
            Broker = WfBuilder.capture(asm.AppPaths.AppCaptureRoot + FileName.Define("workflow", FileExtensions.Csv), Ct);
            Context = new CaptureContext(asm, decoder, formatter, writerfactory, Broker, archive, Ct);
            Wf.Created(nameof(CaptureWorkflow), Ct);
        }

        public void Dispose()
        {                            
            Wf.Finished(nameof(CaptureWorkflow), Ct);
            Broker.Dispose();
        }
    }
}