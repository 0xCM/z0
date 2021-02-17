//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static DbNames;

    partial interface IApiPathProvider
    {
        FS.FolderPath ApiHexRoot()
            => CaptureRoot() + FS.folder(hex);

        FS.Files ApiHexFiles()
            => ApiHexRoot().Files(Hex);

        FS.FilePath ApiHexPath(FS.FileName name)
            => ApiHexRoot() + name;

        FS.FileName ApiHexFileName(OpIdentity id)
            => LegalFileName(id, Hex);

        FS.FilePath ApiHexPath(ApiHostUri host)
            => ApiHexRoot()  + FS.file(host.Name, Hex);

        FS.FolderPath ApiHexDir(FS.FolderPath root)
            => (root + FS.folder(hex));

        FS.Files ApiHexFiles(PartId part)
            => ApiHexFiles().Where(f => f.IsOwner(part));

        FS.FilePath ApiHexFile(FS.FolderPath root, FS.FileName name)
            => ApiHexDir(root) + name;

        FS.FilePath ApiHexFile(FS.FolderPath root, ApiHostUri host)
            => ApiHexDir(root) + FS.file(host.Name, Hex);

        FS.FilePath ApiHexFile(FS.FileName name)
            => ApiHexRoot() + name;

        FS.FilePath ApiHexFile(PartId part, string api)
            => ApiHexRoot() + ApiFileName(part, api, Hex);

        FS.FilePath ApiHexFile(ApiHostUri host)
            => ApiHexFile(ApiIdentity.file(host, Hex));
    }
}