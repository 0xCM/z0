//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct SemanticArchive : ISemanticArchive
    {
        public static ISemanticArchive Service => default(SemanticArchive);        
    }

    public interface ISemanticArchive : IArchive
    {
        FolderName SemanticFolder 
            => FolderName.Define("semantic");
        
        FileExtension SemanticExt 
            => FileExtensions.Txt;

        FolderPath SemanticDir(FolderName folder)
            => ExeSubDir(folder) + SemanticFolder;

        FolderPath SemanticDir(ApiHostUri host)
            => ExeSubDir(SemanticFolder) + HostPart(host);

        FileName SemanticFileName(ApiHostUri host, FileExtension ext) 
            => LegalFileName(host,ext);

        FilePath SemanticPath(ApiHostUri host) 
            => SemanticDir(host) + SemanticFileName(host, SemanticExt);

        FilePath SemanticPath(FolderName folder, PartId part, OpIdentity id) 
            => SemanticDir(folder) + LegalFileName(part, id, SemanticExt);

        FilePath SemanticPath(ApiHostUri host, OpIdentity id) 
            => SemanticDir(host) + LegalFileName(id, SemanticExt);

    }
}