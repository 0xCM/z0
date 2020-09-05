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

    public struct WfContext : IWfShell
    {
        public IShellContext Shell {get;}

        public WfConfig Config {get;}

        public ModuleArchive Modules {get;}

        public IWfEventSink WfSink {get;}

        public IWfBroker Broker {get;}

        public IShellPaths Paths
            => Shell.AppPaths;

        public ISettings Settings
            => SettingValues.Load(Paths.AppConfigPath);

        public FS.FolderPath CaptureRoot
            => FS.dir((AppPaths.LogRoot + FolderName.Define("capture/artifacts")).Name);

        public CorrelationToken Ct
             => Shell.Ct;

        public string[] Args
            => Shell.Args;

        public FolderPath AppDataRoot
            => Shell.AppPaths.AppDataRoot;

        public FolderPath IndexRoot
            => FolderPath.Define(Config.IndexDir.Name);

        public FolderPath ResourceRoot
             => FolderPath.Define(Config.ResDir.Name);

        public IShellPaths AppPaths
            => Shell.AppPaths;

        public IApiSet Api
             => Modules.Api;

        public string ShellName
            => Control.GetSimpleName();
        string ITextual.Format()
            => ShellName;

        public IPart[] Parts
            => Api.Parts;

        public PartId[] PartIdList
            => Api.Parts.Select(x => x.Id);

        public Assembly[] Components
            => Api.Components;

        public Assembly Control
            => Assembly.GetEntryAssembly();

        [MethodImpl(Inline)]
        public WfContext(WfConfig config, IWfEventSink sink)
        {
            Shell = z.insist(config.Shell);
            WfSink = z.insist(sink);
            Config = config;
            Modules = config.Modules;
            Broker = new WfBroker(sink, Shell.Ct);
        }


        public void Dispose()
        {
            Broker.Dispose();
        }
   }
}