//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public sealed class EventQueue : IEventSink, IEventEmitter
    {
        public static EventQueue allocate(Type host = null)
            => new EventQueue(host);

        readonly ConcurrentQueue<IWfEvent> Storage = new();

        readonly CorrelationToken Ct = CorrelationToken.create(controller().Id());

        readonly Action<IWfEvent> Receiver;

        readonly EventSignal Signal;

        readonly Type Host;

        internal EventQueue(Type host = null)
        {
            Host = host ?? GetType();
            Receiver = e => {};
            Signal = EventSignal.create(this, Host, Ct);
        }

        internal EventQueue(Action<IWfEvent> receiver, Type host = null)
        {
            Host = host ?? GetType();
            Receiver = receiver;
            Signal = EventSignal.create(this, Host, Ct);
        }

        public void Deposit(IWfEvent e)
        {
            if(e != null)
            {
                root.run(() => Receiver.Invoke(e));
                Storage.Enqueue(e);
            }
            else
                term.error("Null messages don't belong in the queue");

        }

        public void Dispose()
        {
            if(Storage.Count != 0)
                term.warn("Nonempty queue disposed");
        }

        [MethodImpl(Inline)]
        public bool Emit(out IWfEvent e)
            => Storage.TryDequeue(out e);

        public void Babble<T>(T content)
            => Deposit(EventFactory.babble(Host, content));

        public void Status<T>(T content)
            => Deposit(EventFactory.status(Host, content));

        public void Warn<T>(T content)
            => Deposit(EventFactory.warn(Host, content));

        public void Error<T>(T content, EventOrigin origin)
            => Deposit(EventFactory.error(Host, content, origin));
    }
}