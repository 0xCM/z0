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
    public struct WfConfig
    {
        /// <summary>
        /// The controlling part
        /// </summary>
        public PartId Control;

        /// <summary>
        /// The controlling arguments, in raw form as supplied by the entry point or caller
        /// </summary>
        public string[] Args;

        /// <summary>
        /// The parts considered by the workflow
        /// </summary>
        public PartId[] Parts;

        /// <summary>
        /// The input data archive configuration
        /// </summary>
        public ArchiveConfig SourceArchive;

        /// <summary>
        /// The output data archive configuration
        /// </summary>
        public ArchiveConfig TargetArchive;

        /// <summary>
        /// The persistent settings supplied by a json.config
        /// </summary>
        public WfSettings Settings;

        /// <summary>
        /// The resource staging area
        /// </summary>
        public ArchiveConfig Resources;

        /// <summary>
        /// The application-specific data root
        /// </summary>
        public ArchiveConfig AppData;

        /// <summary>
        /// The specified log configuration
        /// </summary>
        public WfLogConfig Logs;

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

        [MethodImpl(Inline)]
        public WfConfig(string[] args, ArchiveConfig src, ArchiveConfig dst, PartId[] parts,
            FolderPath resroot, FolderPath appdata, FS.FolderPath logroot, WfSettings settings)
        {
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