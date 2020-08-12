//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow    
    {
        [MethodImpl(Inline), Op]
        public static WfConfigData data(WfConfig src)
        {
            var dst = new WfConfigData();
            dst.SelectedParts = src.Parts;
            dst.SourceArchive = src.Source.ArchiveRoot;
            dst.TargetArchive = src.Target.ArchiveRoot;
            dst.Settings = src.Settings;
            dst.ResourceStage = src.ResourceStage;
            dst.AppDataRoot = src.AppData;
            dst.LogPath = src.LogPath;
            dst.IndexRoot = src.IndexRoot;
            return dst;
        }
    }
}