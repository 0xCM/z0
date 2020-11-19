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

        long SourceToken;

        long TargetToken;

        WfExecTokens ExecTokens {get;}
            = WfExecTokens.init();

        [MethodImpl(Inline)]
        public WfShell(IWfInit config)
        {
            Context = config.Shell;
            Init = config;
            Id = config.ControlId;
            Ct = correlate(config.ControlId);
            WfSink = WfShell.log(config.Logs);
            Broker = new WfBroker(WfSink, Ct);
            Host = new WfHost(typeof(WfShell), typeof(WfShell), _ => throw no<WfShell>());
            Random = default;
            Verbosity = LogLevel.Info;
            Paths = config.Shell.Paths;
            Args = config.Shell.Args;
            Settings = JsonSettings.Load(config.Shell.Paths.AppConfigPath);
            ApiParts = config.ApiParts;
            Api = config.ApiParts.Api;
            Controller = config.Control;
            AppName = config.Shell.AppName;
            Router = new CmdRouter(this);
        }

        internal WfShell(IWfInit config, CorrelationToken ct, IWfEventSink sink, IWfBroker broker, WfHost host, IPolyrand random, LogLevel verbosity, ICmdRouter router)
        {
            Context = config.Shell;
            Init = config;
            Id = config.ControlId;
            Ct = ct;
            WfSink = sink;
            Broker = broker;
            Host = host;
            Random = random;
            Verbosity = verbosity;
            Args = config.Shell.Args;
            Paths = config.Shell.Paths;
            Settings = JsonSettings.Load(config.Shell.Paths.AppConfigPath);
            ApiParts = config.ApiParts;
            Api = config.ApiParts.Api;
            Controller = config.Control;
            AppName = config.Shell.AppName;
            Router = router;
        }

        IWfShell Wf => this;

        public WfExecFlow Running()
        {
            Wf.SignalRunning();
            return Wf.Flow();
        }

        public WfExecToken Ran(WfExecFlow src)
        {
            Wf.SignalRan();
            var token = CloseExecToken(src.Token);
            ExecTokens.TryAdd(token.Source, token);
            return token;
        }

        [MethodImpl(Inline)]
        public WfExecToken NextExecToken()
            => new WfExecToken((ulong)atomic(ref SourceToken));

        [MethodImpl(Inline)]
        public WfExecToken CloseExecToken(WfExecToken src)
            => src.WithTarget((ulong)atomic(ref TargetToken));


        public void Dispose()
        {
            Broker.Dispose();
            WfSink.Dispose();
        }

        string ITextual.Format()
            => AppName;
    }
}