//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static PeReaderEvents;
    using static PeLiterals;
    using static z;

    public struct PeImageReader : IDisposable
    {
        readonly IAppEventSink Sink;

        readonly SourceStream Stream;

        bool Succeeded;

        public static Option<PeImage> read(Stream src, bool @virtual, IAppEventSink receiver)
        {
            try
            {
                using var source = Images.source(src,@virtual);
                var dst = new PeImage();
                var reader = new PeImageReader(source, receiver);
                ref var image = ref reader.Read(source, ref dst);
                if(reader.Succeeded)
                    return image;
                else
                    return z.none<PeImage>();
            }
            catch(Exception e)
            {
                receiver.Deposit(AppErrors.define(nameof(PeImageReader), e));
                return z.none<PeImage>();
            }
        }

        public PeImageReader(SourceStream src, IAppEventSink sink)
        {
            Stream = src;
            Sink = sink;
            Succeeded = false;
            Offsets = default;
        }

        [MethodImpl(Inline)]
        public static bool magical(ushort src)
            => src == PeLiterals.Magical;

        PeImageOffsets Offsets;

        ref PeImage Read(SourceStream src, ref PeImage dst)
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
                Sink.Deposit(NoMagic());

            return ref dst;
        }

        void Read(ref PeImage dst)
        {
            if (Stream.TryRead(Offsets.HeaderOffset, out IMAGE_FILE_HEADER header))
                dst.Header = new PeImageHeader(header);

            dst.Directories = ReadDataDirectories(Stream, Offsets.DataDirectoryOffset);
        }

        public void Dispose()
        {
            Stream.Dispose();
        }

        void ReadImageOptionalHeader()
        {
            if (Stream.TryRead(Offsets.OptionalHeaderOffset, out IMAGE_OPTIONAL_HEADER_AGNOSTIC optional))
            {
                var is32Bit = optional.Magic == 0x010b;
                Stream.SeekTo(Offsets.SpecificHeaderOffset);
                var specific = default(IMAGE_OPTIONAL_HEADER_SPECIFIC);
                if(is32Bit)
                    Read(n32, ref specific);
                else
                    Read(n64, ref specific);
            }
        }

        void Read(N32 arch, ref IMAGE_OPTIONAL_HEADER_SPECIFIC dst)
        {
            dst.SizeOfStackReserve = Stream.Read<uint>();
            dst.SizeOfStackCommit = Stream.Read<uint>();
            dst.SizeOfHeapReserve = Stream.Read<uint>();
            dst.SizeOfHeapCommit = Stream.Read<uint>();
            dst.LoaderFlags = Stream.Read<uint>();
            dst.NumberOfRvaAndSizes = Stream.Read<uint>();
        }

        void Read(N64 arch, ref IMAGE_OPTIONAL_HEADER_SPECIFIC dst)
        {
            dst.SizeOfStackReserve = Stream.Read<ulong>();
            dst.SizeOfStackCommit = Stream.Read<ulong>();
            dst.SizeOfHeapReserve = Stream.Read<ulong>();
            dst.SizeOfHeapCommit = Stream.Read<ulong>();
            dst.LoaderFlags = Stream.Read<uint>();
            dst.NumberOfRvaAndSizes = Stream.Read<uint>();
        }


        static IMAGE_DATA_DIRECTORY[] ReadDataDirectories(SourceStream src, uint offset)
        {
            IMAGE_DATA_DIRECTORY[] directories = new IMAGE_DATA_DIRECTORY[ImageDataDirectoryCount];
            src.SeekTo(offset);
            for (int i = 0; i < directories.Length; i++)
                directories[i] = src.Read<IMAGE_DATA_DIRECTORY>();
            return directories;
        }
    }
}