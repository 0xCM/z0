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
    
    public interface IArchives : IStatelessFactory<Archives>
    {        
        IUriBitsReader UriBitsReader => new UriBitsReader();
        
        [MethodImpl(Inline)]
        ICaptureArchive CaptureArchive(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => new CaptureArchive(root ?? Env.Current.LogDir, area ?? FolderName.Empty, subject ?? FolderName.Empty);
        
        [MethodImpl(Inline)]
        IHostCaptureArchive HostCaptureArchive(ICaptureArchive root, ApiHostUri host) 
            => new HostCaptureArchive(root,host);

        [MethodImpl(Inline)]
        IBitArchiveWriter BitArchiveWriter(FilePath dst)
            => new BitArchiveWriter(dst);
        
        [MethodImpl(Inline)]
        IUriBitsWriter UriBitsWriter(FilePath dst)
            => new UriBitsWriter(dst);

        UriBitsWriterFactory UriBitsWriterFactory
            => dst => UriBitsWriter(dst);
    }
    

}