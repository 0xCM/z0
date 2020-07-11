//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    public interface IHubEventSink : ISink
    {
       void Deposit(IAppEvent e);
    }

    public interface IDataEventSink : ISink
    {
       void Deposit(IDataEvent e);        
    }

    /// <summary>
    /// Characterizes an event-parametric application event sink
    /// </summary>
    /// <typeparam name="E">The event type</typeparam>
    public interface IHubEventSink<E> : IHubEventSink, IDataSink<E>
        where E : struct, IAppEvent
    {
        void IHubEventSink.Deposit(IAppEvent e)
            => Deposit((E)e);
    }
}