//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using L = ImageLiterals;

    public struct PeStreamReader : IDisposable
    {
        [MethodImpl(Inline), Op]
        public static PeStreamReader create(ImageStream src)
            => new PeStreamReader(src);

        readonly ImageStream Stream;

        bool Succeeded;

        [MethodImpl(Inline)]
        public PeStreamReader(ImageStream src)
        {
            Stream = src;
            Succeeded = false;
        }

        [MethodImpl(Inline)]
        public static bool magical(ushort src)
            => src == L.Magical;

        // public Outcome Read(ImageStream src, out T.ImageContent dst)
        // {
        //     dst = default;
        //     var magic = src.Read<ushort>(0);
        //     if(magical(magic))
        //     {
        //         var index = src.Read<uint>(L.SigOffset);
        //         if(index != 0)
        //         {
        //             Offsets = T.ImageOffsets.FromHeaderIndex(index);
        //             var peSignature = src.Read<int>(index);
        //             if(peSignature == L.SigExpect)
        //                 Read(ref dst);
        //             return true;
        //         }
        //     }

        //     return false;
        // }

        // public void Read(ref T.ImageContent dst)
        // {
        //     if (Stream.TryRead(Offsets.HeaderOffset, out T.ImageHeader header))
        //         dst.Header = header;

        //     dst.Directories = ReadDataDirectories(Stream, Offsets.DataDirectoryOffset);
        // }

        // public bool Read(out T.ImageHeader dst)
        //     => Stream.TryRead(Offsets.HeaderOffset, out dst);

        public void Dispose()
        {
            Stream.Dispose();
        }

        // void ReadImageOptionalHeader()
        // {
        //     if (Stream.TryRead(Offsets.OptionalHeaderOffset, out T.OptionalHeaderA optional))
        //     {
        //         var is32Bit = optional.Magic == 0x010b;
        //         Stream.SeekTo(Offsets.SpecificHeaderOffset);
        //         var specific = default(T.OptionalHeaderS);
        //         if(is32Bit)
        //             Read(n32, ref specific);
        //         else
        //             Read(n64, ref specific);
        //     }
        // }

        // public void Read(N32 arch, ref T.OptionalHeaderS dst)
        // {
        //     dst.SizeOfStackReserve = Stream.Read<uint>();
        //     dst.SizeOfStackCommit = Stream.Read<uint>();
        //     dst.SizeOfHeapReserve = Stream.Read<uint>();
        //     dst.SizeOfHeapCommit = Stream.Read<uint>();
        //     dst.LoaderFlags = Stream.Read<uint>();
        //     dst.NumberOfRvaAndSizes = Stream.Read<uint>();
        // }

        // public void Read(N64 arch, ref T.OptionalHeaderS dst)
        // {
        //     dst.SizeOfStackReserve = Stream.Read<ulong>();
        //     dst.SizeOfStackCommit = Stream.Read<ulong>();
        //     dst.SizeOfHeapReserve = Stream.Read<ulong>();
        //     dst.SizeOfHeapCommit = Stream.Read<ulong>();
        //     dst.LoaderFlags = Stream.Read<uint>();
        //     dst.NumberOfRvaAndSizes = Stream.Read<uint>();
        // }

        // public static T.DirectoryEntry[] ReadDataDirectories(ImageStream src, uint offset)
        // {
        //     T.DirectoryEntry[] directories = new T.DirectoryEntry[L.ImageDataDirectoryCount];
        //     src.SeekTo(offset);
        //     for (int i = 0; i < directories.Length; i++)
        //         directories[i] = src.Read<T.DirectoryEntry>();
        //     return directories;
        // }
    }
}