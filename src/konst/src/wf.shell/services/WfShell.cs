//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.WfShell, true)]
    public partial class WfShell : IWfShell
    {
        public IWfContext Context {get;}

        public PartId Id {get;}

        public IWfInit Init {get;}

        public IApiParts ApiParts {get;}

        public IWfEventSink WfSink {get;}

        public IWfBroker Broker {get;}

        public ICmdRouter Router {get;}

        public string[] Args {get;}

        public IWfPaths Paths {get;}

        public IJsonSettings Settings {get;}

        public CorrelationToken Ct {get;}

        public ISystemApiCatalog Api {get;}

        public string AppName {get;}

        public WfController Controller {get;}

        public IPolyrand Random {get; private set;}

        public WfHost Host {get; private set;}

        public LogLevel Verbosity {get; private set;}

        public WfServices Services {get;}

        long StartToken;

        long EndToken;

        ExecTokens Tokens {get;}
            = ExecTokens.init();

        [MethodImpl(Inline)]
        public WfShell(IWfInit config)
        {
            Services = new WfServices();
            Init = config;
            Context = Init.Shell;
            Id = Init.ControlId;
            Ct = correlate(Init.ControlId);
            WfSink = WfLogs.events(Init.LogConfig);
            Broker = new WfBroker(WfSink, Ct);
            Host = new WfHost(typeof(WfShell), typeof(WfShell), _ => throw no<WfShell>());
            Random = default;
            Verbosity = LogLevel.Info;
            Paths = Init.Shell.Paths;
            Args = Init.Shell.Args;
            Settings = Init.Shell.Settings;
            ApiParts = Init.ApiParts;
            Api = Init.ApiParts.Api;
            Controller = Init.Control;
            AppName = Init.Shell.AppName;
            Router = new CmdRouter(this);
        }

        internal WfShell(IWfInit config, CorrelationToken ct, IWfEventSink sink, IWfBroker broker, WfHost host, IPolyrand random, LogLevel verbosity, ICmdRouter router)
        {
            Init = config;
            Context = Init.Shell;
            Id = Init.ControlId;
            Args = Init.Shell.Args;
            Paths = Init.Shell.Paths;
            Settings = Init.Shell.Settings;
            ApiParts = Init.ApiParts;
            Api = Init.ApiParts.Api;
            Controller = Init.Control;
            AppName = Init.Shell.AppName;
            Ct = ct;
            WfSink = sink;
            Broker = broker;
            Host = host;
            Random = random;
            Verbosity = verbosity;
            Router = router;
        }

        IWfShell Wf => this;

        public IFileDb Db()
            => Init.Db;

        public WfExecFlow Running()
        {
            Wf.SignalRunning();
            return Wf.Flow();
        }

        public WfExecToken Ran(WfExecFlow src)
        {
            Wf.SignalRan();
            var token = CloseExecToken(src.Token);
            Tokens.TryAdd(token.Started, token);
            return token;
        }

        [MethodImpl(Inline)]
        public WfExecToken NextExecToken()
            => new WfExecToken((ulong)atomic(ref StartToken));

        [MethodImpl(Inline)]
        public WfExecToken CloseExecToken(WfExecToken src)
            => src.Complete((ulong)atomic(ref EndToken));

        public void Dispose()
        {
            Broker.Dispose();
            WfSink.Dispose();
        }

        string ITextual.Format()
            => AppName;
    }
}