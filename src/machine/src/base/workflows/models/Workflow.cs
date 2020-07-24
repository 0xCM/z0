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
        public readonly ulong Id;
        
        readonly IAppContext Context;
        
        readonly EventReceiver Receiver;

        readonly FilePath ErrorLogPath;
                
        readonly StreamWriter StatusLog;

        readonly Action Connector;

        readonly Action Executor;

        readonly EventHub Hub;

        readonly HubRelay Relay;

        readonly HubClient client;

        long Correlation;
        
        [MethodImpl(Inline)]
        public Workflow(ulong id, IAppContext context, EventReceiver receiver, Action connect, Action exec)
            : this()
        {
            Correlation = 0;
            Id = id;
            Context = context;
            Receiver = receiver;
            ErrorLogPath = context.AppPaths.AppErrorOutPath;
            StatusLog = context.AppPaths.AppStandardOutPath.Writer();
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

        [MethodImpl(Inline)]
        public CorrelationToken<ulong> Correlate()
            => new CorrelationToken<ulong>((ulong)z.atomic(ref Correlation));

        public void Run()
            => Executor();
    }
}