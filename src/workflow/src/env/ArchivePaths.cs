//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    public partial interface IEnvPaths
    {
        FS.FolderPath ArchiveRoot()
            => Env.Archives;

        FS.FolderPath ArchiveRoot(FS.FolderPath root)
            => root;

        FS.FolderPath RepoArchiveDir()
            => BinaryRoot() + FS.folder(source);

        FS.Files RepoArchives()
            => RepoArchiveDir().Files(FS.Zip);

        FS.FolderPath BuildArchiveRoot()
            => BinaryRoot() + FS.folder(builds);

    }
}