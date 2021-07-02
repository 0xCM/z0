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

            public void Render(ITextBuffer dst)
            {
                root.iter(AssemblyGroups, x => x.Render(dst));
                root.iter(NativeLibraries, x => x.Render(dst));
            }
        }
    }
}