//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static Konst;

    public struct Workflow : IDataSink
    {
        readonly IWfShell Wf;

        readonly EventReceiver Receiver;

        readonly Action Connector;

        readonly Action Executor;

        readonly EventHub Hub;

        readonly HubRelay Relay;

        readonly HubClient client;

        readonly CorrelationToken Ct;

        [MethodImpl(Inline)]
        public Workflow(IWfShell wf, EventReceiver receiver, Action connect, Action exec)
        {
            Wf = wf;
            Ct = wf.Ct;
            Receiver = receiver;
            Connector = connect;
            Executor = exec;
            Hub = EventHubs.hub();
            Relay = new HubRelay(receiver);
            client = EventHubs.client(Hub, this, connect, exec);
        }

        [MethodImpl(Inline)]
        public void Deposit(IDataEvent e)
            => Relay.Deposit(e);

        [MethodImpl(Inline)]
        public void Deposit<S>(in S e)
            where S : struct, IDataEvent
                => Relay.Deposit(e);

        public void Dispose()
        {

        }

        public void Run()
            => Executor();
    }
}