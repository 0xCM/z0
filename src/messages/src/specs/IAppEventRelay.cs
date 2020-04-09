//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes a broker that forwards events
    /// </summary>
    public interface IAppEventRelay : IAppEventBroker
    {
        /// <summary>
        /// Relays an event to sinks and receivers registerd with the broker
        /// </summary>
        /// <param name="e">The event to relay</param>
        /// <typeparam name="E">The event type</typeparam>
        ref readonly E Raise<E>(in E e)
            where E : IAppEvent;
    }
}