//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;


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

        public IAppPaths Paths {get;}

        public IJsonSettings Settings {get;}

        public CorrelationToken Ct {get;}

        public IGlobalApiCatalog Api {get;}

        public string AppName {get;}

        public WfController Controller {get;}

        public IPolyStream PolyStream {get; private set;}

        public WfHost Host {get; private set;}

        public LogLevel Verbosity {get; private set;}

        public WfServices Services {get;}

        public Env Env {get;}

        TokenDispenser Tokens;

        [MethodImpl(Inline)]
        public WfShell(IWfInit config)
        {
            Tokens = TokenDispenser.acquire();
            Init = config;
            Env = Z0.Env.create();
            Context = config.Shell;
            Id = config.ControlId;
            Ct = root.correlate(config.ControlId);
            WfSink = Loggers.events(config.LogConfig);
            Broker = new WfBroker(WfSink, Ct);
            Host = new WfHost(typeof(WfShell), typeof(WfShell), _ => throw no<WfShell>());
            PolyStream = default;
            Verbosity = LogLevel.Status;
            Paths = config.Shell.Paths;
            Args = config.Shell.Args;
            Settings = config.Shell.Settings;
            ApiParts = config.ApiParts;
            Api = config.ApiParts.ApiGlobal;
            Controller = config.Control;
            AppName = config.Shell.AppName;
            Router = new CmdRouter(this);
            Services = new WfServices(this, Env, Api.PartComponents);
        }

        internal WfShell(IWfInit config, CorrelationToken ct, IWfEventSink sink, IWfBroker broker, WfHost host, IPolyStream random, LogLevel verbosity, ICmdRouter router, WfServices wfservices)
        {
            Tokens = TokenDispenser.acquire();
            Env = Z0.Env.create();
            Init = config;
            Context = config.Shell;
            Id = config.ControlId;
            Args = config.Shell.Args;
            Paths = config.Shell.Paths;
            Settings = config.Shell.Settings;
            ApiParts = config.ApiParts;
            Api = config.ApiParts.ApiGlobal;
            Controller = config.Control;
            AppName = config.Shell.AppName;
            Ct = ct;
            WfSink = sink;
            Broker = broker;
            Host = host;
            PolyStream = random;
            Verbosity = verbosity;
            Router = router;
            Services = wfservices;
        }

        public WfExecToken Ran(WfExecFlow src)
        {
            var token = Tokens.CloseExecToken(src.Token);
            return token;
        }

        public WfExecToken Ran<T>(WfExecFlow<T> src)
        {
            var token = Tokens.CloseExecToken(src.Token);
            WfEvents.signal(this).Ran(src.Data);
            return token;
        }

        public WfExecToken Ran<T,D>(WfExecFlow<T> src, D data)
        {
            var token = Tokens.CloseExecToken(src.Token);
            WfEvents.signal(this).Ran(data);
            return token;
        }

        [MethodImpl(Inline)]
        public WfExecToken NextExecToken()
            => Tokens.NextExecToken();


        public void Dispose()
        {
            Broker.Dispose();
            WfSink.Dispose();
            Services.Dispose();
        }

        string ITextual.Format()
            => AppName;
    }
}