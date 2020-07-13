//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public interface TArchives : TArchiveServices
    {        


    }
    
    public interface TArchiveServices
    {
        TAppPaths AppPathDefault
            => AppPaths.Default;

        FolderPath LogRoot 
            => AppPathDefault.LogRoot;

        FolderPath CaptureRoot
            => AppPathDefault.CaptureRoot;

        TSemanticArchive Semantic 
            => SemanticArchive.Service;

        IEncodedHexReader EncodedHexReader 
            => new EncodedHexReader();

        [MethodImpl(Inline)]
        IEncodedHexArchive EncodedHexArchive(FolderPath root = null)
            => new EncodedHexArchive(root ?? LogRoot);
        
        [MethodImpl(Inline)]
        IdentifiedCodeWriter IdentifiedCodeWriter(FilePath dst)
            => new IdentifiedCodeWriter(dst);

        [MethodImpl(Inline)]
        MemberCodeWriter MemberCodeWriter(FilePath dst)
            => new MemberCodeWriter(dst);        

        [MethodImpl(Inline)]
        TPartCaptureArchive CaptureArchive(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => CaptureArchiveService.create(root ?? LogRoot, area ?? FolderName.Empty, subject ?? FolderName.Empty);    
    }
}