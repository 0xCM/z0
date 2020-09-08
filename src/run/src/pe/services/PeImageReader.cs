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

    using static Konst;
    using static z;

    using static ImageReader;
    using static ImageTables;
    using static ImageLiterals;

    public struct PeImageReader : IDisposable
    {
        readonly ImageStream Stream;

        bool Succeeded;

        [MethodImpl(Inline)]
        public PeImageReader(ImageStream src)
        {
            Stream = src;
            Succeeded = false;
            Offsets = default;
        }

        [MethodImpl(Inline)]
        public static bool magical(ushort src)
            => src == Magical;

        ImageOffsets Offsets;

        public Outcome Read(ImageStream src, out ImageContent dst)
        {
            dst = default;
            var magic = src.Read<ushort>(0);
            if(magical(magic))
            {
                var index = src.Read<uint>(SigOffset);
                if(index != 0)
                {
                    Offsets = ImageOffsets.FromHeaderIndex(index);
                    var peSignature = src.Read<int>(index);
                    if(peSignature == SigExpect)
                        Read(ref dst);
                    return true;
                }
            }

            return false;
        }

        public void Read(ref ImageContent dst)
        {
            if (Stream.TryRead(Offsets.HeaderOffset, out ImageHeader header))
                dst.Header = header;

            dst.Directories = ReadDataDirectories(Stream, Offsets.DataDirectoryOffset);
        }

        public bool Read(out ImageHeader dst)
            => Stream.TryRead(Offsets.HeaderOffset, out dst);

        public void Dispose()
        {
            Stream.Dispose();
        }

        void ReadImageOptionalHeader()
        {
            if (Stream.TryRead(Offsets.OptionalHeaderOffset, out OptionalHeaderA optional))
            {
                var is32Bit = optional.Magic == 0x010b;
                Stream.SeekTo(Offsets.SpecificHeaderOffset);
                var specific = default(OptionalHeaderS);
                if(is32Bit)
                    Read(n32, ref specific);
                else
                    Read(n64, ref specific);
            }
        }

        public void Read(N32 arch, ref OptionalHeaderS dst)
        {
            dst.SizeOfStackReserve = Stream.Read<uint>();
            dst.SizeOfStackCommit = Stream.Read<uint>();
            dst.SizeOfHeapReserve = Stream.Read<uint>();
            dst.SizeOfHeapCommit = Stream.Read<uint>();
            dst.LoaderFlags = Stream.Read<uint>();
            dst.NumberOfRvaAndSizes = Stream.Read<uint>();
        }

        public void Read(N64 arch, ref OptionalHeaderS dst)
        {
            dst.SizeOfStackReserve = Stream.Read<ulong>();
            dst.SizeOfStackCommit = Stream.Read<ulong>();
            dst.SizeOfHeapReserve = Stream.Read<ulong>();
            dst.SizeOfHeapCommit = Stream.Read<ulong>();
            dst.LoaderFlags = Stream.Read<uint>();
            dst.NumberOfRvaAndSizes = Stream.Read<uint>();
        }

        public static DirectoryEntry[] ReadDataDirectories(ImageStream src, uint offset)
        {
            DirectoryEntry[] directories = new DirectoryEntry[ImageDataDirectoryCount];
            src.SeekTo(offset);
            for (int i = 0; i < directories.Length; i++)
                directories[i] = src.Read<DirectoryEntry>();
            return directories;
        }
    }
}