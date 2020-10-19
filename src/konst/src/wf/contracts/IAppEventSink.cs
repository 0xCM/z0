//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes an event-parametric application event sink
    /// </summary>
    /// <typeparam name="E">The event type</typeparam>
    [Free]
    public interface IAppEventSink<E> : ISink<E>
        where E : IAppEvent
    {
        void Deposit(IAppEvent e);
    }
}