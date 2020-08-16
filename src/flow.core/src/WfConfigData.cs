//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using Z0.Data;

    public enum WfConfigDataField : byte
    {
        SelectedParts,

        SourceArchive,

        TargetArchive,

        Settings,

        ResourceStage,

        AppDataRoot,

        LogPath,

        IndexRoot,
    }

    public struct WfConfigData : IDocument<WfConfigDataField,WfConfigData>
    {
        public PartId[] SelectedParts;        

        public FolderPath SourceArchive;

        public FolderPath TargetArchive;

        public WfSettings Settings;

        public FolderPath ResourceStage;
        
        public FolderPath AppDataRoot;

        public FilePath LogPath;

        public FolderPath IndexRoot;                
    }
}