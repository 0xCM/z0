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
        public static HubRelay relay(HubEventReceiver receiver)
            => new HubRelay(receiver);

        [MethodImpl(Inline), Op]
        public static HubDataRelay relay(DataEventReceiver receiver)
            => new HubDataRelay(receiver);

        [MethodImpl(Inline), Op]
        public static EventHub hub(int capacity = 128)
            => new EventHub(capacity);    

        [MethodImpl(Inline), Op]
        internal static Outcome subscribe(EventHub hub, HubEventReceiver receiver, IAppEvent model)
        {
            if(hub.Index.TryAdd(model.GetType(), EventHubs.relay(receiver)))
                return true;
            else
                return (false, AppMsg.Warn($"Key for {model.GetType()} was previously added"));            
        }

        [MethodImpl(Inline)]
        internal static HubRelay<E> relay<E>(HubEventReceiver<E> receiver)
            where E : struct, IAppEvent
                => new HubRelay<E>(receiver);

        [MethodImpl(Inline)]
        internal static Outcome subscribe<E>(EventHub hub, E e, HubEventReceiver<E> receiver)
            where E : struct, IAppEvent                 
                => subscribe(hub, EventHubs.relay(receiver), e);

        [MethodImpl(Inline)]
        internal static ref readonly E broadcast<E>(EventHub hub, in E e)
            where E : struct, IAppEvent                 
        {                
            if(hub.Index.TryGetValue(e.GetType(), out var sink))
                ((IHubEventSink<E>)sink).Deposit(e);
            return ref e;
        }

        [MethodImpl(Inline)]
        internal static Outcome subscribe<E>(EventHub hub, HubEventReceiver<E> receiver, E model = default)
            where E : struct, IAppEvent                 
                => subscribe(hub, EventHubs.relay(receiver), model);

        [MethodImpl(Inline)]
        internal static Outcome subscribe<S,E>(EventHub hub, S sink, E model)
            where E : struct, IAppEvent                 
            where S : IHubEventSink
        {
            if(hub.Index.TryAdd(typeof(E), sink))
                return true;
            else
                return (false, AppMsg.Warn($"Key for {model} was previously added for {sink}"));
        }                
    }
}