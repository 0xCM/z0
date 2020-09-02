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

    /// <summary>
    /// Captures workflow configuration data
    /// </summary>
    public struct WfConfig : IWfConfig<WfConfig>
    {
        /// <summary>
        /// The context root
        /// </summary>
        public IShellContext Shell {get;}

        public IShellPaths Paths {get;}

        /// <summary>
        /// The controlling part
        /// </summary>
        public PartId Control {get;}

        /// <summary>
        /// The controlling arguments, in raw form as supplied by the entry point or caller
        /// </summary>
        public string[] Args {get;}

        /// <summary>
        /// The parts considered by the workflow
        /// </summary>
        public PartId[] Parts {get;}

        /// <summary>
        /// The input data archive configuration
        /// </summary>
        public ModuleArchive Modules {get;}

        /// <summary>
        /// The output data archive configuration
        /// </summary>
        public ArchiveConfig TargetArchive {get;}

        /// <summary>
        /// The persistent settings supplied by a json.config
        /// </summary>
        public WfSettings Settings {get;}

        /// <summary>
        /// The resource staging area
        /// </summary>
        public ArchiveConfig Resources {get;}

        /// <summary>
        /// The application-specific data root
        /// </summary>
        public ArchiveConfig AppData {get;}

        /// <summary>
        /// The specified log configuration
        /// </summary>
        public WfLogConfig Logs {get;}

        /// <summary>
        /// The application-specific status log path
        /// </summary>
        public FS.FilePath StatusPath
            => Logs.StatusLog;

        /// <summary>
        /// The application-specific error log path
        /// </summary>
        public FS.FilePath ErrorPath
            => Logs.ErrorLog;

        public FS.FolderPath ResDir
            => FS.dir(Resources.Root.Name);

        public FS.FolderPath IndexDir
            => ResDir + FS.folder("index");

        public ApiSet Api {get;}

        [MethodImpl(Inline)]
        public WfConfig(IShellContext shell, string[] args, ModuleArchive modules, ArchiveConfig target,
            PartId[] parts, FolderPath resroot, FolderPath appdata, FS.FolderPath logroot, WfSettings settings)
        {
            Shell = insist(shell);
            Paths = shell.AppPaths;
            Args = args;
            Modules = modules;
            Api = Modules.Api;
            Control = Part.ExecutingPart;
            TargetArchive = target;
            Parts = parts;
            Resources = new ArchiveConfig(resroot);
            AppData = new ArchiveConfig(appdata);
            Settings = settings;
            Logs = new WfLogConfig(Control, logroot);
        }

        [MethodImpl(Inline)]
        public WfConfig(IShellContext shell, string[] args, ModuleArchive modules)
        {
            Shell = insist(shell);
            Paths = shell.AppPaths;
            Args = args;
            Modules = modules;
            Api = Modules.Api;
            Control = Part.ExecutingPart;
            TargetArchive = new ArchiveConfig(FS.dir(Paths.LogRoot.Name) + FS.folder("capture/artifacts"));
            Parts = AB.parts(args, Api.PartIdentities);
            Resources = new ArchiveConfig(Paths.ResourceRoot);
            AppData = new ArchiveConfig(Paths.AppDataRoot);
            Settings = AB.settings(Shell);
            Logs = new WfLogConfig(Control, Paths.AppLogRoot);
        }
    }
}