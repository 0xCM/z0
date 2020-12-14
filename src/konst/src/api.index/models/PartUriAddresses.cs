//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using LU = System.Collections.Generic.Dictionary<MemoryAddress,OpUri>;

    public readonly struct PartUriAddresses
    {
        public readonly PartId[] Parts;

        readonly LU Data;

        [MethodImpl(Inline)]
        public PartUriAddresses(PartId[] parts, LU src)
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

        public static PartUriAddresses Empty
        {
            [MethodImpl(Inline)]
            get => new PartUriAddresses(sys.empty<PartId>(), new LU());
        }
    }
}