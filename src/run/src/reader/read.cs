//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using PEReader = System.Reflection.PortableExecutable.PEReader;

    using static Konst;
    using static z;

    // using static ImageTables;
    using static ImageLiterals;

    public readonly struct ImageLiterals
    {
        public const ushort Magical = 0x5A4D;

        public const byte SigOffset = 0x3C;

        public const uint SigExpect = 0x00004550;

        public const byte ImageDataDirectoryCount = 15;

        public const byte ComDataDirectory = 14;

        public const byte DebugDataDirectory = 6;

        public const byte IMAGE_SIZEOF_SHORT_NAME = 8;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DirectoryEntry
    {
        public uint RelativeVirtualAddress;

        public uint Size;
    }

    public partial struct ImageReader
    {
        [MethodImpl(Inline)]
        public static ImageStream stream(Stream src, bool @virtual)
            => new ImageStream(src, @virtual);

        [MethodImpl(Inline)]
        public static ImageStream stream(FS.FilePath src)
            => new ImageStream(File.OpenRead(src.Name), false);

        public static Outcome<uint> read(FS.FilePath path, out Span<ImageSectionHeader> target)
        {
            using var stream = File.OpenRead(path.Name);
            using var reader = new PEReader(stream);
            var peHeaders = reader.PEHeaders;
            var sections = @readonly(peHeaders.SectionHeaders.Array());
            var count = (uint)sections.Length;
            var filename = path.FileName;

            target = span<ImageSectionHeader>(count);

            for(var i=0u; i<count; i++)
            {
                ref var dst = ref seek(target,i);
                ref readonly var src = ref skip(sections,i);
                dst.File = filename;
                dst.EntryPoint = (Address32)peHeaders.PEHeader.AddressOfEntryPoint;
                dst.CodeBase = (Address32)peHeaders.PEHeader.BaseOfCode;
                dst.GptRva = (Address32)peHeaders.PEHeader.GlobalPointerTableDirectory.RelativeVirtualAddress;
                dst.GptSize = (ByteSize)peHeaders.PEHeader.GlobalPointerTableDirectory.Size;
                dst.SectionAspects = src.SectionCharacteristics;
                dst.SectionName = src.Name;
                dst.RawData = (Address32)src.PointerToRawData;
                dst.RawDataSize = src.SizeOfRawData;
            }

            return count;
        }

        public static Outcome<uint> read(ImageStream src, uint offset, out Span<DirectoryEntry> dst)
        {
            dst = new DirectoryEntry[ImageDataDirectoryCount];
            return read(src, offset, dst);
        }

        public static Outcome<uint> read(ImageStream src, uint offset, Span<DirectoryEntry> dst)
        {
            var count = (uint)dst.Length;
            src.SeekTo(offset);
            for (var i=0u; i<count; i++)
                seek(dst,i) = src.Read<DirectoryEntry>();
            return count;
        }

    }
}