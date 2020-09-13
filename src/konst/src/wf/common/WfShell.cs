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

        public ApiModules Modules {get;}

        public IWfEventSink WfSink {get;}

        public IWfBroker Broker {get;}

        public Assembly[] Components {get;}

        public string[] Args {get;}

        public FolderPath AppDataRoot {get;}

        public IShellPaths Paths {get;}

        public ISettings Settings {get;}

        public FS.FolderPath CaptureRoot {get;}

        public CorrelationToken Ct {get;}

        public FolderPath IndexRoot {get;}

        public FolderPath ResourceRoot {get;}

        public ApiParts Api {get;}

        public string ShellName {get;}

        public IPart[] Parts {get;}

        public PartId[] PartIdentities {get;}

        public Assembly Control {get;}

        [MethodImpl(Inline)]
        public WfShell(WfInit config)
        {
            Init = config;
            Id = config.ControlId;
            Ct = correlate(Id);
            WfSink = Flow.log(config);
            Shell = insist(Init.Shell);
            Modules = Init.Modules;
            Api = Modules.Api;
            Parts = Api;
            Components = Api.Components;
            Paths = Shell.Paths;
            Args = Shell.Args;
            Control = Assembly.GetEntryAssembly();
            ShellName = Control.GetSimpleName();
            Paths = Paths;
            CaptureRoot = FS.dir((Paths.LogRoot + FolderName.Define("capture/artifacts")).Name);
            AppDataRoot = Paths.AppDataRoot;
            PartIdentities = Parts.Select(x => x.Id);
            Settings = SettingValues.Load(Paths.AppConfigPath);
            ResourceRoot = FolderPath.Define(Init.ResDir.Name);
            IndexRoot = FolderPath.Define(Init.IndexDir.Name);
            Broker = new WfBroker(WfSink, Ct);
        }

        public void Dispose()
        {
            Broker.Dispose();
            WfSink.Dispose();
        }

        string ITextual.Format()
            => ShellName;
   }
}