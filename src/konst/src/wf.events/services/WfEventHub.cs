//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    using api = WfBrokers;

    public readonly struct WfEventHub : IWfEventHub
    {
        internal readonly Dictionary<Type,IDataEventSink> Index;

        [MethodImpl(Inline)]
        internal WfEventHub(int capacity)
            => Index = new Dictionary<Type,IDataEventSink>(capacity);

        [MethodImpl(Inline)]
        public void Subscribe<E>(E e, EventReceiver<E> receiver)
            where E : struct, IDataEvent
                => api.subscribe(this, api.relay(receiver), e);

        [MethodImpl(Inline)]
        public void Subscribe<E>(E e, EventReceiver receiver)
            where E : struct, IDataEvent
                => api.subscribe(this, receiver, e);

        [MethodImpl(Inline)]
        public void Subscribe(IDataEvent e, EventReceiver receiver)
            => api.subscribe(this, receiver, e);

        [MethodImpl(Inline)]
        public ref readonly E Broadcast<E>(in E e)
            where E : struct, IDataEvent
                => ref api.broadcast(this, e);
    }
}