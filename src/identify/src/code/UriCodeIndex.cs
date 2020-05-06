//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;

    public readonly struct UriCodeIndex : IUriCodeIndex
    {
        public static UriCodeIndex Empty => new UriCodeIndex(0);
        
        readonly HashTable<MemoryAddress,UriCode> MemoryTable;
        
        readonly HashTable<MemoryAddress,OpUri> MemoryUri;              

        internal UriCodeIndex(
            IReadOnlyDictionary<MemoryAddress,UriCode> mc, 
            IReadOnlyDictionary<MemoryAddress,OpUri> muri)
        {
            MemoryTable = HashTable.Create(mc);
            MemoryUri = HashTable.Create(muri);  
        }

        public int EntryCount 
        {
            [MethodImpl(Inline)]
            get => MemoryTable.Count;
        }
        
        public MemoryAddress[] IndexedMemory 
        {
            [MethodImpl(Inline)]
            get => MemoryTable.Keys;
        }

        public UriCode[] IndexedCode 
        {
            [MethodImpl(Inline)]
            get => MemoryTable.Values;
        }

        public OpUri[] IncludedOps 
        {
            [MethodImpl(Inline)]
            get => MemoryUri.Values;
        }

        [MethodImpl(Inline)]
        public UriCode CodeAt(MemoryAddress location)
            => MemoryTable[location];

        [MethodImpl(Inline)]
        public UriCode[] CodeFor(OpUri uri)
            => MemoryUri[uri].Map(CodeAt);

        public UriCode this[MemoryAddress location]
        {
            [MethodImpl(Inline)]
            get => CodeAt(location);
        }

        public UriCode[] this[OpUri uri]
        {
            [MethodImpl(Inline)]
            get => CodeFor(uri);
        }

        UriCodeIndex(int i)
        {
            MemoryTable = HashTable<MemoryAddress,UriCode>.Empty;
            MemoryUri = HashTable<MemoryAddress,OpUri>.Empty;
        }
    }
}