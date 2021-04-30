//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;

    using static Part;

    partial struct Images
    {
        public readonly struct BlobIndex : IHeapKey<BlobIndex>
        {
            public HeapKind HeapKind => HeapKind.Blob;

            public uint Value {get;}

            [MethodImpl(Inline)]
            public BlobIndex(uint src)
            {
                Value = src;
            }

            [MethodImpl(Inline)]
            public BlobIndex(BlobHandle src)
            {
                Value = memory.u32(src);
            }

            [MethodImpl(Inline)]
            public static implicit operator BlobIndex(BlobHandle src)
                => new BlobIndex(src);

            [MethodImpl(Inline)]
            public static implicit operator HeapKey(BlobIndex src)
                => new HeapKey(src.HeapKind, src.Value);

            [MethodImpl(Inline)]
            public static implicit operator HeapKey<BlobHeap>(BlobIndex src)
                => new HeapKey<BlobHeap>(src.Value);
        }
    }
}