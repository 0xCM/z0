//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    public interface IAppEventSink : ISink
    {
       void Deposit(IAppEvent e);
    }

    /// <summary>
    /// Characterizes an event-parametric application event sink
    /// </summary>
    /// <typeparam name="E">The event type</typeparam>
    public interface IAppEventSink<E> : IAppEventSink, ISink<E>
        where E : IAppEvent
    {
        [MethodImpl(Inline)]
        void IAppEventSink.Deposit(IAppEvent e)
            => Deposit(e);
    }
}