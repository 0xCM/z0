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

        readonly Dictionary<ApiHostUri,UriCode[]> HostCode;

        public PartId[] Parts {get;}

        internal UriCodeIndex(
            IReadOnlyDictionary<MemoryAddress,UriCode> mc, 
            IReadOnlyDictionary<MemoryAddress,OpUri> muri)
        {
            MemoryTable = HashTable.Create(mc);
            MemoryUri = HashTable.Create(muri);  
            HostCode = MemoryTable.Values.Select(x => (x.Uri.HostPath, x))
                                         .GroupBy(g => g.HostPath)
                                         .Select(x => (x.Key, x.Select(y => y.x).ToArray()))
                                         .ToDictionary();
            Parts = HostCode.Keys.Select(x => x.Owner).Distinct().ToArray();
        }

        public int EntryCount 
        {
            [MethodImpl(Inline)]
            get => MemoryTable.Count;
        }
        
        public MemoryAddress[] Addresses 
        {
            [MethodImpl(Inline)]
            get => MemoryTable.Keys;
        }

        public UriCode[] Code 
        {
            [MethodImpl(Inline)]
            get => MemoryTable.Values;
        }

        public OpUri[] Operations 
        {
            [MethodImpl(Inline)]
            get => MemoryUri.Values;
        }

        public ApiHostUri[] Hosts
        {
            get => HostCode.Keys.ToArray();
        }

        [MethodImpl(Inline)]
        public UriCode CodeAt(MemoryAddress location)
            => MemoryTable[location];

        [MethodImpl(Inline)]
        public UriCode[] CodeFor(OpUri uri)
            => MemoryUri[uri].Map(CodeAt);

        [MethodImpl(Inline)]
        public UriCode[] CodeFor(ApiHostUri uri)
            => HostCode[uri];

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

        public UriCode[] this[ApiHostUri uri]
        {
            [MethodImpl(Inline)]
            get => CodeFor(uri);
        }

        UriCodeIndex(int i)
        {
            MemoryTable = HashTable<MemoryAddress,UriCode>.Empty;
            MemoryUri = HashTable<MemoryAddress,OpUri>.Empty;
            HostCode = new Dictionary<ApiHostUri, UriCode[]>();
            Parts = Control.array<PartId>();
        }
    }
}