//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using KVP = KeyValuePairs<MemoryAddress,ApiCodeBlock>;

    public readonly struct PartCodeAddresses
    {
        public readonly PartId[] Parts;

        readonly KVP Data;

        [MethodImpl(Inline)]
        public PartCodeAddresses(PartId[] parts, KVP src)
        {
            Data = src;
            Parts = parts;
        }

        public MemoryAddress[] Locations
        {
            [MethodImpl(Inline)]
            get => Data.Keys;
        }

        public ApiCodeBlock[] Encoded
        {
            [MethodImpl(Inline)]
            get => Data.Values;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Count;
        }

        public ApiCodeBlock this[MemoryAddress src]
        {
            [MethodImpl(Inline)]
            get => Data[src];
        }

        public static PartCodeAddresses Empty
        {
            [MethodImpl(Inline)]
            get => new PartCodeAddresses(sys.empty<PartId>(), KVP.Empty);
        }
    }
}