//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

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
            public IndexedView<FS.FilePath> AssetPaths;

            //
            // Summary:
            //     Gets a list of RuntimeFiles provided in this runtime group
            public IndexedView<FS.FilePath> RuntimeFiles;
        }


        public struct RuntimeAssetGroups
        {
            public IndexedView<RuntimeAssetGroup> Data;


            [MethodImpl(Inline)]
            public RuntimeAssetGroups(RuntimeAssetGroup[] src)
            {
                Data = src;
            }

            [MethodImpl(Inline)]
            public static implicit operator RuntimeAssetGroups(RuntimeAssetGroup[] src)
                => new RuntimeAssetGroups(src);
        }
    }
}