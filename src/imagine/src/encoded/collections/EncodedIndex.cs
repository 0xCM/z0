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

    using static Konst;

    public readonly struct EncodedIndex : IEncodedIndex
    {
        readonly HashTable<MemoryAddress,MemberCode> MemoryTable;
        
        readonly HashTable<MemoryAddress,OpUri> MemoryUri; 

        readonly Dictionary<ApiHostUri,MemberCode[]> HostCode;

        public PartId[] Parts {get;}

        public EncodedIndex(PartId[] parts, 
            HashTable<MemoryAddress,MemberCode> members, 
            HashTable<MemoryAddress,OpUri> memuri, 
            Dictionary<ApiHostUri,MemberCode[]> hostcode
            )
        {
            Parts = parts;
            MemoryTable = members;
            MemoryUri = memuri;
            HostCode = hostcode;
        }
        
        /// <summary>
        /// The number of indexed functions
        /// </summary>
        public int EntryCount 
        {
            [MethodImpl(Inline)]
            get => MemoryTable.Count;
        }
        
        /// <summary>
        /// The base addresses that identify entries in the index
        /// </summary>
        public MemoryAddress[] LocationKeys 
        {
            [MethodImpl(Inline)]
            get => MemoryTable.Keys;
        }

        /// <summary>
        /// All indexed code
        /// </summary>
        public MemberCode[] IndexedCode 
        {
            [MethodImpl(Inline)]
            get => MemoryTable.Values;
        }

        /// <summary>
        /// Operation idenfiers, each of which are associated with one or more code blocks
        /// </summary>
        public OpUri[] Operations 
        {
            [MethodImpl(Inline)]
            get => MemoryUri.Values;
        }

        /// <summary>
        /// Hosts with at least one archived code block
        /// </summary>
        public ApiHostUri[] Hosts
        {
            get => HostCode.Keys.ToArray();
        }

        [MethodImpl(Inline)]
        public MemberCode Code(MemoryAddress location)
            => MemoryTable[location];

        [MethodImpl(Inline)]
        public MemberCodeIndex CodeSet(ApiHostUri id)
            => Encoded.index(id, HostCode[id]);

        [MethodImpl(Inline)]
        public PartCodeIndex CodeSet(PartId id)
            => Encoded.index(id, Hosts.Map(CodeSet));

        public MemberCode this[MemoryAddress location]
        {
            [MethodImpl(Inline)]
            get => Code(location);
        }

        public MemberCodeIndex this[ApiHostUri id]
        {
            [MethodImpl(Inline)]
            get => CodeSet(id);
        }

        public PartCodeIndex this[PartId id]
        {
            [MethodImpl(Inline)]
            get => CodeSet(id);
        }

        EncodedIndex(int i)
        {
            MemoryTable = HashTable<MemoryAddress,MemberCode>.Empty;
            MemoryUri = HashTable<MemoryAddress,OpUri>.Empty;
            HostCode = new Dictionary<ApiHostUri, MemberCode[]>();
            Parts = Root.array<PartId>();
        }

        public static EncodedIndex Empty 
            => new EncodedIndex(0);
    }
}