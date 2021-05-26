//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FilePath CdbLogPath()
            => Env.CdbLogPath.Value;

        FS.FolderPath SymbolRoot()
            => Env.SymCacheRoot;

        FS.FolderPath NtSymbolDir()
            => Env.DefaultSymbolCache;
    }
}