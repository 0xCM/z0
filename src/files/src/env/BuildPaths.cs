//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath BuildLogRoot()
            => LogRoot() + FS.folder("build");

        FS.FilePath BuildLogPath(FS.FileName src)
            => BuildLogRoot() + src;

        FS.FolderPath BuildArchiveRoot()
            => BinaryRoot() + FS.folder(builds);
    }
}