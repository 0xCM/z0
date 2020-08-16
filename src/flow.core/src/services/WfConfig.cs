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
        /// The controlling arguments, in raw form as supplied by the entry point or caller
        /// </summary>
        public string[] Args;

        /// <summary>
        /// The parts considered by the workflow
        /// </summary>
        public PartId[] Parts;        

        /// <summary>
        /// Input data archive
        /// </summary>        
        public ArchiveConfig Source;

        /// <summary>
        /// Output data archive
        /// </summary>        
        public ArchiveConfig Target;

        /// <summary>
        /// The persistent settings supplied by a json.config
        /// </summary>
        public WfSettings Settings;

        /// <summary>
        /// The resource staging area
        /// </summary>
        public FS.FolderPath ResStage;
        
        /// <summary>
        /// The application-specific data root
        /// </summary>
        public FS.FolderPath AppData;
        
        /// <summary>
        /// The application-specific log root
        /// </summary>
        public FS.FolderPath LogRoot;
        
        /// <summary>
        /// The application-specific status log path
        /// </summary>
        public FS.FilePath StatusPath;

        /// <summary>
        /// The application-specific error log path
        /// </summary>
        public FS.FilePath ErrorPath;

        public FS.FolderPath IndexRoot;
        
        [MethodImpl(Inline)]
        public WfConfig(string[] args, 
            ArchiveConfig src, 
            ArchiveConfig dst, 
            PartId[] parts, 
            FolderPath resroot, 
            FolderPath appdata, 
            WfSettings settings, 
            FS.FolderPath? logroot = null, 
            FS.FilePath? status = null, 
            FS.FilePath? error = null)
        {
            Args = args;
            Source = src;
            Target = dst;
            Parts = parts;
            ResStage = FS.dir(resroot.Name);
            AppData = FS.dir(appdata.Name);
            Settings = settings;
            LogRoot = logroot ?? FS.dir(AppData.Name);
            StatusPath = status ?? FS.path(LogRoot,  FS.file("status", "csv"));
            ErrorPath = error ?? (LogRoot + FS.file("errors", "csv"));
            IndexRoot = ResStage + FS.folder("index");
        }    
    }
}