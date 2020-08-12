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

    public struct WfConfig
    {    
        public string[] Args;

        public PartId[] Parts;        

        public ArchiveConfig Source;

        public ArchiveConfig Target;

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