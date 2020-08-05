//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IWfBrokerClient
    {
        IMultiSink Sink {get;}

        IWfBroker Broker {get;}
    }

    public interface IWfBrokerClient<E> : IWfBrokerClient
        where E : IWfBroker
    {
        new E Broker {get;}

        IWfBroker IWfBrokerClient.Broker 
            => Broker;
    }
}