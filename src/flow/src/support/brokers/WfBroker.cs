//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    
    public class WfBroker : IWfBroker
    {
        readonly Dictionary<Type,ISink> Subscriptions;

        readonly Dictionary<ulong, Receiver<IAppEvent>> Receivers;
        
        public IWfEventSink Sink {get;}

        object locker;

        CorrelationToken Ct;

        IWfContext Wf;

        [MethodImpl(Inline)]
        public WfBroker(IWfEventLog log, CorrelationToken ct)        
        {
            Ct = ct;
            Sink = Flow.termsink(log, Ct);
            Subscriptions = new Dictionary<Type,ISink>();
            Receivers = new Dictionary<ulong, Receiver<IAppEvent>>();
            locker = new object();                             
        }

        [MethodImpl(Inline)]
        public IWfBroker WithContext(IWfContext wf)
        {
            Wf = wf;
            return this;
        }

        public void Dispose()
        {            
            
        }

        public Outcome Subscribe<S,E>(S sink, E model)
            where E : IAppEvent
            where S : ISink
        {
            if(Subscriptions.TryAdd(typeof(E), sink))
                return true;
            else
                return (false, AppMsg.Warn($"Key for {model} was previously added for {sink}"));
        }

        [MethodImpl(Inline)]
        static EventRelay<E> relay<E>(Action<E> receiver)
            where E : IAppEvent
                => new EventRelay<E>(receiver);

        [MethodImpl(Inline)]
        public Outcome Subscribe<E>(Action<E> receiver, E model = default)
            where E : IAppEvent
                => Subscribe(
                    relay(receiver), model);

        public void Cancel(ulong session)
        {
            lock(locker)
                Receivers.Remove(session);
        }

        void Emit(IWfEvent e)
        {
            z.iter(Receivers.Values, r => r(e));
        }

        void Emit(IAppEvent e)
        {
            z.iter(Receivers.Values, r => r(e));
        }

        public void Raise(IWfEvent e)
        {
            Emit(e);
        }

        public void Raise(IAppEvent e)
        {
            Emit(e);
        }

        public void Deposit(IWfEvent e)
        {
            Sink.Deposit(e);
        }

        public void Deposit(IAppEvent e)
        {
            term.print(e);
        }

        public void Deposit(IAppMsg e)
        {
            term.print(e);
        }
    }
}