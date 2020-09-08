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

    using static ImageLiterals;

    partial struct ImageTables
    {
        public readonly struct ImageOffsets
        {
            public readonly bool Pe64;

            public readonly uint HeaderOffset;

            public readonly uint OptionalHeaderOffset;

            public readonly uint SpecificHeaderOffset;

            public readonly uint DataDirectoryOffset;

            public readonly uint ImageDataDirectoryOffset;

            public static ImageOffsets FromHeaderIndex(uint pos)
                => new ImageOffsets(pos);

            public ImageOffsets(uint index, bool is64 = true)
            {
                HeaderOffset = index + sizeof(uint);
                Pe64 = is64;
                OptionalHeaderOffset = HeaderOffset + (uint)Unsafe.SizeOf<Image.IMAGE_FILE_HEADER>();
                SpecificHeaderOffset = OptionalHeaderOffset + (uint)Unsafe.SizeOf<OptionalHeaderA>();
                DataDirectoryOffset = SpecificHeaderOffset + (Pe64 ? 5*8u : 6*4u);
                ImageDataDirectoryOffset = DataDirectoryOffset + ImageDataDirectoryCount + (uint)Unsafe.SizeOf<DirectoryEntry>();
            }
        }
    }
}