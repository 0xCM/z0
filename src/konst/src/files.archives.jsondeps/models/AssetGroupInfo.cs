//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct JsonDepsModel
    {
        public struct AssetGroupInfo
        {
            public string Runtime;

            public Index<FS.FilePath> AssetPaths;

            public Index<RuntimeFileInfo> RuntimeFiles;
        }
    }
}