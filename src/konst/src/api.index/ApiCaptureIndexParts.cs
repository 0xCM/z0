//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    public readonly struct ApiCaptureIndexParts
    {
        public readonly struct UriAddresses
        {
            public readonly PartId[] Parts;

            readonly Dictionary<MemoryAddress, OpUri> Data;

            [MethodImpl(Inline)]
            public UriAddresses(PartId[] parts, Dictionary<MemoryAddress, OpUri> src)
            {
                Parts = parts;
                Data = src;
            }

            public OpUri[] Identities
            {
                [MethodImpl(Inline)]
                get => Data.Values.Array();
            }

            public MemoryAddress[] Addresses
            {
                [MethodImpl(Inline)]
                get => Data.Keys.Array();
            }

            public uint Count
            {
                [MethodImpl(Inline)]
                get => (uint)Data.Count;
            }
        }
    }
}