//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static EnvFolders;

    using X = FS.Extensions;

    partial interface IEnvPaths
    {
        FS.FolderPath CaptureRoot()
            => DbRoot() + FS.folder(capture);

        FS.FolderPath AsmRoot()
            => CaptureRoot() + FS.folder(asm);

        FS.Files AsmPaths()
            => AsmRoot().Files(X.Asm,true);

        FS.Files AsmPaths(PartId part)
            => AsmPaths().Where(f => f.IsOwner(part));

        FS.FilePath AsmPath(ApiHostUri host)
            => AsmRoot() + ApiFiles.filename(host, X.Asm);

        FS.FilePath AsmPath(FS.FolderPath root,ApiHostUri host)
            => root + ApiFiles.filename(host, X.Asm);

        FS.FilePath AsmPath(PartId part, string api)
            => AsmRoot() + ApiFileName(part, api, X.Asm);

        FS.FilePath AsmPath(Type host)
            => AsmPath(host.HostUri());

        FS.FilePath AsmPath<T>()
            => AsmPath(typeof(T).HostUri());

        FS.FileName AsmFileName(OpIdentity id)
            => LegalFileName(id, X.Asm);

        FS.FolderPath AsmCatalogRoot()
            => TableRoot() + FS.folder(asmcat);

        FS.FilePath AsmCatalogTable<T>()
            where T : struct, IRecord<T>
                => AsmCatalogRoot() + FS.file(TableId<T>(), X.Csv);

        FS.FilePath AsmCatalogPath(FS.FileName name)
            => AsmCatalogRoot() + name;
    }
}