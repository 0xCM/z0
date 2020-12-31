//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct JsonDepsModel
    {
        public struct RuntimeLibraryInfo
        {
            public Index<AssetGroupInfo> AssemblyGroups;

            public Index<AssetGroupInfo> NativeLibraries;

            public Index<ResourceAssembly> ResourceAssemblies;
        }
    }
}