//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using KVP = KeyValuePairs<MemoryAddress,ApiHex>;

    public readonly struct ApiHexAddresses
    {
        public readonly PartId[] Parts;

        readonly KVP Data;

        [MethodImpl(Inline)]
        public ApiHexAddresses(PartId[] parts, KVP src)
        {
            Data = src;
            Parts = parts;
        }

        public MemoryAddress[] Locations
        {
            [MethodImpl(Inline)]
            get => Data.Keys;
        }

        public ApiHex[] Encoded
        {
            [MethodImpl(Inline)]
            get => Data.Values;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Count;
        }

        public ApiHex this[MemoryAddress src]
        {
            [MethodImpl(Inline)]
            get => Data[src];
        }

        public static ApiHexAddresses Empty
            => new ApiHexAddresses(sys.empty<PartId>(), KVP.Empty);
    }
}