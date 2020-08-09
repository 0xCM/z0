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

    public readonly struct WfConfig
    {    
        public readonly string[] Args;

        public readonly PartId[] Parts;        

        public readonly ArchiveConfig Source;

        public readonly ArchiveConfig Target;

        public readonly WfSettings Settings;

        public readonly FolderPath ResRoot;
        
        public readonly FolderPath AppData;

        public readonly FilePath LogPath;

        public readonly FolderPath IndexRoot;
        
        [MethodImpl(Inline)]
        public WfConfig(string[] args, ArchiveConfig src, ArchiveConfig dst, PartId[] parts, FolderPath resroot, FolderPath appdata, WfSettings settings)
        {
            Args = args;
            Source = src;
            Target = dst;
            Parts = parts;
            ResRoot = resroot;
            AppData = appdata;
            Settings = settings;
            LogPath = AppData + FileName.Define("workflow", FileExtensions.Csv);
            IndexRoot = ResRoot + FolderName.Define("index");
        }    
    }
}