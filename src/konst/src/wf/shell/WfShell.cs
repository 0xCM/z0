//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    [ApiHost(ApiNames.WfShell, true)]
    public partial class WfShell : IWfShell
    {
        public PartId Id {get;}

        public IWfContext Shell {get;}

        public IWfInit Init {get;}

        public IApiParts ApiParts {get;}

        public IWfEventSink WfSink {get;}

        public IWfBroker Broker {get;}

        public string[] Args {get;}

        public IWfPaths Paths {get;}

        public IJsonSettings Settings {get;}

        public CorrelationToken Ct {get;}

        public ISystemApiCatalog Api {get;}

        public string AppName {get;}

        public WfController Controller {get;}

        public IPolyrand Random {get; private set;}

        public WfHost Host {get; private set;}

        IWfShell Wf => this;

        [MethodImpl(Inline)]
        public WfShell(IWfInit config)
        {
            Init = config;
            Id = config.ControlId;
            Ct = correlate(config.ControlId);
            WfSink = WfLogs.events(config.Logs);
            Broker = new WfBroker(WfSink, Ct);
            Host = new WfHost(typeof(WfShell), typeof(WfShell), _ => throw no<WfShell>());
            Random = default;

            Paths = config.Shell.Paths;
            Shell = config.Shell;
            Args = config.Shell.Args;
            Settings = JsonSettings.Load(config.Shell.Paths.AppConfigPath);
            ApiParts = config.ApiParts;
            Api = config.ApiParts.Api;
            Controller = config.Control;
            AppName = config.Shell.AppName;
        }

        WfShell(IWfInit config, CorrelationToken ct, IWfEventSink sink, IWfBroker broker, WfHost host, IPolyrand random)
        {
            Init = config;
            Id = config.ControlId;
            Ct = ct;
            WfSink = sink;
            Broker = broker;
            Host = host;
            Random = random;
            Shell = config.Shell;
            Args = config.Shell.Args;
            Paths = config.Shell.Paths;
            Settings = JsonSettings.Load(config.Shell.Paths.AppConfigPath);
            ApiParts = config.ApiParts;
            Api = config.ApiParts.Api;
            Controller = config.Control;
            AppName = config.Shell.AppName;
        }

        [MethodImpl(Inline)]
        static IWfShell clone(IWfShell src, WfHost host)
            => new WfShell(src.Init, src.Ct, src.WfSink, src.Broker, host, src.Random);

        [MethodImpl(Inline)]
        public IWfShell WithSource(IPolyrand random)
        {
            Random = random;
            return this;
        }

        [MethodImpl(Inline)]
        public IWfShell WithHost(WfHost host)
            => clone(this, host);


        public void Dispose()
        {
            Broker.Dispose();
            WfSink.Dispose();
        }

        string ITextual.Format()
            => AppName;
   }
}