//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IWfBrokerClient
    {
        IWfEventSink Sink {get;}
    }

    public interface IWfBrokerClient<E> : IWfBrokerClient
        where E : IWfBroker
    {
        E Broker {get;}
    }
}