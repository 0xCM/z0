//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Konst;

    partial class PeTableReader
    {
        [Op]
        public static ImageBlob blob(in ReaderState state, BlobHandle handle, Count32 seq)
        {
            var offset = (Address32)state.Reader.GetHeapOffset(handle);
            var value = state.Reader.GetBlobBytes(handle) ?? sys.empty<byte>();
            var size = state.Reader.GetHeapSize(HeapIndex.Blob);
            return new ImageBlob(seq, size, offset,value);
        }
    }
}