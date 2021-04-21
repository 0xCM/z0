//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.PortableExecutable;
    using System.IO;
    using System.Linq;

    using static Part;
    using static memory;

    partial class ImageMetaReader
    {
        [MethodImpl(Inline), Op]
        public BinaryCode ReadBlob(BlobHandle src)
            => MetadataReader.GetBlobBytes(src);

        [MethodImpl(Inline), Op]
        public ref BinaryCode ReadBlob(BlobHandle src, ref BinaryCode dst)
        {
            dst = ReadBlob(src);
            return ref dst;
        }
    }
}