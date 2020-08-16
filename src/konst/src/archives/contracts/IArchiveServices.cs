//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public interface IArchiveServices
    {
        IAppPaths AppPathDefault
            => AppPaths.Default;

        FolderPath LogRoot 
            => AppPathDefault.LogRoot;

        ISemanticArchive Semantic 
            => SemanticArchive.Service;

        IEncodedHexReader EncodedHexReader 
            => new EncodedHexReader();

        [MethodImpl(Inline)]
        IEncodedHexArchive EncodedHexArchive(FolderPath root = null)
            => new EncodedHexArchive(root ?? LogRoot);
        
        [MethodImpl(Inline)]
        MemberCodeWriter MemberCodeWriter(FilePath dst)
            => new MemberCodeWriter(dst);        

        [MethodImpl(Inline)]
        IPartCaptureArchive CaptureArchive(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => CaptureArchives.create(root ?? LogRoot, area ?? FolderName.Empty, subject ?? FolderName.Empty);    

        [MethodImpl(Inline)]
        IPartCaptureArchive CaptureArchive(ArchiveConfig config)
            => CaptureArchives.create(config.ArchiveRoot, FolderName.Empty, FolderName.Empty);                
    }
}