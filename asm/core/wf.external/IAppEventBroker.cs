//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAppEventBroker
    {
        BrokeredMessage<E> AcceptSink<S,E>(S sink, E model = default)
            where E : IAppEvent
            where S : IAppEventSink<E>;

        BrokeredMessage<E> AcceptReceiver<E>(Action<E> receiver, E model = default)
            where E : IAppEvent;        
    }

    public interface IAppEventRelay : IAppEventBroker
    {
        ref readonly E RaiseEvent<E>(in E e)
            where E : IAppEvent;
    }
}