//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using Free =System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Konst;

    public interface IWfInit
    {
        /// <summary>
        /// The context root
        /// </summary>
        IShellContext Shell {get;}

        /// <summary>
        /// The input data archive configuration
        /// </summary>
        IApiPartSet ApiParts {get;}

        /// <summary>
        /// The entry assembly
        /// </summary>
        Assembly Control
            => Assembly.GetEntryAssembly();

        /// <summary>
        /// The configured api set
        /// </summary>
        ISystemApiCatalog Api
            => ApiParts.Api;

        /// <summary>
        /// The controlling part
        /// </summary>
        PartId ControlId
            => Part.ExecutingPart;

        /// <summary>
        /// The output data archive configuration
        /// </summary>
        ArchiveConfig TargetArchive
            => new ArchiveConfig(FS.dir(Paths.LogRoot.Name) + FS.folder("capture/artifacts"));

        /// <summary>
        /// The configured paths
        /// </summary>
        IShellPaths Paths
            => Shell.Paths;

        /// <summary>
        /// The parts considered by the workflow
        /// </summary>
        PartId[] PartIdentities
            => WfShell.parse(Args, Api.PartIdentities);

        /// <summary>
        /// The resource staging area
        /// </summary>
        ArchiveConfig Resources
            => new ArchiveConfig(Paths.ResourceRoot);

        /// <summary>
        /// The persistent settings supplied by a json.config
        /// </summary>
        WfSettings Settings
            => WfShell.settings(Shell);

        /// <summary>
        /// The specified log configuration
        /// </summary>
        WfLogConfig Logs {get;}

        /// <summary>
        /// The controlling arguments, in raw form as supplied by the entry point or caller
        /// </summary>
        string[] Args
             => Shell.Args;

        FS.FolderPath ResDir
            => Resources.Root;

        FS.FolderPath IndexDir
            => ResDir + FS.folder("index");
    }
}