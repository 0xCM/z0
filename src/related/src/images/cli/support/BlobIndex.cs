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
    using static CliRecords;

    public readonly struct BlobIndex : ICliHeapKey<BlobIndex>
    {
        public CliHeapKind HeapKind => CliHeapKind.Blob;

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

        public string Format()
            => Value.ToString("X");

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator BlobIndex(BlobHandle src)
            => new BlobIndex(src);

        [MethodImpl(Inline)]
        public static implicit operator CliHeapKey(BlobIndex src)
            => new CliHeapKey(src.HeapKind, src.Value);

        [MethodImpl(Inline)]
        public static implicit operator CliHeapKey<BlobHeap>(BlobIndex src)
            => new CliHeapKey<BlobHeap>(src.Value);
    }
}