//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BrokerClient<E> : IBrokerClient<E>
        where E : IEventBroker
    {
        public E Broker {get;}

        public IAppMsgSink Sink {get;}        
     
        [MethodImpl(Inline)]
        public static IBrokerClient<E> create(E broker, IAppMsgSink sink)
            => new BrokerClient<E>(broker,sink);

        [MethodImpl(Inline)]
        public BrokerClient(E broker, IAppMsgSink sink)
        {
            Broker = broker;
            Sink = sink;
        }        
    }
}