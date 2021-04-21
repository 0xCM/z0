//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection.Metadata;

    using static Images;

    partial class PeTableReader
    {
        public static MetadataBlob sig(in ReaderState state, FieldDefinition src, Count seq)
            => cover(state).Blob(src.Signature, seq);
    }
}