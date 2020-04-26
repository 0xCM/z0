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
    }

    public interface IBrokerClient<E> : IBrokerClient
        where E : IEventBroker
    {
        new E Broker {get;}

        IEventBroker IBrokerClient.Broker => Broker;
    }

    public readonly struct BrokerClient<E> : IBrokerClient<E>
        where E : IEventBroker
    {
        [MethodImpl(Inline)]
        public static IBrokerClient<E> Create(E broker)
            => new BrokerClient<E>(broker);

        [MethodImpl(Inline)]
        public BrokerClient(E broker)
        {
            this.Broker = broker;
        }
        
        public E Broker {get;}
    }
}