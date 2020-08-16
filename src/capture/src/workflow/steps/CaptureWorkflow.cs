//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
            
    using Z0.Asm;            
    public readonly struct CaptureWorkflow : IWfCaptureService
    {
        public ICaptureContext Context {get;}

        public IWfCaptureBroker Broker {get;}
        
        public CorrelationToken Ct {get;}
        
        public IWfContext Wf {get;}
        
        readonly IWfEventLog Log;
        
        [MethodImpl(Inline)]
        public CaptureWorkflow(IAsmContext asm, IWfContext wf, IAsmRoutineDecoder decoder, IAsmFormatter formatter, AsmWriterFactory writerfactory, IPartCaptureArchive archive, CorrelationToken ct)
        {
            Ct = ct;
            Wf = wf;
            Log = Flow.log(wf.Config);
            Broker = WfBuilder.capture(Log, Ct);
            Context = new CaptureContext(asm, decoder, formatter, writerfactory, Broker, archive, Ct);
            Wf.Created(nameof(CaptureWorkflow), Ct);
        }

        public void Dispose()
        {                            
            Wf.Finished(nameof(CaptureWorkflow), Ct);
            Broker.Dispose();
            Log.Dispose();
        }
    }
}