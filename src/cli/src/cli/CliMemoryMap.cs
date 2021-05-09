//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using static Part;

    [ApiHost, Free]
    public unsafe partial class CliMemoryMap : IDisposable
    {
        readonly MemoryFile Source;

        public PEReader PeReader {get;}

        public MetadataReader CliReader {get;}

        public ulong ImageSize {get;}

        public Ptr<byte> BasePointer {get;}

        public PEMemoryBlock CliMetadata {get;}

        public CliMemoryMap(IWfRuntime wf, FS.FilePath src)
        {
            Source = MemoryFiles.map(src);
            BasePointer = Source.BaseAddress.Pointer<byte>();
            PeReader = new PEReader(BasePointer, (int)Source.Size);
            ImageSize = Source.Size;
            CliReader = PeReader.GetMetadataReader();
            CliMetadata = PeReader.GetMetadata();
        }

        public static CliMemoryMap create(IWfRuntime wf, FS.FilePath src)
            => new CliMemoryMap(wf,src);


        public void Dispose()
        {
            PeReader.Dispose();
            Source.Dispose();
        }

        public DirectoryEntry ResourceDirectory
        {
            [MethodImpl(Inline)]
            get => PeHeaders.PEHeader.ResourceTableDirectory;
        }

        public PEHeaders PeHeaders
        {
            [MethodImpl(Inline)]
            get => PeReader.PEHeaders;
        }

        public CoffHeader CoffHeader
        {
            [MethodImpl(Inline)]
            get => PeHeaders.CoffHeader;
        }

        public CorHeader CorHeader
        {
            [MethodImpl(Inline)]
            get => PeHeaders.CorHeader;
        }

        [MethodImpl(Inline)]
        public PEMemoryBlock SectonData(DirectoryEntry src)
            => PeReader.GetSectionData(src.RelativeVirtualAddress);

        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<byte> Read(PEMemoryBlock src)
            => memory.cover<byte>(src.Pointer, (uint)src.Length);

        public ReadOnlySpan<byte> Resources
        {
            [MethodImpl(Inline)]
            get => Read(SectonData(ResourceDirectory));
        }
    }
}