//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Characterizes an event-parametric application event sink
    /// </summary>
    /// <typeparam name="E">The event type</typeparam>
    public interface IAppEventSink<E> : ISink<E>
        where E : IAppEvent
    {

    }
}