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

    public readonly struct WfEventHub : IWfEventHub
    {
        internal readonly Dictionary<Type,IDataSink> Index;

        [MethodImpl(Inline)]
        internal WfEventHub(int capacity)
            => Index = new Dictionary<Type,IDataSink>(capacity);

        [MethodImpl(Inline)]
        public void Subscribe<E>(E e, EventReceiver<E> receiver)
            where E : struct, IDataEvent
                => EventHubs.subscribe(this, EventHubs.relay(receiver), e);

        [MethodImpl(Inline)]
        public void Subscribe<E>(E e, EventReceiver receiver)
            where E : struct, IDataEvent
                => EventHubs.subscribe(this, receiver, e);

        [MethodImpl(Inline)]
        public void Subscribe(IDataEvent e, EventReceiver receiver)
            => EventHubs.subscribe(this, receiver, e);

        [MethodImpl(Inline)]
        public ref readonly E Broadcast<E>(in E e)
            where E : struct, IDataEvent
                => ref EventHubs.broadcast(this, e);
    }
}