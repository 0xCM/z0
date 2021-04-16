//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.CompilerServices;

    using static Part;
    using static HeapIndexKinds;

    public readonly struct BlobIndex : IHeapIndex<BlobIndexKind,BlobIndex>
    {
        public uint Key {get;}

        [MethodImpl(Inline)]
        public BlobIndex(uint value)
            => Key = value;

        [MethodImpl(Inline)]
        public static implicit operator BlobIndex(uint value)
            => new BlobIndex(value);

        [MethodImpl(Inline)]
        public static implicit operator BlobIndex(int value)
            => new BlobIndex((uint)value);
    }
}