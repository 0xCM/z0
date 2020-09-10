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

        public IWfShell Wf {get;}

        readonly IWfEventLog Log;

        [MethodImpl(Inline)]
        public WfCaptureContext(IAsmContext asm, IWfShell wf, IAsmDecoder decoder, IAsmFormatter formatter, AsmTextWriterFactory writerfactory, IPartCapturePaths archive, CorrelationToken ct)
        {
            Ct = ct;
            Wf = wf;
            Log = Flow.log(wf.Init);
            Broker = AsmWorkflows.capture(wf);
            Context = new CaptureContext(asm.ContextRoot, decoder, formatter, writerfactory, Broker, Ct);
        }

        public void Dispose()
        {
            Broker.Dispose();
            Log.Dispose();
        }
    }
}