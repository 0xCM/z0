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

        readonly CorrelationToken Ct {get;}
        
        public CaptureState(ICaptureWorkflow cwf, PartWfConfig config, CorrelationToken? ct = null)        
        {
            CWf = cwf;
            Config = config;
            Ct = ct ?? CorrelationToken.create();
        }

        public void Initialized(string worker, CorrelationToken? ct = null)
        {
            Raise(new WorkerInitialized(worker, ct));
        }

        public void Finished(string worker, CorrelationToken? ct = null)
        {   
            Raise(new WorkerFinished(worker,ct));            
        }

        public void Running(string worker, CorrelationToken ct)
        {
            Raise(new WfStepRunning(worker, ct));
        }

        public void Ran(string worker, CorrelationToken? ct = null)
        {
            Raise(new WfStepFinished(worker, ct));            
        }

        public IAppEventSink AppEventSink 
            => CWf.Broker.Sink;
        
        public WfContext Wf 
            => Config.Context;
        
        public IWfEventSink WfEventSink
            => Wf.Broker.Sink;

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