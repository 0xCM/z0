//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    
    public readonly struct Archives : IArchives
    {
        public static IArchives Services => default(Archives);    
    }
    
    public readonly struct ArchiveOps : IArchiveOps
    {
        public static IArchiveOps Service => default(ArchiveOps);
    }

    public interface IArchives : IStateless<Archives>
    {        
        ISemanticArchive Semantic => SemanticArchive.Service;

        FolderPath DefaultRootDir => Env.Current.LogDir;

        IUriHexReader UriHexReader => new UriHexReader();

        [MethodImpl(Inline)]
        IUriHexArchive UriBitsArchive(FolderPath root = null)
            => new UriHexArchive(root ?? DefaultRootDir);
        
        [MethodImpl(Inline)]
        IUriHexWriter UriHexWriter(FilePath dst)
            => new UriHexWriter(dst);

        UriHexWriterFactory UriHexWriterFactory
            => dst => UriHexWriter(dst);        

        [MethodImpl(Inline)]
        IUriCodeWriter UriCodeWriter(FilePath dst)
            => new UriCodeWriter(dst);        

        [MethodImpl(Inline)]
        IApiIndexBuilder IndexBuilder(IApiSet api, IMemberLocator locator)
            => new ApiIndexBuilder(api,locator);

        [MethodImpl(Inline)]
        ICaptureArchive CaptureArchive(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => new CaptureArchive(root ?? DefaultRootDir, area ?? FolderName.Empty, subject ?? FolderName.Empty);
        
        [MethodImpl(Inline)]
        IHostCaptureArchive HostCapture(FolderPath root, ApiHostUri host) 
            => new HostCaptureArchive(root ?? DefaultRootDir, host);
        

    }
}