//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct HubClient : IHubClient
    {
        public IEventHub Hub {get;}

        readonly IDataSink Sink;

        readonly Action Connector;

        public void Deposit(IDataEvent e)
            => Sink.Deposit(e);

        public void Deposit<S>(in S e)
            where S : struct, IDataEvent
                => Sink.Deposit(e);

        [MethodImpl(Inline)]
        public HubClient(IEventHub hub, IDataSink sink, Action connector)
        {
            Hub = hub;
            Sink = sink;
            Connector = connector;
            Connect();
            //(this as IHubClient).Connect();
        }

        [MethodImpl(Inline)]
        public void Connect()
            => Connector();
    }
}