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

        public WfConfig Config {get;}

        public ModuleArchive Modules {get;}

        readonly IWfEventLog Log;

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

        public IShellPaths AppPaths {get;}

        public ApiParts Api {get;}

        public string ShellName {get;}

        public IPart[] Parts {get;}

        public PartId[] PartIdentities {get;}

        public Assembly Control {get;}

        [MethodImpl(Inline)]
        public WfShell(WfConfig config)
        {
            Config = config;
            Id = config.ControlId;
            Ct = correlate(Id);
            Log = Flow.log(config);
            WfSink = Flow.termlog(Log, Ct);
            Shell = insist(Config.Shell);
            Modules = Config.Modules;
            Api = Modules.Api;
            Parts = Api.Parts;
            Components = Parts.Select(x => x.Owner);
            Paths = Shell.AppPaths;
            Args = Shell.Args;
            Control = Assembly.GetEntryAssembly();
            ShellName = Control.GetSimpleName();
            AppPaths = Paths;
            CaptureRoot = FS.dir((Paths.LogRoot + FolderName.Define("capture/artifacts")).Name);
            AppDataRoot = Paths.AppDataRoot;
            PartIdentities = Parts.Select(x => x.Id);
            Settings = SettingValues.Load(Paths.AppConfigPath);
            ResourceRoot = FolderPath.Define(Config.ResDir.Name);
            IndexRoot = FolderPath.Define(Config.IndexDir.Name);
            Broker = new WfBroker(WfSink, Ct);
        }

        public void Dispose()
        {
            Broker.Dispose();
            Log.Dispose();
        }

        string ITextual.Format()
            => ShellName;
   }
}