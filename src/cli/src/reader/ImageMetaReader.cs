//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.Reflection.Metadata.Ecma335;
    using System.IO;
    using System.Linq;

    using static Part;
    using static memory;

    public partial class ImageMetaReader : IDisposable
    {
        readonly FS.FilePath Source;

        readonly FileStream Stream;

        public PEReader PeReader {get;}

        public MetadataReader MD {get;}

        public PEMemoryBlock MetadataBlock {get;}

        readonly CliReader CliReader;

        public ImageMetaReader(FS.FilePath src)
        {
            Source = src;
            Stream = File.OpenRead(src.Name);
            PeReader = new PEReader(Stream);
            MD = PeReader.GetMetadataReader();
            MetadataBlock = PeReader.GetMetadata();
            CliReader = Cli.reader(MetadataBlock);
        }

        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan<byte> Read(PEMemoryBlock src)
            => memory.cover<byte>(src.Pointer, (uint)src.Length);

        public void Dispose()
        {
            PeReader?.Dispose();
            Stream?.Dispose();
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

        public ReadOnlySpan<SectionHeader> SectionHeaders
        {
            [MethodImpl(Inline)]
            get => PeHeaders.SectionHeaders.ToReadOnlySpan();
        }

        public ReadOnlySpan<MemberReferenceHandle> MemberRefHandles
            => MD.MemberReferences.ToArray();

        public DirectoryEntry ResourcesDirectory
            => CorHeader.ResourcesDirectory;

        public DirectoryEntry CodeManagerTableDirectory
            => CorHeader.CodeManagerTableDirectory;

        public DirectoryEntry ExportAddressTableJumpsDirectory
            => CorHeader.ExportAddressTableJumpsDirectory;

        public CorFlags Flags
            => CorHeader.Flags;

        public DirectoryEntry ManagedNativeHeaderDirectory
            => CorHeader.ManagedNativeHeaderDirectory;

        public DirectoryEntry MetadataDirectory
            => CorHeader.MetadataDirectory;

        public DirectoryEntry VtableFixupsDirectory
            => CorHeader.VtableFixupsDirectory;

        [MethodImpl(Inline), Op]
        public void ReadAttributes(Index<CustomAttributeHandle> src, Receiver<CustomAttribute> dst)
            => src.Iter(handle => dst(MD.GetCustomAttribute(handle)));

        [MethodImpl(Inline)]
        public PEMemoryBlock ReadSectionData(DirectoryEntry src)
            => PeReader.GetSectionData(src.RelativeVirtualAddress);

        internal static string format(FieldAttributes src)
            => src.ToString();
    }
}