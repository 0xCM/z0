//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Captures workflow configuration data
    /// </summary>
    public struct WfConfig : IWfConfig<WfConfig>
    {
        /// <summary>
        /// The context root
        /// </summary>
        public IShellContext Shell {get;}

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
        public ModuleArchive SourceArchive {get;}

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
        public FS.FilePath StatusLog
            => Logs.StatusLog;

        /// <summary>
        /// The application-specific error log path
        /// </summary>
        public FS.FilePath ErrorLog
            => Logs.ErrorLog;

        public FS.FolderPath ResRoot
            => FS.dir(Resources.Root.Name);

        public FS.FolderPath IndexRoot
            => ResRoot + FS.folder("index");

        public ApiSet Api {get;}

        [MethodImpl(Inline)]
        public WfConfig(IShellContext root, string[] args, ModuleArchive src, ArchiveConfig dst, PartId[] parts,
            FolderPath resroot, FolderPath appdata, FS.FolderPath logroot, WfSettings settings)
        {
            Api = src.Api;
            Shell = root;
            Control = Part.ExecutingPart;
            Args = args;
            SourceArchive = src;
            TargetArchive = dst;
            Parts = parts;
            Resources = new ArchiveConfig(resroot);
            AppData = new ArchiveConfig(appdata);
            Settings = settings;
            Logs = new WfLogConfig(Control, logroot);
        }
    }
}