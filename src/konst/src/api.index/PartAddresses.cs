//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using HC = KeyValuePairs<MemoryAddress,ApiCodeBlock>;

    public readonly struct PartAddresses
    {
        public readonly PartId[] Parts;

        readonly HC Data;

        [MethodImpl(Inline)]
        public PartAddresses(PartId[] parts, HC src)
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
    }
}