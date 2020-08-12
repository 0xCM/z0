//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;    
    
    [ApiHost]
    public readonly struct EventHubs
    {
        [MethodImpl(Inline), Op]
        public static EventHub hub(int capacity = 128)
            => new EventHub(capacity);    

        [MethodImpl(Inline), Op]
        public static HubClient client(IEventHub hub, IDataSink sink, Action connect, Action exec)
            => new HubClient(hub, sink, connect, exec);

        [MethodImpl(Inline)]
        public static HubRelay relay(EventReceiver receiver)
            => new HubRelay(receiver);

        [MethodImpl(Inline)]
        public static HubRelay<E> relay<E>(EventReceiver<E> receiver)
            where E : struct, IDataEvent                 
                => new HubRelay<E>(receiver);

        [MethodImpl(Inline)]
        public static ref readonly E broadcast<E>(EventHub hub, in E e)
            where E : struct, IDataEvent                 
        {                
            if(hub.Index.TryGetValue(e.GetType(), out var sink))
                sink.Deposit(e);
            return ref e;
        }

        [MethodImpl(Inline)]
        public static bool subscribe<E>(EventHub hub, EventReceiver receiver, E model = default)
            where E : struct, IDataEvent                 
                => subscribe(hub, new HubRelay(receiver), model);

        [MethodImpl(Inline), Op]
        public static bool subscribe(EventHub hub, EventReceiver receiver, IDataEvent model)
            => hub.Index.TryAdd(model.GetType(), new HubRelay(receiver));

        [MethodImpl(Inline)]
        public static bool subscribe<S,E>(EventHub hub, S sink, E model)
            where E : struct, IDataEvent                 
            where S : IDataSink
                => hub.Index.TryAdd(typeof(E), sink);
    }
}