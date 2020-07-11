//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public interface TSemanticArchive : TPartFileArchive
    {
        FolderName SemanticFolder 
            => FolderName.Define("semantic");
        
        FileExtension SemanticExt 
            => FileExtensions.Txt;

        FolderPath SemanticDir(FolderName folder)
            => ExeSubDir(folder) + SemanticFolder;

        FolderPath SemanticDir(PartId part)
            => PartDir(part);

        FolderPath SemanticDir(ApiHostUri host)
            => ExeSubDir(SemanticFolder) + HostPartLocation(host);

        FileName SemanticFileName(ApiHostUri host, FileExtension ext) 
            => LegalFileName(host,ext);

        FilePath SemanticPath(ApiHostUri host) 
            => SemanticDir(host.Owner) + SemanticFileName(host, SemanticExt);

        FilePath SemanticPath(FolderName folder, PartId part, OpIdentity id) 
            => SemanticDir(folder) + LegalFileName(part, id, SemanticExt);

        FilePath SemanticPath(ApiHostUri host, OpIdentity id) 
            => SemanticDir(host) + LegalFileName(id, SemanticExt);
    }
}