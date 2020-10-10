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
        /// The specified log configuration
        /// </summary>
        public WfLogConfig Logs {get;}

        public SystemApiCatalog Api {get;}

        [MethodImpl(Inline)]
        public WfInit(IShellContext shell, ApiPartSet modules)
        {
            Shell = shell;
            Modules = modules;
            Args = shell.Args;
            Paths = shell.Paths;
            Api = Modules.Api;
            ControlId = Part.ExecutingPart;
            TargetArchive = new ArchiveConfig(FS.dir(Paths.LogRoot.Name) + FS.folder("capture/artifacts"));
            PartIdentities = WfShell.parts(Args, Api.PartIdentities);
            Resources = new ArchiveConfig(Paths.ResourceRoot);
            Settings = WfShell.settings(Shell);
            Logs = new WfLogConfig(ControlId, Paths.AppLogRoot);
        }
    }
}