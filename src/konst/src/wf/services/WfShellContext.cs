//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static AB;

    public readonly struct WfShellContext : IWfShell
    {
        public IShellContext Shell {get;}

        public IMultiSink WfSink {get;}

        public FolderPath IndexRoot {get;}

        public FolderPath ResourceRoot {get;}

        public CorrelationToken Ct {get;}

        public WfConfig Config {get;}

        public IWfBroker Broker {get;}

        public string[] Args {get;}

        readonly IWfEventLog Log;


        [MethodImpl(Inline)]
        public WfShellContext(IShellContext<WfConfig> shell, CorrelationToken ct)
        {
            Shell = shell;
            Args = shell.Args;
            Ct = ct;
            Config = shell.Config;
            Log = log(shell.Config, Ct);
            Broker = new WfBroker(Log, Ct);
            WfSink = Broker;
            ResourceRoot = FolderPath.Define(Config.ResRoot.Name);
            IndexRoot = FolderPath.Define(Config.IndexRoot.Name);
        }

        public void Dispose()
        {
            Broker.Dispose();
            Log.Dispose();
        }

       public WfEventId Raise<E>(in E @event)
            where E : IWfEvent
        {
            WfSink.Deposit(@event);
            return @event.EventId;
        }
    }
}