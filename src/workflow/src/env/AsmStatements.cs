//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static EnvFolders;

    partial interface IEnvPaths
    {
        FS.FolderPath AsmStatementRoot()
            => TableRoot() + FS.folder("asm.statements");

        FS.FolderPath AsmStatementDir(PartId part)
            => AsmStatementRoot() + PartFolder(part);

        FS.FilePath AsmStatementPath(ApiHostUri host, FS.FileExt ext)
            => AsmStatementDir(host.Part) + HostFile(host, ext);

        FS.FileName AsmFileName(OpIdentity id)
            => LegalFileName(id, FS.Asm);
    }
}