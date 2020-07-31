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

        readonly Action Executor;


        [MethodImpl(Inline)]
        public HubClient(IEventHub hub, IDataSink sink, Action connect, Action exec)
        {
            Hub = hub;
            Sink = sink;
            Connector = connect;
            Executor = exec;
            Connect();
            //(this as IHubClient).Connect();
        }

        public void Deposit(IDataEvent e)
            => Sink.Deposit(e);

        public void Deposit<S>(in S e)
            where S : struct, IDataEvent
                => Sink.Deposit(e);

        [MethodImpl(Inline)]
        public void Connect()
            => Connector();
        
        [MethodImpl(Inline)]
        public void Exec()
            => Executor();
    }
}