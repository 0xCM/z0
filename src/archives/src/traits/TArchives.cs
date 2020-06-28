//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    public interface TArchives
    {        
        TAppPaths Paths
            => AppPaths.Default;

        FolderPath LogRoot 
            => Paths.LogRoot;

        FolderPath CaptureRoot
            => Paths.CaptureRoot;

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
        ApiIndexBuilder IndexBuilder(IApiSet api, IMemberLocator locator)
            => new ApiIndexBuilder(api,locator);

        [MethodImpl(Inline)]
        TCaptureArchive CaptureArchive(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => new CaptureArchive(root ?? LogRoot, area ?? FolderName.Empty, subject ?? FolderName.Empty);
        
        [MethodImpl(Inline)]
        THostCaptureArchive HostCapture(FolderPath root, ApiHostUri host) 
            => new HostCaptureArchive(root ?? LogRoot, host);    
    }
}