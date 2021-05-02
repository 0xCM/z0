//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;
    using static Part;

    partial interface IEnvPaths
    {
        FS.Files ImmAsmFiles()
            => ImmCaptureRoot().Files(FS.Asm, true);

        FS.Files ImmHexFiles()
            => ImmCaptureRoot().Files(FS.Hex, true);

        FS.FolderPath[] ImmDirs(PartId part)
            => ImmCaptureRoot().SubDirs().Where(d => d.Name.EndsWith(part.Format()));

        FS.FolderPath[] ImmHostDirs(PartId part)
            => ImmDirs(part).SelectMany(path => path.SubDirs());

        FS.FolderPath[] ImmHostDirs(params PartId[] parts)
            => parts.SelectMany(ImmHostDirs);

        FS.FolderPath ImmSubDir(FS.FolderName name)
            => (ImmCaptureRoot() + name);

        FS.FilePath HexImmPath(PartId owner, ApiHostUri host, OpIdentity id, bool refined)
            => ImmSubDir(FS.folder(owner.Format(), host.Name)) + id.ToFileName(refined ? "r" : EmptyString, FS.Hex);

        FS.FilePath AsmImmPath(PartId owner, ApiHostUri host, OpIdentity id, bool refined)
            => ImmSubDir(FS.folder(owner.Format(), host.Name)) + id.ToFileName(refined ? "r" : EmptyString, FS.Asm);
    }
}