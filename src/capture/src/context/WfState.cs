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

    public readonly struct WfState
    {
        public WfContext Wf {get;}
        
        public ICaptureWorkflow CWf {get;}

        public WfConfig Config {get;}

        readonly CorrelationToken Ct {get;}

        [MethodImpl(Inline)]
        public WfState(ICaptureWorkflow cwf, WfContext wf, WfConfig config, CorrelationToken ct)        
        {
            Wf = wf;
            CWf = cwf;
            Config = config;
            Ct = ct;
        }

        public IAppEventSink AppEventSink 
            => CWf.Broker.Sink;
        
        
        public IWfEventSink WfEventSink
            => Wf.Broker.Sink;

        public void Created(string worker, CorrelationToken ct)
            => Wf.Created(worker, Ct);

        public void Running(string worker, CorrelationToken ct)
            => Wf.Running(worker, ct);

        public void Ran(string worker, CorrelationToken ct)
            => Wf.Ran(worker, Ct);

        public void Finished(string worker, CorrelationToken ct)
            => Wf.Finished(worker, Ct);

        public void Error(string worker, Exception e, CorrelationToken ct)
            => Wf.Error(worker, e, Ct);

        public void Error(string worker, string description, CorrelationToken ct)
            => Wf.Error(worker, description, ct);

        public void Status<T>(string worker, T body, CorrelationToken ct)
            => Wf.Status(worker, body, ct);

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
                => Wf.Raise(@event);
    }
}