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

        public AppArgs Args {get;}

        public IWfPaths Paths {get;}

        public IJsonSettings Settings {get;}

        public CorrelationToken Ct {get;}

        public ISystemApiCatalog Api {get;}

        public string AppName {get;}

        public WfController Controller {get;}

        public IPolyrand Random {get; private set;}

        public WfHost Host {get; private set;}

        public LogLevel Verbosity {get; private set;}

        IWfShell Wf => this;

        [MethodImpl(Inline)]
        public WfShell(IWfInit config)
        {
            Context = config.Shell;
            Init = config;
            Id = config.ControlId;
            Ct = correlate(config.ControlId);
            WfSink = WfShellInit.log(config.Logs);
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
        }

        WfShell(IWfInit config, CorrelationToken ct, IWfEventSink sink, IWfBroker broker, WfHost host, IPolyrand random, LogLevel verbosity)
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
        }

        [MethodImpl(Inline)]
        static IWfShell clone(IWfShell src, WfHost host, IPolyrand random, LogLevel verbosity)
            => new WfShell(src.Init, src.Ct, src.WfSink, src.Broker, host, random, verbosity);

        [MethodImpl(Inline)]
        public IWfShell WithRandom(IPolyrand random)
            => clone(this, Host, random, Verbosity);

        [MethodImpl(Inline)]
        public IWfShell WithVerbosity(LogLevel level)
            => clone(this, Host, Random, level);

        [MethodImpl(Inline)]
        public IWfShell WithHost(WfHost host)
            => clone(this, host, Random, Verbosity);

        public void Dispose()
        {
            Broker.Dispose();
            WfSink.Dispose();
        }

        string ITextual.Format()
            => AppName;
    }
}