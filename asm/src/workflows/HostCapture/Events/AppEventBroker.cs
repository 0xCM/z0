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

    using static Root;

    public interface IAppEventBroker
    {
        void AddSink<S,E>(S sink, E model = default)
            where E : IAppEvent
            where S : IAppEventSink<E>;

        void RaiseEvent<E>(in E e)
            where E : IAppEvent;
    }

    public interface IBrokeredSource : IAppEventSource
    {
        void AddSinks(IAppEventBroker broker);
    }
    
    public readonly struct AppEventBroker : IAppEventBroker
    {
        readonly IBrokeredSource Source;

        readonly Dictionary<Type, IAppEventSink> Sinks;

        [MethodImpl(Inline)]
        public static AppEventBroker Create(IBrokeredSource source)
            => new AppEventBroker(source);
        
        [MethodImpl(Inline)]
        AppEventBroker(IBrokeredSource source)
        {
            Source = source;
            Sinks = new Dictionary<Type, IAppEventSink>();
            Source.AddSinks(this);
        }

        public void AddSink<S,E>(S sink, E model = default) 
            where E : IAppEvent
            where S : IAppEventSink<E>
        {
            Sinks[typeof(E)] = sink;
        }

        public void RaiseEvent<E>(in E e)
            where E : IAppEvent
        {                
            if(Sinks.TryGetValue(e.GetType(), out var sink))
            {
                ((IAppEventSink<E>)sink).Accept(e);
            }
        }
    }
}