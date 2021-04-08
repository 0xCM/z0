//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath CaptureRoot()
            => DbRoot() + FS.folder(capture);

        FS.FolderPath AsmRoot()
            => CaptureRoot() + FS.folder(asm);

        FS.Files AsmPaths()
            => AsmRoot().Files(FS.Asm,true);

        FS.Files AsmPaths(PartId part)
            => AsmPaths().Where(f => f.IsOwner(part));

        FS.FilePath AsmPath(ApiHostUri host)
            => AsmRoot() + ApiFiles.filename(host, FS.Asm);

        FS.FilePath AsmPath(FS.FolderPath root, ApiHostUri host)
            => root + PartFolder(host.Part) +  ApiFiles.filename(host, FS.Asm);

        FS.FilePath AsmStatementPath(ApiHostUri host, FS.FileExt ext)
            => TableRoot() + FS.folder("asm.statements") + PartFolder(host.Part) + HostFile(host, ext);

        FS.FilePath AsmPath(PartId part, string api)
            => AsmRoot() + ApiFileName(part, api, FS.Asm);

        FS.FilePath AsmPath(Type host)
            => AsmPath(host.HostUri());

        FS.FilePath AsmPath<T>()
            => AsmPath(typeof(T).HostUri());

        FS.FileName AsmFileName(OpIdentity id)
            => LegalFileName(id, FS.Asm);

        FS.FolderPath AsmCatalogRoot()
            => TableRoot() + FS.folder(asmcat);

        FS.FilePath AsmCatalogTable<T>()
            where T : struct, IRecord<T>
                => AsmCatalogRoot() + FS.file(TableId<T>(), FS.Csv);

        FS.FilePath AsmCatalogPath(FS.FileName name)
            => AsmCatalogRoot() + name;
    }
}