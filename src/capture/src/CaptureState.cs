//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;

    public readonly struct CaptureState
    {
        public ICaptureWorkflow CWf {get;}

        public PartWfConfig Config {get;}

        public CorrelationToken Ct {get;}
        
        public WfTermEventSink TermSink {get;}
        public CaptureState(ICaptureWorkflow cwf, PartWfConfig config, WfTermEventSink sink, CorrelationToken? ct = null)        
        {
            TermSink = sink;
            CWf = cwf;
            Config = config;
            Ct = ct ?? CorrelationToken.create();
        }

        public IAppEventSink AppEventSink 
            => CWf.Broker.Sink;
        
        public WfContext Wf 
            => Config.Context;
        
        public ICaptureContext CaptureContext
            => CWf.Context;

        public void Status(string msg, CorrelationToken? ct = null)
        {
            Wf.Status(msg, ct);
        }

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
        {
            Wf.TermSink.Deposit(@event);
            return @event.Id;
        }

        public void Raise(IAppEvent e)
        {
            Wf.TermSink.Deposit(e);
        }
    }
}