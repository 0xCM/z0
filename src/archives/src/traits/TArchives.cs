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

        IEncodedHexReader UriHexReader 
            => new EncodedHexReader();

        [MethodImpl(Inline)]
        IEncodedHexArchive HexArchive(FolderPath root = null)
            => new EncodedHexArchive(root ?? LogRoot);
        
        [MethodImpl(Inline)]
        IIdentifiedCodeWriter UriHexWriter(FilePath dst)
            => new UriHexWriter(dst);

        UriHexWriterFactory UriHexWriterFactory
            => dst => UriHexWriter(dst);        

        [MethodImpl(Inline)]
        IMemberCodeWriter UriCodeWriter(FilePath dst)
            => new UriCodeWriter(dst);        

        [MethodImpl(Inline)]
        IApiIndexBuilder IndexBuilder(IApiSet api, IMemberLocator locator)
            => new ApiIndexBuilder(api,locator);

        [MethodImpl(Inline)]
        TCaptureArchive CaptureArchive(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => new CaptureArchive(root ?? LogRoot, area ?? FolderName.Empty, subject ?? FolderName.Empty);
        
        [MethodImpl(Inline)]
        THostCaptureArchive HostCapture(FolderPath root, ApiHostUri host) 
            => new HostCaptureArchive(root ?? LogRoot, host);    

        IdentifiedCode[] SaveUriHex(ApiHostUri host, ParsedExtract[] src, FilePath dst)
            => Z0.UriHexWriter.save(host,src,dst);
    }
}