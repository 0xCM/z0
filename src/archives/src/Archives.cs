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

    public interface IArchives : IStatelessFactory<Archives>
    {        
        ISemanticArchive Semantic => SemanticArchive.Service;

        FolderPath DefaultRootDir => Env.Current.LogDir;

        IUriBitsReader UriBitsReader => new UriBitsReader();

        [MethodImpl(Inline)]
        IUriCodeWriter UriCodeWriter(FilePath dst)
            => new UriCodeWriter(dst);

        [MethodImpl(Inline)]
        IUriBitsWriter UriBitsWriter(FilePath dst)
            => new UriBitsWriter(dst);

        UriBitsWriterFactory UriBitsWriterFactory
            => dst => UriBitsWriter(dst);        

        [MethodImpl(Inline)]
        IHostBitsWriter BitArchiveWriter(FilePath dst)
            => new HostBitsWriter(dst);        

        [MethodImpl(Inline)]
        IApiIndexBuilder IndexBuilder(IApiSet api, IMemberLocator locator)
            => new ApiIndexBuilder(api,locator);

        [MethodImpl(Inline)]
        ICaptureArchive CaptureArchive(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => new CaptureArchive(root ?? DefaultRootDir, area ?? FolderName.Empty, subject ?? FolderName.Empty);
        
        [MethodImpl(Inline)]
        IHostCaptureArchive HostCapture(FolderPath root, ApiHostUri host) 
            => new HostCaptureArchive(root ?? DefaultRootDir, host);
        
        [MethodImpl(Inline)]
        IUriBitsArchive UriBitsArchive(FolderPath root = null)
            => new UriBitsArchive(root ?? DefaultRootDir);
    }
}