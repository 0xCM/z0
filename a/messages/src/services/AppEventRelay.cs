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

    using static Seed;

    public class AppEventRelay : IAppEventRelay
    {
        readonly Dictionary<Type, ISink> Subscriptions;

        [MethodImpl(Inline)]
        public static IAppEventRelay Create()
            => new AppEventRelay();            

        protected AppEventRelay()
        {
            this.Subscriptions = new Dictionary<Type, ISink>();
        }

        Outcome Subscribe<S,E>(S sink, E model)
            where E : IAppEvent
            where S : ISink
        {
            if(Subscriptions.TryAdd(typeof(E), sink))
                return true;
            else
                return (false, AppMsg.Warn($"Key for {model} was previously specified added for {sink}"));
        }

        [MethodImpl(Inline)]
        public Outcome Subscribe<E>(Action<E> receiver, E model = default)
            where E : IAppEvent                 
                => Subscribe(AppEvents.sink(receiver), model);

        [MethodImpl(Inline)]
        Outcome IAppEventBroker.Subscribe<S, E>(S sink, E model)
            => Subscribe(sink,model);

        ref readonly E IAppEventRelay.RaiseEvent<E>(in E e)
        {                
            if(Subscriptions.TryGetValue(e.GetType(), out var sink))
                ((IAppEventSink<E>)sink).Accept(e);
            return ref e;
        }
    }
}