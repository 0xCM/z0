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

    public struct WfShell : IWfShell
    {
        public PartId Id {get;}

        public IShellContext Shell {get;}

        public WfInit Init {get;}

        public ApiPartSet Modules {get;}

        public IWfEventSink WfSink {get;}

        public IWfBroker Broker {get;}

        public Assembly[] Components {get;}

        public string[] Args {get;}

        public IShellPaths Paths {get;}

        public IJsonSettings Settings {get;}

        public CorrelationToken Ct {get;}

        public SystemApiCatalog Api {get;}

        public string ShellName {get;}

        public IPart[] Parts {get;}

        public PartId[] PartIdentities {get;}

        public Assembly Control {get;}

        public IPolyrand Random {get; private set;}

        public ApiContext ApiContext {get;}

        [MethodImpl(Inline)]
        public WfShell(WfInit config)
        {
            Init = config;
            Id = config.ControlId;
            Ct = correlate(Id);
            WfSink = WfLogs.events(config.Logs);
            Shell = insist(Init.Shell);
            Modules = Init.Modules;
            Api = Modules.Api;
            Parts = Api.Storage;
            Components = Api.Components;
            Paths = Shell.Paths;
            Args = Shell.Args;
            Control = Assembly.GetEntryAssembly();
            ShellName = Control.GetSimpleName();
            Paths = Paths;
            PartIdentities = Parts.Select(x => x.Id);
            Settings = JsonSettings.Load(Paths.AppConfigPath);
            Random = default;
            Broker = new WfBroker(WfSink, Ct);
            ApiContext = new ApiContext(new ApiContextState(Modules));
        }

        [MethodImpl(Inline)]
        public IWfShell WithSource(IPolyrand random)
        {
            Random = random;
            return this;
        }

        [MethodImpl(Inline)]
        public WfShell<S> WithState<S>(S src)
            => new WfShell<S>(this, src);

        public void Dispose()
        {
            Broker.Dispose();
            WfSink.Dispose();
        }

        string ITextual.Format()
            => ShellName;
   }
}