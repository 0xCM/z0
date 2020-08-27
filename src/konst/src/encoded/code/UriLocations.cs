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

    public readonly struct UriLocations
    {
        public readonly PartId[] Parts;

        readonly KVP Data;

        [MethodImpl(Inline)]
        internal UriLocations(PartId[] parts, KVP src)
        {
            Parts = parts;
            Data = src;
        }

        public MemoryAddress[] Locations
        {
            [MethodImpl(Inline)]
            get => Data.Keys;
        }

        public OpUri[] Identities
        {
            [MethodImpl(Inline)]
            get => Data.Values;
        }

        public int Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }        

        public static UriLocations Empty 
            => new UriLocations(sys.empty<PartId>(), KVP.Empty);        
    }
}