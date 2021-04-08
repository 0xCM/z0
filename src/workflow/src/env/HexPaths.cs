//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;
    using X = FS.Extensions;

    partial interface IEnvPaths
    {
        FS.FolderPath ApiHexRoot()
            => CaptureRoot() + FS.folder(hex);

        FS.Files ApiHexPaths()
            => ApiHexRoot().Files(X.Hex);

        FS.FilePath ApiHexPath(FS.FileName name)
            => ApiHexRoot() + name;

        FS.FilePath ApiHexPath(ApiHostUri host)
            => ApiHexPath(ApiFiles.filename(host, X.Hex));

        FS.FilePath ApiHexPath(FS.FolderPath root, FS.FileName name)
            => ApiHexDir(root) + name;

        FS.FilePath ApiHexPath(FS.FolderPath root, ApiHostUri host)
            => root + PartFolder(host.Part) + HostFile(host, X.Hex);

        FS.FilePath ApiHexPath(PartId part, string api)
            => ApiHexRoot() + ApiFileName(part, api, X.Hex);
        FS.FileName ApiHexFileName(OpIdentity id)
            => LegalFileName(id, X.Hex);

        FS.FolderPath ApiHexDir(FS.FolderPath root)
            => (root + FS.folder(hex));

        FS.Files ApiHexPaths(PartId part)
            => ApiHexPaths().Where(f => f.IsOwner(part));
    }
}