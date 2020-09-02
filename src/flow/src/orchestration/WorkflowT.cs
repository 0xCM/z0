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
    using static WfDelegates;

    public readonly struct Workflow<T> : IDisposable, IDataSink
    {
        readonly IAppContext Context;

        readonly EventReceiver Receiver;

        readonly FilePath ErrorLogPath;

        readonly StreamWriter StatusLog;

        readonly Action Connector;

        readonly Action Executor;

        readonly EventHub Hub;

        readonly HubRelay Relay;

        readonly HubClient client;

        [MethodImpl(Inline)]
        public Workflow(IAppContext context, EventReceiver receiver, Action connect, Action exec)
            : this()
        {
            Context = context;
            Receiver = receiver;
            ErrorLogPath = context.AppPaths.AppErrorLogPath;
            StatusLog = context.AppPaths.AppStatusLogPath.Writer();
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
            StatusLog.Dispose();
        }

        public void Run()
            => Executor();
    }
}