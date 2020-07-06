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

    public class EventBroker : IEventBroker
    {
        readonly Dictionary<Type,ISink> Subscriptions;

        [MethodImpl(Inline)]
        public EventBroker()
        {
            Subscriptions = new Dictionary<Type,ISink>();
        }

        Outcome Subscribe<S,E>(S sink, E model)
            where E : IAppEvent
            where S : ISink
        {
            if(Subscriptions.TryAdd(typeof(E), sink))
                return true;
            else
                return (false, AppMsg.Warn($"Key for {model} was previously added for {sink}"));
        }

        [MethodImpl(Inline)]
        public Outcome Subscribe<E>(Action<E> receiver, E model = default)
            where E : IAppEvent                 
                => Subscribe(AppEvents.sink(receiver), model);

        [MethodImpl(Inline)]
        Outcome IEventBroker.Subscribe<S,E>(S sink, E model)
            => Subscribe(sink,model);

        ref readonly E IEventBroker.Raise<E>(in E e)
        {                
            if(Subscriptions.TryGetValue(e.GetType(), out var sink))
                ((IAppEventSink<E>)sink).Deposit(e);
            return ref e;
        }

        public Outcome Subscribe(Action<IAppEvent> receiver, IAppEvent model)
        {
            if(Subscriptions.TryAdd(model.GetType(), AppEvents.sink(receiver)))
                return true;
            else
                return (false, AppMsg.Warn($"Key for {model.GetType()} was previously added"));            
        }
    }
}