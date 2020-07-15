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
    
    public readonly struct Workflow<T> : IDisposable, IWorkflowSteps<Workflow<T>>, IDataSink
    {     
        readonly IAppContext Context;
        
        readonly EventHub Hub;

        readonly HubRelay Relay;

        readonly Action Runner;
                
        readonly StreamWriter StatusLog;

        readonly FilePath ErrorLogPath;

        [MethodImpl(Inline)]
        public Workflow(IAppContext context, EventReceiver receiver, Action runner)
        {
            Context = context;
            ErrorLogPath = context.AppPaths.AppErrorOutPath;
            StatusLog = context.AppPaths.AppStandardOutPath.Writer();
            Hub = EventHubs.hub();
            Relay = new HubRelay(receiver);
            Runner = runner;
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
            => Runner();
    }        
}