//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using KVP = KeyValuePairs<MemoryAddress,OpUri>;

    public readonly struct ApiUriAddresses
    {
        public readonly PartId[] Parts;

        readonly KVP Data;

        [MethodImpl(Inline)]
        public ApiUriAddresses(PartId[] parts, KVP src)
        {
            Parts = parts;
            Data = src;
        }

        public OpUri[] Identities
        {
            [MethodImpl(Inline)]
            get => Data.Values;
        }

        public MemoryAddress[] Addresses
        {
            [MethodImpl(Inline)]
            get => Data.Keys;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Count;
        }
    }
}