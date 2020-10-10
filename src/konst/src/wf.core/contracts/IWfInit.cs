//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

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
        ApiPartSet Modules {get;}

        /// <summary>
        /// The configured api set
        /// </summary>
        SystemApiCatalog Api
            => Modules.Api;

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
            => WfShell.parts(Args, Api.PartIdentities);

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
        WfLogConfig Logs
            => new WfLogConfig(ControlId, Shell.Paths.AppLogRoot);

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