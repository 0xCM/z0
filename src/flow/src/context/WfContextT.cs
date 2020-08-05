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
        public const string WorkerName = nameof(WfContext<T>);
        
        long CtProvider;

        readonly ulong SessionId;

        public IMultiSink Sink {get;}

        public IAppContext ContextRoot {get;}
        
        public T State {get;}
        
        public CorrelationToken Correlation {get;}

        [MethodImpl(Inline)]
        public WfContext(IAppContext root, T config, IMultiSink sink)
        {
            SessionId = (ulong)now().Ticks;
            ContextRoot = root;
            State = config;
            CtProvider = 1;
            Sink = sink;
            Correlation = CorrelationToken.define(CtProvider);
            Sink.Deposit(new OpeningWfContext(WorkerName, typeof(WfContext<T>).Name, Correlation));
        }

        public void Dispose()
        {
            Sink.Deposit(new ClosingWfContext(WorkerName, typeof(WfContext<T>).Name, Correlation));
        }
        
        public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
        {
            Sink.Deposit(@event);
            return @event.Id;
        }
    }
}