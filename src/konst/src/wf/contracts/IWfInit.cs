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
        /// The configured api set
        /// </summary>
        ApiSet Api {get;}

        /// <summary>
        /// The context root
        /// </summary>
        IShellContext Shell {get;}

        /// <summary>
        /// The controlling part
        /// </summary>
        PartId ControlId {get;}

        /// <summary>
        /// The controlling arguments, in raw form as supplied by the entry point or caller
        /// </summary>
        string[] Args {get;}

        /// <summary>
        /// The parts considered by the workflow
        /// </summary>
        PartId[] PartIdentities {get;}

        /// <summary>
        /// The input data archive configuration
        /// </summary>
        ApiModules Modules {get;}

        /// <summary>
        /// The output data archive configuration
        /// </summary>
        ArchiveConfig TargetArchive {get;}

        /// <summary>
        /// The persistent settings supplied by a json.config
        /// </summary>
        WfSettings Settings {get;}

        /// <summary>
        /// The resource staging area
        /// </summary>
        ArchiveConfig Resources {get;}

        /// <summary>
        /// The application-specific data root
        /// </summary>
        ArchiveConfig AppData {get;}

        /// <summary>
        /// The specified log configuration
        /// </summary>
        WfLogConfig Logs {get;}

        /// <summary>
        /// The application-specific status log path
        /// </summary>
        FS.FilePath StatusPath
            => Logs.StatusLog;

        /// <summary>
        /// The application-specific error log path
        /// </summary>
        FS.FilePath ErrorPath
            => Logs.ErrorLog;

        FS.FolderPath ResDir
            => FS.dir(Resources.Root.Name);

        FS.FolderPath IndexDir
            => ResDir + FS.folder("index");
    }
}