//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static DbNames;
    using static Part;

    using X = FS.Extensions;

    partial interface IEnvPaths
    {
        FS.FolderPath ImmRoot()
            => CaptureRoot() + FS.folder(imm);

        FS.Files ImmAsmFiles()
            => ImmRoot().Files(X.Asm, true);

        FS.Files ImmHexFiles()
            => ImmRoot().Files(X.Hex, true);

        FS.FolderPath AsmCatalogRoot()
            => TableRoot() + FS.folder(asmcat);

        FS.FilePath AsmCatalogTable<T>()
            where T : struct, IRecord<T>
                => AsmCatalogRoot() + FS.file(TableId<T>(), X.Csv);

        FS.FilePath AsmCatalogFile(FS.FileName name)
                => AsmCatalogRoot() + name;

        FS.FolderPath[] ImmDirs(PartId part)
            => ImmRoot().SubDirs().Where(d => d.Name.EndsWith(part.Format()));

        FS.FolderPath[] ImmHostDirs(PartId part)
            => ImmDirs(part).SelectMany(path => path.SubDirs());

        FS.FolderPath[] ImmHostDirs(params PartId[] parts)
            => parts.SelectMany(ImmHostDirs);

        FS.FolderPath ImmSubDir(FS.FolderName name)
            => (ImmRoot() + name);

        FS.FilePath HexImmPath(PartId owner, ApiHostUri host, OpIdentity id, bool refined)
            => ImmSubDir(FS.folder(owner.Format(), host.Name)) + id.ToFileName(refined ? "r" : EmptyString, X.Hex);

        FS.FilePath AsmImmPath(PartId owner, ApiHostUri host, OpIdentity id, bool refined)
            => ImmSubDir(FS.folder(owner.Format(), host.Name)) + id.ToFileName(refined ? "r" : EmptyString, X.Asm);
    }
}