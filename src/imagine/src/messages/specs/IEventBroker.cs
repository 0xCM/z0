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
    public interface IEventBroker
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
        /// Registers an Event-parametric receiver to invoke upon occurrence of the parametrically-identified event
        /// </summary>
        /// <param name="receiver">The event receiver</param>
        /// <param name="model">An event model representative that identifies the event of interest</param>
        /// <typeparam name="E">The event type</typeparam>
        Outcome Subscribe<E>(Action<E> receiver, E model = default)
            where E : IAppEvent;        
        
        /// <summary>
        /// Registers a non-parametric receiver to invoke upon occurrence of a specified event
        /// </summary>
        /// <param name="receiver"></param>
        /// <param name="model">An event model representative that identifies the event of interest</param>
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