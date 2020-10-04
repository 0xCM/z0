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

    [ApiHost, SuppressUnmanagedCodeSecurity]
    public unsafe partial class MetadataReader : IDisposable
    {
        public MetadataReader(IWfShell wf, FS.FilePath src)
        {
            Source = MemoryFile.open(src.Name);
            Wf = wf;
            Pe = new PEReader(Source.BaseAddress.Pointer<byte>(), (int)Source.Size);
            ImageSize = Source.Size;
            ImagePointer = Pe.GetEntireImage().Pointer;
            Reader = Pe.GetMetadataReader();
            CliMetadata = Pe.GetMetadata();
        }

        public static MetadataReader create(IWfShell wf, FS.FilePath src)
            => new MetadataReader(wf,src);

        public DebugMetadataHeader DebugMetadataHeader
            => Reader.DebugMetadataHeader;

        public void Dispose()
        {
            Pe.Dispose();
            Source.Dispose();
        }
    }
}