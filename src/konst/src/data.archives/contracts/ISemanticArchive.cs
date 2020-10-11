//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISemanticArchive : IPartFilePaths
    {
        FS.FolderName SemanticFolder
            => FS.folder("asm.semantic");

        FS.FileExt SemanticExt
            => FS.ext("txt");

        FS.FolderPath SemanticDir(FS.FolderName folder)
            => DbPaths.create().DocRoot() + SemanticFolder + folder;

        FS.FolderPath SemanticDir(PartId part)
            => SemanticDir(FS.folder(part.Format()));

        FS.FileName SemanticFileName(ApiHostUri host, FS.FileExt ext)
            => LegalFileName(host,ext);

        FS.FilePath SemanticPath(ApiHostUri host)
            => SemanticDir(host.Owner) + SemanticFileName(host, SemanticExt);
    }

    public interface ISemanticArchive<H> : ISemanticArchive
        where H : struct, ISemanticArchive<H>
    {

    }
}