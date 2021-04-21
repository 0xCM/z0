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

        public MetadataReader MetadataReader {get;}

        public PEMemoryBlock MetadataBlock {get;}

        public ImageMetaReader(FS.FilePath src)
        {
            Source = src;
            Stream = File.OpenRead(src.Name);
            PeReader = new PEReader(Stream);
            MetadataReader = PeReader.GetMetadataReader();
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
            => src.Iter(handle => dst(MetadataReader.GetCustomAttribute(handle)));

        [MethodImpl(Inline)]
        public PEMemoryBlock ReadSectionData(DirectoryEntry src)
            => PeReader.GetSectionData(src.RelativeVirtualAddress);


        internal static string format(FieldAttributes src)
            => src.ToString();

        // public ReadOnlySpan<MemberField> Fields()
        // {
        //     var reader = MetadataReader;
        //     var handles = reader.FieldDefinitions.ToReadOnlySpan();
        //     var count = handles.Length;
        //     var dst = memory.span<MemberField>(count);

        //     for(var i=0u; i<count; i++)
        //     {
        //         ref readonly var handle = ref skip(handles,i);
        //         var entry = reader.GetFieldDefinition(handle);
        //         int offset = entry.GetOffset();
        //         seek(dst,i) = new MemberField(i, FieldName(entry.Name, i), sig(entry, i), format(entry.Attributes));
        //     }
        //     return dst;
        // }

        public MemberFieldName FieldName(StringHandle handle, Count seq)
        {
            var value = MetadataReader.GetString(handle);
            var offset = MetadataReader.GetHeapOffset(handle);
            var size = MetadataReader.GetHeapSize(HeapIndex.String);
            return new MemberFieldName(seq, size, (Address32)offset, value);
        }

    }
}