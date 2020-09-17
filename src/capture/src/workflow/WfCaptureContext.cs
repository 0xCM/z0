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
        public IWfShell Wf {get;}

        public ICaptureContext Context {get;}

        public IWfCaptureBroker Broker {get;}

        public CorrelationToken Ct {get;}

        readonly IWfEventLog Log;

        [MethodImpl(Inline)]
        public WfCaptureContext(IWfShell wf, IAsmDecoder decoder, IAsmFormatter formatter, IPartCapturePaths archive)
        {
            Wf = wf;
            Ct = Wf.Ct;
            Log = Flow.log(wf.Init);
            Broker = AsmWorkflows.capture(wf);
            Context = new CaptureContext(wf, decoder, formatter,  Broker);
        }

        public void Dispose()
        {
            Broker.Dispose();
            Log.Dispose();
        }
    }
}