//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IEventBroker : IDisposable, IMultiSink
    {
        Outcome Subscribe<E>(Action<E> receiver, E model = default)
            where E : IAppEvent;

        void Raise(IWfEvent e);

        void Raise(IAppEvent e);

        IEventSink Sink {get;}
    }
}