//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static class AppEvents
    {
        /// <summary>
        /// Creates a payload-parametric application event
        /// </summary>
        /// <param name="name">The event name</param>
        /// <param name="data">The event payload</param>
        /// <param name="ct">The correlation token, if any</param>
        /// <typeparam name="T">The payload type</typeparam>
        [MethodImpl(Inline)]
        public static AppEvent<T> create<T>(string name, T data, CorrelationToken? ct = null)
            => AppEvent.Create(name, data, ct);

        /// <summary>
        /// Creates a nonparametric application event
        /// </summary>
        /// <param name="name">The event name</param>
        /// <param name="data">The event data, if any</param>
        /// <param name="ct">The correlation token, if any</param>
        [MethodImpl(Inline)]
        public static AppEvent create(string name, object data = null, CorrelationToken? ct = null)
            => AppEvent.Create(name,data,ct);

        /// <summary>
        /// Creates an even sink predicated on a receiver
        /// </summary>
        /// <param name="receiver">The receiver to invoke upon event receipt</param>
        /// <typeparam name="E">The event type</typeparam>
        [MethodImpl(Inline)]
        public static EventRelay<E> sink<E>(Action<E> receiver)
            where E : IAppEvent
                => new EventRelay<E>(receiver);

        /// <summary>
        /// Creates an even sink predicated on a receiver
        /// </summary>
        /// <param name="receiver">The receiver to invoke upon event receipt</param>
        /// <typeparam name="E">The event type</typeparam>
        [MethodImpl(Inline)]
        public static EventRelay sink(Action<IAppEvent> receiver)
            => new EventRelay(receiver);

        /// <summary>
        /// Registers an event receiver to which brokered events will be relayed
        /// </summary>
        /// <param name="model">An event representative</param>
        /// <param name="broker">The broker</param>
        /// <param name="receiver">The handler ivoked upon event occurrence</param>
        /// <typeparam name="E">The event type</typeparam>
        [MethodImpl(Inline)]
        public static Outcome subscribe<E>(E model, IEventBroker broker, Action<E> receiver)
            where E : IAppEvent
                => broker.Subscribe(receiver);        
        
        [MethodImpl(Inline)]
        public static Outcome subscribe(IAppEvent model, IEventBroker broker, Action<IAppEvent> receiver)
            => broker.Subscribe(receiver, model);
    }
}