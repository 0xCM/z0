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

    [ApiHost(ApiNames.WfShell)]
    public partial struct WfShell : IWfShell
    {
        public PartId Id {get;}

        public IShellContext Shell {get;}

        public IWfInit Init {get;}

        public IApiPartSet ApiParts {get;}

        public IWfEventSink WfSink {get;}

        public IWfBroker Broker {get;}

        public string[] Args {get;}

        public IShellPaths Paths {get;}

        public IJsonSettings Settings {get;}

        public CorrelationToken Ct {get;}

        public ISystemApiCatalog Api {get;}

        public string ShellName {get;}

        public Assembly Control {get;}

        public IPolyrand Random {get; private set;}

        public WfHost Host {get; private set;}

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

            Shell = config.Shell;
            Args = config.Shell.Args;
            Paths = config.Shell.Paths;
            Settings = JsonSettings.Load(config.Shell.Paths.AppConfigPath);
            ApiParts = config.ApiParts;
            Api = config.ApiParts.Api;
            Control = config.Control;
            ShellName = config.Shell.ShellName;
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
            Control = config.Control;
            ShellName = config.Shell.ShellName;
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
        // {
        //     Host = host;
        //     return this;
        // }

        public void Dispose()
        {
            Broker.Dispose();
            WfSink.Dispose();
        }

        string ITextual.Format()
            => ShellName;
   }
}