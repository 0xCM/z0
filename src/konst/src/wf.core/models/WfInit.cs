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
        public ApiPartSet Modules {get;}

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

        public SystemApiCatalog Api {get;}

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
            => Resources.Root;

        public FS.FolderPath IndexDir
            => ResDir + FS.folder("index");

        [MethodImpl(Inline)]
        public WfInit(IShellContext shell, string[] args, ApiPartSet modules)
        {
            Shell = insist(shell);
            Paths = shell.Paths;
            Args = args;
            Modules = modules;
            Api = Modules.Api;
            ControlId = Part.ExecutingPart;
            TargetArchive = new ArchiveConfig(FS.dir(Paths.LogRoot.Name) + FS.folder("capture/artifacts"));
            PartIdentities = WfCore.parts(args, Api.PartIdentities);
            Resources = new ArchiveConfig(Paths.ResourceRoot);
            AppData = new ArchiveConfig(Paths.AppDataRoot);
            Settings = WfCore.settings(Shell);
            Logs = new WfLogConfig(ControlId, Paths.AppLogRoot);
        }
    }
}