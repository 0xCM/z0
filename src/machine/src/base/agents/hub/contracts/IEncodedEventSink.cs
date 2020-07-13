//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface IEncodedEventSink : ISink
    {
       void Deposit(IEncodedEvent e);        
    }

    /// <summary>
    /// Characterizes an event-parametric application event sink
    /// </summary>
    /// <typeparam name="E">The event type</typeparam>
    public interface IEncodedEventSink<E> : IEventHubSink, IDataSink<E>
        where E : struct, IAppEvent
    {
        void IEventHubSink.Deposit(IAppEvent e)
            => Deposit((E)e);
    }
}