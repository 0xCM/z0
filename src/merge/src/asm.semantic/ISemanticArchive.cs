//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ISemanticArchive : IPartFilePaths
    {
        FS.FolderName SemanticFolder {get;}

        FS.FileExt SemanticExt {get;}

        FS.FolderPath SemanticDir(FS.FolderName folder);

        FS.FolderPath SemanticDir(PartId part);

        FS.FileName SemanticFileName(ApiHostUri host, FS.FileExt ext);

        FS.FilePath SemanticPath(ApiHostUri host);
    }

    public interface ISemanticArchive<H> : ISemanticArchive
        where H : struct, ISemanticArchive<H>
    {

    }
}