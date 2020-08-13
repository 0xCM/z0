//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

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

        public FolderPath ResourceStage;
        
        public FolderPath AppData;

        public FilePath LogPath;

        public FolderPath IndexRoot;
        
        [MethodImpl(Inline)]
        public WfConfig(string[] args, ArchiveConfig src, ArchiveConfig dst, PartId[] parts, FolderPath resroot, FolderPath appdata, WfSettings settings)
        {
            Args = args;
            Source = src;
            Target = dst;
            Parts = parts;
            ResourceStage = resroot;
            AppData = appdata;
            Settings = settings;
            LogPath = AppData + FileName.Define("workflow", FileExtensions.Csv);
            IndexRoot = ResourceStage + FolderName.Define("index");
        }    
    }
}