//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath CacheRoot()
            => Env.CacheRoot;

        FS.FolderPath CacheRoot(FS.FolderPath root)
            => root;
    }
}