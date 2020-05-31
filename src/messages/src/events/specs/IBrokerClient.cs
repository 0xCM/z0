//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IBrokerClient
    {
        IEventBroker Broker {get;}

        IAppMsgSink Sink {get;}
    }

    public interface IBrokerClient<E> : IBrokerClient
        where E : IEventBroker
    {
        new E Broker {get;}

        IEventBroker IBrokerClient.Broker => Broker;
    }
}