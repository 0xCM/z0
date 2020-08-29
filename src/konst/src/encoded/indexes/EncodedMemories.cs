//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using KVP = KeyValuePairs<MemoryAddress,X86ApiCode>;

    public readonly struct EncodedMemories
    {
        public readonly PartId[] Parts;

        readonly KVP Data;

        [MethodImpl(Inline)]
        internal EncodedMemories(PartId[] parts, KVP src)
        {
            Data = src;
            Parts = parts;
        }

        public MemoryAddress[] Locations
        {
            [MethodImpl(Inline)]
            get => Data.Keys;
        }

        public X86ApiCode[] Encoded
        {
            [MethodImpl(Inline)]
            get => Data.Values;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public X86ApiCode this[MemoryAddress src]
        {
            [MethodImpl(Inline)]
            get => Data[src];
        }

        public static EncodedMemories Empty
            => new EncodedMemories(sys.empty<PartId>(), KVP.Empty);
    }
}