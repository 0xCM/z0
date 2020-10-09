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
    using System.IO;
    using System.Linq;

    using static Konst;
    using static z;

    using SysReader = System.Reflection.Metadata.MetadataReader;

    [ApiHost, SuppressUnmanagedCodeSecurity]
    public unsafe partial class ImageMemoryMap : IDisposable
    {
        public ImageMemoryMap(IWfShell wf, FS.FilePath src)
        {
            Source = MemoryFile.open(src.Name);
            Wf = wf;
            BasePointer = Source.BaseAddress.Pointer<byte>();
            Pe = new PEReader(BasePointer, (int)Source.Size);
            ImageSize = Source.Size;
            Reader = Pe.GetMetadataReader();
            CliMetadata = Pe.GetMetadata();
        }

        public static ImageMemoryMap create(IWfShell wf, FS.FilePath src)
            => new ImageMemoryMap(wf,src);

        public void Dispose()
        {
            Pe.Dispose();
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
            get => Pe.PEHeaders;
        }

        public ReadOnlySpan<SectionHeader> SectionHeaders
        {
            [MethodImpl(Inline)]
            get => PeHeaders.SectionHeaders.ToReadOnlySpan();
        }

        [MethodImpl(Inline)]
        public PEMemoryBlock SectonData(DirectoryEntry src)
            => Pe.GetSectionData(src.RelativeVirtualAddress);

        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<byte> Read(PEMemoryBlock src)
            => z.cover<byte>(src.Pointer, (uint)src.Length);

        public ReadOnlySpan<byte> Resources
        {
            [MethodImpl(Inline)]
            get => Read(SectonData(ResourceDirectory));
        }

        public IWfShell Wf;

        readonly MemoryFile Source;

        readonly PEReader Pe;

        readonly SysReader Reader;

        ulong ImageSize;

        readonly Ptr<byte> BasePointer;

        readonly PEMemoryBlock CliMetadata;
    }
}