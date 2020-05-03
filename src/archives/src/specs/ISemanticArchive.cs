//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Seed;

    using static FileSystem;

    public readonly struct SemanticArchive : ISemanticArchive
    {
        public static ISemanticArchive Service => default(SemanticArchive);        
    }

    public interface ISemanticArchive : IArchive
    {
        FolderName SemanticFolder 
            => FolderName.Define("semantic");

        FolderPath SemanticDir(Type t)
            => AppDataDir(t) + SemanticFolder;
        
        FileName SemanticFileName(ApiHostUri host, FileExtension ext) 
            => HostFileName(host,ext);

        FilePath SemanticPath(Type t, ApiHostUri host, FileExtension ext = null) 
            => SemanticDir(t) + SemanticFileName(host,ext ?? FileExtensions.Txt);

        FilePath SemanticPath(Type t, PartId part, OpIdentity id, FileExtension ext = null) 
            => SemanticDir(t) + OpFileName(part, id, ext ?? FileExtensions.Txt);

        FilePath SemanticPath(Type t, ApiHostUri host, OpIdentity id, FileExtension ext = null) 
            => SemanticDir(t) + OpFileName(host, id, ext ?? FileExtensions.Txt);

    }
}