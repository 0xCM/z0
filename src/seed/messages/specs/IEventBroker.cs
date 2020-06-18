//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes an application even exchange hub
    /// </summary>
    public interface IEventBroker : IService
    {
        /// <summary>
        /// Registers a target sink to which events will be routed
        /// </summary>
        /// <param name="sink">The target sink</param>
        /// <param name="model">An event representative</param>
        /// <typeparam name="S">The sink type</typeparam>
        /// <typeparam name="E">The event type</typeparam>
        Outcome Subscribe<S,E>(S sink, E model = default)
            where E : IAppEvent
            where S : IAppEventSink<E>;

        /// <summary>
        /// Registers a receiver to be invoked upon event occurrence
        /// </summary>
        /// <param name="receiver">The event receiver</param>
        /// <param name="model">An event representative</param>
        /// <typeparam name="E">The event type</typeparam>
        Outcome Subscribe<E>(Action<E> receiver, E model = default)
            where E : IAppEvent;        
        
        Outcome Subscribe(Action<IAppEvent> receiver, IAppEvent model);

        /// <summary>
        /// Relays an event to sinks and receivers registerd with the broker
        /// </summary>
        /// <param name="e">The event to relay</param>
        /// <typeparam name="E">The event type</typeparam>
        ref readonly E Raise<E>(in E e)
            where E : IAppEvent;
    }
}