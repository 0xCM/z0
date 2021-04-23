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
    using static Images;

    [ApiHost]
    public partial class ImageMetaReader : IDisposable
    {
        public static ImageMetaReader create(FS.FilePath src)
            => new ImageMetaReader(src);

        [Op]
        public static bool create(FS.FilePath src, out ImageMetaReader dst)
        {
            if(HasMetadata(src))
            {
                dst = new ImageMetaReader(src);
                return true;
            }
            else
            {
                dst = default;
                return false;
            }
        }

        [Op]
        public static bool HasMetadata(FS.FilePath src)
        {
            using var stream = File.OpenRead(src.Name);
            using var reader = new PEReader(stream);
            return reader.HasMetadata;
        }

        readonly FS.FilePath Source;

        readonly FileStream Stream;

        public PEReader PeReader {get;}

        public MetadataReader MD {get;}

        public PEMemoryBlock MetadataBlock {get;}

        public ImageMetaReader(FS.FilePath src)
        {
            Source = src;
            Stream = File.OpenRead(src.Name);
            PeReader = new PEReader(Stream);
            MD = PeReader.GetMetadataReader();
            MetadataBlock = PeReader.GetMetadata();
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

        public ClrTableEntry TableEntry(Handle src)
        {
            var table = Clr.table(src);
            if(table != null)
                return new ClrTableEntry(MD.GetToken(src), table.Value);

            return ClrTableEntry.Empty;
        }



        internal static string format(FieldAttributes src)
            => src.ToString();
    }
}