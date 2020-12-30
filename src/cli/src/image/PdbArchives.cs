//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.IO;

    using static Konst;

    public readonly struct PdbArchives
    {
        public unsafe static MetadataReaderProvider provider(byte* pSrc, ByteSize size)
            => MetadataReaderProvider.FromPortablePdbImage(pSrc, size);

        public static MetadataReaderProvider provider(Stream src, MetadataStreamOptions options = MetadataStreamOptions.Default)
            => MetadataReaderProvider.FromPortablePdbStream(src, options);
    }
}