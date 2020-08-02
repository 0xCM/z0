//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;

    public struct WfContext<T> : IWfContext<T>
    {
        long CtProvider;

        readonly ulong SessionId;

        public IWfEventSink Sink {get;}

        public IAppContext ContextRoot {get;}
        
        public T ContextData {get;}
        
        public CorrelationToken Correlation {get;}

        [MethodImpl(Inline)]
        public WfContext(IAppContext root, T config, IWfEventSink sink)
        {
            SessionId = (ulong)now().Ticks;
            ContextRoot = root;
            ContextData = config;
            CtProvider = 1;
            Sink = sink;
            Correlation = CorrelationToken.define(CtProvider);
            Sink.Deposit(new OpeningWfContext(typeof(WfContext<T>), Correlation));

        }

        public void Dispose()
        {

            Sink.Deposit(new ClosingWfContext(typeof(WfContext<T>), Correlation));
        }
        
        public TAppPaths AppPaths
        {
            [MethodImpl(Inline)]
            get => ContextRoot.AppPaths;
        }

        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
        {
            Sink.Deposit(@event);
            return @event.Id;
        }

        public void Emitted<D>(uint count, FilePath dst, D d = default)
            => Raise(new DatasetEmitted(typeof(D).Name, count, dst));

        public CorrelationToken Running(string worker)
        {
            var ct = CorrelationToken.define((ulong)z.atomic(ref CtProvider));
            Raise(new WfStepRunning(worker, ct));
            return ct;
        }

        public CorrelationToken Running(string worker, string detail, CorrelationToken? ct = null)
        {
            var correlation = ct ?? CorrelationToken.define((ulong)z.atomic(ref CtProvider));
            Raise(new WfStepRunning(worker, detail, correlation));
            return correlation;
        }

        public CorrelationToken Running<D>(string worker, D detail, CorrelationToken? ct = null)
            where D : ITextual
        {
            var correlation = ct ?? CorrelationToken.define((ulong)z.atomic(ref CtProvider));
            Raise(new WfStepRunning(worker, detail.Format(), correlation));
            return correlation;
        }

        public CorrelationToken Running(string worker, object detail, CorrelationToken? ct = null)
        {
            var correlation = ct ?? CorrelationToken.define((ulong)z.atomic(ref CtProvider));
            Raise(new WfStepRunning(worker, (detail ?? EmptyString).ToString(), correlation));
            return correlation;
        }

        public void Ran(string worker, CorrelationToken? ct = null)
        {
            var correlation = CorrelationToken.define((ulong)z.atomic(ref CtProvider));         
            Raise(new WfStepFinished(worker, correlation));            
        }

        public void Ran(string worker, string detail, CorrelationToken? ct = null)
        {
            var correlation = CorrelationToken.define((ulong)z.atomic(ref CtProvider));            
            Raise(new WfStepFinished(worker, detail, correlation));
        }

        public void Ran<D>(string worker, D detail, CorrelationToken? ct = null)
            where D : ITextual
        {
            var correlation = CorrelationToken.define((ulong)z.atomic(ref CtProvider));            
            Raise(new WfStepFinished(worker, detail.Format(), correlation));
        }        

        public void Ran(string worker, object detail, CorrelationToken? ct = null)
        {
            var correlation = CorrelationToken.define((ulong)z.atomic(ref CtProvider));            
            Raise(new WfStepFinished(worker, (detail ?? EmptyString).ToString(), correlation));
        }
    }
}