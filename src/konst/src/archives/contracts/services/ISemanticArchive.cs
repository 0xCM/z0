//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISemanticArchive : IPartFilePaths
    {
        FolderName SemanticFolder
            => FolderName.Define("semantic");

        FileExtension SemanticExt
            => FileExtensions.Txt;

        FolderPath SemanticDir(FolderName folder)
            => (ResRoot + SemanticFolder) + folder;

        FolderPath SemanticDir(PartId part)
            => SemanticDir(FolderName.Define(part.Format()));

        FileName SemanticFileName(ApiHostUri host, FileExtension ext)
            => LegalFileName(host,ext);

        FilePath SemanticPath(ApiHostUri host)
            => SemanticDir(host.Owner) + SemanticFileName(host, SemanticExt);
    }

    public interface ISemanticArchive<H> : ISemanticArchive
        where H : struct, ISemanticArchive<H>
    {

    }
}