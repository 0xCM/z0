//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;
    using static FS;

    partial interface IEnvPaths
    {
        FolderPath ApiHexRoot()
            => CaptureRoot() + FS.folder(parsed);

        FS.FolderPath ApiHexDir(FS.FolderPath root)
            => (root + FS.folder(parsed));

        FS.Files ApiHexPaths()
            => ApiHexRoot().Files(PCsv);

        FS.FilePath ApiHexPath(FS.FileName name)
            => ApiHexRoot() + name;

        FS.FilePath ApiHexPath(ApiHostUri host)
            => ApiHexPath(ApiFiles.filename(host, PCsv));

        FS.FilePath ApiHexPath(FS.FolderPath root, FS.FileName name)
            => ApiHexDir(root) + name;

        FS.FilePath ApiHexPath(FS.FolderPath root, ApiHostUri host)
            => root + PartFolder(host.Part) + HostFile(host, PCsv);

        FS.Files ApiHexPaths(PartId part)
            => ApiHexPaths().Where(f => f.IsOwner(part));
    }
}