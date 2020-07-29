//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.CompilerServices;

    using static PeLiterals;

    public readonly struct PeLiterals
    {
        public const ushort Magical = 0x5A4D;

        public const byte SigOffset = 0x3C;

        public const uint SigExpect = 0x00004550;

        public const byte ImageDataDirectoryCount = 15;

        public const byte ComDataDirectory = 14;

        public const byte DebugDataDirectory = 6;
    }

    public readonly struct PeImageOffsets
    {
        public static PeImageOffsets FromHeaderIndex(int pos)
            => new PeImageOffsets(pos);

        public PeImageOffsets(int index, bool is64 = true)
        {
            HeaderOffset = (uint)index + sizeof(int);
            Pe64 = is64;
            OptionalHeaderOffset = HeaderOffset + (uint)Unsafe.SizeOf<IMAGE_FILE_HEADER>();
            SpecificHeaderOffset = OptionalHeaderOffset + (uint)Unsafe.SizeOf<IMAGE_OPTIONAL_HEADER_AGNOSTIC>();
            DataDirectoryOffset = SpecificHeaderOffset + (Pe64 ? 5*8u : 6*4u);
            ImageDataDirectoryOffset = DataDirectoryOffset + ImageDataDirectoryCount + (uint)Unsafe.SizeOf<IMAGE_DATA_DIRECTORY>();
        }

        public readonly bool Pe64;

        public readonly uint HeaderOffset;

        public readonly uint OptionalHeaderOffset;

        public readonly uint SpecificHeaderOffset;

        public readonly uint DataDirectoryOffset;

        public readonly uint ImageDataDirectoryOffset;
    }
}