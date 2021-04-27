//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct BlobIndex : IHeapKey<BlobIndex>
    {
        public HeapKind HeapKind => HeapKind.Blob;

        public uint Value {get;}

        [MethodImpl(Inline)]
        public BlobIndex(uint value)
        {
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator HeapKey(BlobIndex src)
            => new HeapKey(src.HeapKind, src.Value);

        [MethodImpl(Inline)]
        public static implicit operator HeapKey<BlobHeap>(BlobIndex src)
            => new HeapKey<BlobHeap>(src.Value);
    }
}