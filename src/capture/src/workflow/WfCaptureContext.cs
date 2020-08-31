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

    public readonly struct WfCaptureContext : IWfCaptureContext
    {
        public ICaptureContext Context {get;}

        public IWfCaptureBroker Broker {get;}

        public CorrelationToken Ct {get;}

        public IWfContext Wf {get;}

        readonly IWfEventLog Log;

        [MethodImpl(Inline)]
        public WfCaptureContext(IAsmContext asm, IWfContext wf, IAsmDecoder decoder, IAsmFormatter formatter, AsmTextWriterFactory writerfactory, IPartCapturePaths archive, CorrelationToken ct)
        {
            Ct = ct;
            Wf = wf;
            Log = AB.termlog(wf.Config);
            Broker = AsmWfBuilder.capture(Log, Ct);
            Context = new CaptureContext(asm.ContextRoot, decoder, formatter, writerfactory, Broker, Ct);
            Wf.Created(nameof(WfCaptureContext), Ct);
        }

        public void Dispose()
        {
            Wf.Finished(nameof(WfCaptureContext), Ct);
            Broker.Dispose();
            Log.Dispose();
        }
    }
}