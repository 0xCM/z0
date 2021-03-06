//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IDbPaths : IEnvPaths, IFileArchive
    {
        FS.FolderPath IFileArchive.Root
            => DbRoot();
    }
}