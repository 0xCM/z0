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
    using static Flow;

    public readonly struct CaptureState
    {
        public ICaptureWorkflow CWf {get;}

        public PartWfConfig Config {get;}

        readonly CorrelationToken Ct {get;}
        
        [MethodImpl(Inline)]
        public CaptureState(ICaptureWorkflow cwf, PartWfConfig config, CorrelationToken? ct = null)        
        {
            CWf = cwf;
            Config = config;
            Ct = ct ?? CorrelationToken.create();
        }

        public void Created(string worker, CorrelationToken ct)
        {
            Raise(new WorkerCreated(worker, ct));
        }

        public void Running(string worker, CorrelationToken ct)
        {
            Raise(new WfStepRunning(worker, ct));
        }

        public void Ran(string worker, CorrelationToken ct)
        {
            Raise(new WfStepFinished(worker, ct));            
        }

        public void Finished(string worker, CorrelationToken ct)
        {   
            Raise(new WorkerFinished(worker, ct));            
        }

        public void Error(string worker, Exception e, CorrelationToken ct)
        {
            Raise(new WorkflowError(worker, e, ct));
        }
        
        public IAppEventSink AppEventSink 
            => CWf.Broker.Sink;
        
        public WfContext Wf 
            => Config.Context;
        
        public IWfEventSink WfEventSink
            => Wf.Broker.Sink;

        public void Status<T>(string worker, T body, CorrelationToken ct)
        {
            Wf.Status(worker, body, ct);
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