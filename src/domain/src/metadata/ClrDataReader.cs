//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;

    using static Konst;
    using static z;

    using SysReader = System.Reflection.Metadata.MetadataReader;

    [ApiHost, SuppressUnmanagedCodeSecurity]
    public unsafe partial class ClrDataReader : IDisposable
    {
        public ClrDataReader(IWfShell wf, FS.FilePath src)
        {
            Source = MemoryFile.open(src.Name);
            Wf = wf;
            Pe = new PEReader(Source.BaseAddress.Pointer<byte>(), (int)Source.Size);
            ImageSize = Source.Size;
            ImagePointer = Pe.GetEntireImage().Pointer;
            Reader = Pe.GetMetadataReader();
            CliMetadata = Pe.GetMetadata();
        }

        public static ClrDataReader create(IWfShell wf, FS.FilePath src)
            => new ClrDataReader(wf,src);

        public DebugMetadataHeader DebugMetadataHeader
            => Reader.DebugMetadataHeader;

        public void Dispose()
        {
            Pe.Dispose();
            Source.Dispose();
        }

        public IWfShell Wf;

        readonly MemoryFile Source;

        readonly PEReader Pe;

        readonly SysReader Reader;

        ulong ImageSize;

        readonly Ptr<byte> ImagePointer;

        readonly PEMemoryBlock CliMetadata;
    }
}