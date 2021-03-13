//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static DbNames;
    using static Part;

    partial interface IEnvPaths
    {
        FS.FolderPath ImmRoot()
            => CaptureRoot() + FS.folder(imm);

        FS.Files ImmAsmFiles()
            => ImmRoot().Files(Asm, true);

        FS.Files ImmHexFiles()
            => ImmRoot().Files(Hex, true);

        FS.FolderPath[] ImmDirs(PartId part)
            => ImmRoot().SubDirs().Where(d => d.Name.EndsWith(part.Format()));

        FS.FolderPath[] ImmHostDirs(PartId part)
            => ImmDirs(part).SelectMany(path => path.SubDirs());

        FS.FolderPath[] ImmHostDirs(params PartId[] parts)
            => parts.SelectMany(ImmHostDirs);

        FS.FolderPath ImmSubDir(FS.FolderName name)
            => (ImmRoot() + name);

        FS.FilePath HexImmPath(PartId owner, ApiHostUri host, OpIdentity id, bool refined)
            => ImmSubDir(FS.folder(owner.Format(), host.Name)) + id.ToFileName(refined ? "r" : EmptyString, Hex);

        FS.FilePath AsmImmPath(PartId owner, ApiHostUri host, OpIdentity id, bool refined)
            => ImmSubDir(FS.folder(owner.Format(), host.Name)) + id.ToFileName(refined ? "r" : EmptyString, Asm);
    }
}