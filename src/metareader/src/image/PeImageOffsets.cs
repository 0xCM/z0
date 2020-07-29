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
    using static Konst;
    using static z;

    public readonly struct PeImageOffsets
    {
        public static PeImageOffsets FromHeaderIndex(int pos)
            => new PeImageOffsets(pos);

        public PeImageOffsets(int index, bool is64 = true)
        {
            HeaderOffset = (uint)index + z.size<int>();
            Pe64 = is64;
            OptionalHeaderOffset = HeaderOffset +z.size<IMAGE_FILE_HEADER>();
            SpecificHeaderOffset = OptionalHeaderOffset + z.size<IMAGE_OPTIONAL_HEADER_AGNOSTIC>();
            DataDirectoryOffset = SpecificHeaderOffset + (Pe64 ? 5*8u : 6*4u);
            ImageDataDirectoryOffset = DataDirectoryOffset + ImageDataDirectoryCount + z.size<IMAGE_DATA_DIRECTORY>();
        }

        public readonly bool Pe64;

        public readonly uint HeaderOffset;

        public readonly uint OptionalHeaderOffset;

        public readonly uint SpecificHeaderOffset;

        public readonly uint DataDirectoryOffset;

        public readonly uint ImageDataDirectoryOffset;
    }
}