//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;

    using static memory;
    using static Images;
    using static Part;

    partial class ImageMetaReader
    {
        public MetadataBlob ReadSig(FieldDefinition src, Count seq)
            => ReadBlob(src.Signature, seq);

        public MetadataBlob ReadSig(MethodDefinition src, Count seq)
            => ReadBlob(src.Signature, seq);
    }
}