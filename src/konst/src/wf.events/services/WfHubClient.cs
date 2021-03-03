//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct WfHubClient : IWfHubClient
    {
        public IWfEventHub Hub {get;}

        readonly IDataEventSink Sink;

        readonly Action Connector;

        readonly Action Executor;

        [MethodImpl(Inline)]
        public WfHubClient(IWfEventHub hub, IDataEventSink sink, Action connect, Action exec)
        {
            Hub = hub;
            Sink = sink;
            Connector = connect;
            Executor = exec;
            Connect();
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