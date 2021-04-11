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
            => CaptureRoot() + FS.folder(hex);

        Files ApiHexPaths()
            => ApiHexRoot().Files(Hex);

        FS.FilePath ApiHexPath(FS.FileName name)
            => ApiHexRoot() + name;

        FS.FilePath ApiHexPath(ApiHostUri host)
            => ApiHexPath(ApiFiles.filename(host, Hex));

        FS.FilePath ApiHexPath(FS.FolderPath root, FS.FileName name)
            => ApiHexDir(root) + name;

        FS.FilePath ApiHexPath(FS.FolderPath root, ApiHostUri host)
            => root + PartFolder(host.Part) + HostFile(host, Hex);

        FS.FilePath ApiHexPath(PartId part, string api)
            => ApiHexRoot() + ApiFileName(part, api, Hex);
        FS.FileName ApiHexFileName(OpIdentity id)
            => LegalFileName(id, Hex);

        FS.FolderPath ApiHexDir(FS.FolderPath root)
            => (root + FS.folder(hex));

        FS.Files ApiHexPaths(PartId part)
            => ApiHexPaths().Where(f => f.IsOwner(part));
    }
}