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

        public IWfEventSink EventSink {get;}

        public IWfEventBroker EventBroker {get;}

        public ICmdRouter Router {get;}

        public string[] Args {get;}

        public IAppPaths Paths {get;}

        public IJsonSettings Settings {get;}

        public CorrelationToken Ct {get;}

        public IApiCatalogDataset Api {get;}

        public string AppName {get;}

        public WfController Controller {get;}

        public IPolySource PolyStream {get; private set;}

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
            EventSink = Loggers.events(config.LogConfig);
            EventBroker = new WfBroker(EventSink, Ct);
            Host = new WfHost(typeof(WfShell), typeof(WfShell), _ => throw no<WfShell>());
            PolyStream = default;
            Verbosity = LogLevel.Status;
            Paths = config.Shell.Paths;
            Args = config.Shell.Args;
            Settings = config.Shell.Settings;
            ApiParts = config.ApiParts;
            Api = config.ApiParts.ApiCatalog;
            Controller = config.Control;
            AppName = config.Shell.AppName;
            Router = new WfCmdRouter(this);
            Services = new WfServices(this, Env, Api.PartComponents);
        }

        internal WfShell(IWfInit config, CorrelationToken ct, IWfEventSink sink, IWfEventBroker broker, WfHost host, IPolySource random, LogLevel verbosity, ICmdRouter router, WfServices wfservices)
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
            Api = config.ApiParts.ApiCatalog;
            Controller = config.Control;
            AppName = config.Shell.AppName;
            Ct = ct;
            EventSink = sink;
            EventBroker = broker;
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
            EventBroker.Dispose();
            EventSink.Dispose();
            Services.Dispose();
        }

        string ITextual.Format()
            => AppName;
    }
}