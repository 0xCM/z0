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

        FolderPath SemanticDir(Type t)
            => DataDir(t) + SemanticFolder;
        
        FileName SemanticFileName(ApiHostUri host, FileExtension ext) 
            => LegalFileName(host,ext);

        FilePath SemanticPath(Type t, ApiHostUri host, FileExtension ext = null) 
            => SemanticDir(t) + SemanticFileName(host,ext ?? FileExtensions.Txt);

        FilePath SemanticPath(Type t, PartId part, OpIdentity id, FileExtension ext = null) 
            => SemanticDir(t) + LegalFileName(part, id, ext ?? FileExtensions.Txt);

        FilePath SemanticPath(Type t, ApiHostUri host, OpIdentity id, FileExtension ext = null) 
            => SemanticDir(t) + LegalFileName(host, id, ext ?? FileExtensions.Txt);
    }
}