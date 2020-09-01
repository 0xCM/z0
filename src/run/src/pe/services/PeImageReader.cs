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
        readonly SourceStream Stream;

        bool Succeeded;


        public PeImageReader(SourceStream src)
        {
            Stream = src;
            Succeeded = false;
            Offsets = default;
        }

        [MethodImpl(Inline)]
        public static bool magical(ushort src)
            => src == Magical;

        PeImageOffsets Offsets;

        public ref ImageContent Read(SourceStream src, ref ImageContent dst)
        {
            var magic = src.Read<ushort>(0);
            if(magical(magic))
            {
                var index = src.Read<int>(SigOffset);
                if(index != 0)
                {
                    Offsets = PeImageOffsets.FromHeaderIndex(index);
                    var peSignature = src.Read<int>((int)index);
                    if(peSignature == SigExpect)
                        Read(ref dst);
                }
            }
            else
            {
                //No magic
            }

            return ref dst;
        }

        public void Read(ref ImageContent dst)
        {
            if (Stream.TryRead(Offsets.HeaderOffset, out ImageHeader header))
                dst.Header = header;

            dst.Directories = ReadDataDirectories(Stream, Offsets.DataDirectoryOffset);
        }

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

        void Read(N32 arch, ref OptionalHeaderS dst)
        {
            dst.SizeOfStackReserve = Stream.Read<uint>();
            dst.SizeOfStackCommit = Stream.Read<uint>();
            dst.SizeOfHeapReserve = Stream.Read<uint>();
            dst.SizeOfHeapCommit = Stream.Read<uint>();
            dst.LoaderFlags = Stream.Read<uint>();
            dst.NumberOfRvaAndSizes = Stream.Read<uint>();
        }

        void Read(N64 arch, ref OptionalHeaderS dst)
        {
            dst.SizeOfStackReserve = Stream.Read<ulong>();
            dst.SizeOfStackCommit = Stream.Read<ulong>();
            dst.SizeOfHeapReserve = Stream.Read<ulong>();
            dst.SizeOfHeapCommit = Stream.Read<ulong>();
            dst.LoaderFlags = Stream.Read<uint>();
            dst.NumberOfRvaAndSizes = Stream.Read<uint>();
        }

        static DirectoryEntry[] ReadDataDirectories(SourceStream src, uint offset)
        {
            DirectoryEntry[] directories = new DirectoryEntry[ImageDataDirectoryCount];
            src.SeekTo(offset);
            for (int i = 0; i < directories.Length; i++)
                directories[i] = src.Read<DirectoryEntry>();
            return directories;
        }
    }
}