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

        ISemanticArchive Semantic => SemanticArchive.Service;

        FolderPath DefaultRootDir => Env.Current.LogDir;

        [MethodImpl(Inline)]
        IOperationalArchive Operational(FolderPath root) 
            => new OperationalArchive(root);

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
            => new CaptureArchive(root ?? DefaultRootDir, area ?? FolderName.Empty, subject ?? FolderName.Empty);
        
        [MethodImpl(Inline)]
        IHostCaptureArchive HostCapture(FolderPath root, ApiHostUri host) 
            => new HostCaptureArchive(root ?? DefaultRootDir, host);
        
        [MethodImpl(Inline)]
        IHostBitsArchive HostBits(PartId part, FolderPath root = null)
            => new HostBitsArchive(part, root ?? DefaultRootDir);

        [MethodImpl(Inline)]
        IHostBitsArchive HostBits(PartId part, ApiHostUri host, FolderPath root = null)
            => new HostBitsArchive(part, host, root ?? DefaultRootDir);
    }
}