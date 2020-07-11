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
    
    public readonly struct EventHub : IEventHub
    {
        internal readonly Dictionary<Type,ISink> Index;

        [MethodImpl(Inline)]
        internal EventHub(int capacity)
            => Index = new Dictionary<Type,ISink>(capacity);

        [MethodImpl(Inline)]
        public Outcome Subscribe<E>(E e, HubEventReceiver<E> receiver)
            where E : struct, IAppEvent                 
                => EventHubs.subscribe(this, e, receiver);

        [MethodImpl(Inline)]
        public Outcome Subscribe(HubEventReceiver receiver, IAppEvent model)
            => EventHubs.subscribe(this, receiver, model);

        [MethodImpl(Inline)]
        public ref readonly E Broadcast<E>(in E e)
            where E : struct, IAppEvent                 
                => ref EventHubs.broadcast(this,e);
    }
}