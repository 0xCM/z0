//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDiagnosticPaths : IEnvionmental
    {
        FS.FilePath CdbLogPath()
            => Env.CdbLogPath.Value;

        FS.FolderPath SymbolRoot()
            => Env.SymCacheRoot;

        FS.FolderPath NtSymbolDir()
            => Env.DefaultSymbolCache;
    }
}