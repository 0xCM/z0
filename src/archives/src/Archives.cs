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

        IBitArchiveReader BitArchiveReader => new BitArchiveReader();

        UriBitsWriterFactory UriBitsWriterFactory
            => dst => UriBitsWriter(dst);        

        [MethodImpl(Inline)]
        IBitArchiveWriter BitArchiveWriter(FilePath dst)
            => new BitArchiveWriter(dst);        

        [MethodImpl(Inline)]
        IUriBitsWriter UriBitsWriter(FilePath dst)
            => new UriBitsWriter(dst);

        [MethodImpl(Inline)]
        ICaptureArchive CaptureArchive(FolderPath root = null, FolderName area = null, FolderName subject = null)
            => new CaptureArchive(root ?? Env.Current.LogDir, area ?? FolderName.Empty, subject ?? FolderName.Empty);
        
        [MethodImpl(Inline)]
        IHostCaptureArchive HostCaptureArchive(ICaptureArchive root, ApiHostUri host) 
            => new HostCaptureArchive(root,host);
        
        [MethodImpl(Inline)]
        IHostBitsArchive HostBits(PartId part, FolderPath root = null)
            =>new HostBitsArchive(part, root);

        [MethodImpl(Inline)]
        IHostBitsArchive HostBits(PartId part, ApiHostUri host, FolderPath root = null)
            => new HostBitsArchive(part, host, root);
    }
}