//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct JsonDeps
    {
        public struct RuntimeAssetGroup
        {
            //
            // Summary:
            //     The runtime ID associated with this group (may be empty if the group is runtime-agnostic)
            public string Runtime;

            //
            // Summary:
            //     Gets a list of asset paths provided in this runtime group
            public IndexedSeq<FS.FilePath> AssetPaths;

            //
            // Summary:
            //     Gets a list of RuntimeFiles provided in this runtime group
            public IndexedSeq<FS.FilePath> RuntimeFiles;
        }
    }
}