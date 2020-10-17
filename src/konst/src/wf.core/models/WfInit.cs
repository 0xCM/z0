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

    /// <summary>
    /// Captures workflow configuration data
    /// </summary>
    public struct WfInit : IWfInit
    {
        /// <summary>
        /// The context root
        /// </summary>
        public IWfContext Shell {get;}

        /// <summary>
        /// The configured paths
        /// </summary>
        public IWfPaths Paths {get;}

        /// <summary>
        /// The entry assembly
        /// </summary>
        public Assembly Control {get;}

        /// <summary>
        /// The entry assembly identifier
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
        public IApiParts ApiParts {get;}

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

        public ISystemApiCatalog Api {get;}

        [MethodImpl(Inline)]
        public WfInit(IWfContext shell, IApiParts parts)
        {
            Shell = shell;
            ApiParts = parts;
            Control = Assembly.GetEntryAssembly();
            Args = shell.Args;
            Paths = shell.Paths;
            Api = ApiParts.Api;
            ControlId = Part.ExecutingPart;
            TargetArchive = new ArchiveConfig(FS.dir(Paths.LogRoot.Name) + FS.folder("capture/artifacts"));
            PartIdentities = WfShell.parse(Args, Api.PartIdentities);
            Resources = new ArchiveConfig(Paths.ResourceRoot);
            Settings = WfShell.settings(Shell);
            Logs = new WfLogConfig(ControlId, Paths.AppLogRoot, FS.dir(@"j:\database\logs\wf"));
        }
    }
}