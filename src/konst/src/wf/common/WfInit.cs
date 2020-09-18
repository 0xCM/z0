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
    public struct WfInit : IWfInit
    {
        /// <summary>
        /// The context root
        /// </summary>
        public IShellContext Shell {get;}

        /// <summary>
        /// The configured paths
        /// </summary>
        public IShellPaths Paths {get;}

        /// <summary>
        /// The controlling part
        /// </summary>
        public PartId ControlId {get;}

        /// <summary>
        /// The controlling arguments, in raw form as supplied by the entry point or caller
        /// </summary>
        public string[] Args {get;}

        /// <summary>
        /// The parts considered by the workflow
        /// </summary>
        public PartId[] PartIdentities {get;}

        /// <summary>
        /// The input data archive configuration
        /// </summary>
        public ApiModules Modules {get;}

        /// <summary>
        /// The output data archive configuration
        /// </summary>
        public ArchiveSettings TargetArchive {get;}

        /// <summary>
        /// The persistent settings supplied by a json.config
        /// </summary>
        public WfSettings Settings {get;}

        /// <summary>
        /// The resource staging area
        /// </summary>
        public ArchiveSettings Resources {get;}

        /// <summary>
        /// The application-specific data root
        /// </summary>
        public ArchiveSettings AppData {get;}

        /// <summary>
        /// The specified log configuration
        /// </summary>
        public WfLogConfig Logs {get;}

        public ApiParts Api {get;}

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

        // [MethodImpl(Inline)]
        // public WfInit(IShellContext shell, string[] args, ApiModules modules, ArchiveConfig target,
        //     PartId[] parts, FolderPath resroot, FolderPath appdata, FS.FolderPath logroot, WfSettings settings)
        // {
        //     Shell = insist(shell);
        //     Paths = shell.Paths;
        //     Args = args;
        //     Modules = modules;
        //     Api = Modules.Api;
        //     ControlId = Part.ExecutingPart;
        //     TargetArchive = target;
        //     PartIdentities = parts;
        //     Resources = new ArchiveConfig(resroot);
        //     AppData = new ArchiveConfig(appdata);
        //     Settings = settings;
        //     Logs = new WfLogConfig(ControlId, logroot);
        // }

        [MethodImpl(Inline)]
        public WfInit(IShellContext shell, string[] args, ApiModules modules)
        {
            Shell = insist(shell);
            Paths = shell.Paths;
            Args = args;
            Modules = modules;
            Api = Modules.Api;
            ControlId = Part.ExecutingPart;
            TargetArchive = new ArchiveSettings(FS.dir(Paths.LogRoot.Name) + FS.folder("capture/artifacts"));
            PartIdentities = Flow.parts(args, Api.PartIdentities);
            Resources = new ArchiveSettings(Paths.ResourceRoot);
            AppData = new ArchiveSettings(Paths.AppDataRoot);
            Settings = Flow.settings(Shell);
            Logs = new WfLogConfig(ControlId, Paths.AppLogRoot);
        }
    }
}