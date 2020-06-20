//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    public class MachineIndex : IMachineIndex
    {
        public static MachineIndex Empty => new MachineIndex(0);

        public static IMachineIndexBuilder Builder 
            => MachineIndexBuilder.Service;
        
        readonly HashTable<MemoryAddress,UriCode> MemoryTable;
        
        readonly HashTable<MemoryAddress,OpUri> MemoryUri; 

        readonly Dictionary<ApiHostUri,UriCode[]> HostCode;

        public PartId[] Parts {get;}

        internal MachineIndex(IReadOnlyDictionary<MemoryAddress,UriCode> mc, IReadOnlyDictionary<MemoryAddress,OpUri> muri)
        {
            MemoryTable = HashTable.Create(mc);
            MemoryUri = HashTable.Create(muri);  
            HostCode = MemoryTable.Values.Select(x => (x.OpUri.Host, x))
                                         .GroupBy(g => g.Host)
                                         .Select(x => (x.Key, x.Select(y => y.x).ToArray()))
                                         .ToDictionary();
            Parts = HostCode.Keys.Select(x => x.Owner).Distinct().ToArray();
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
        public UriCode[] IndexedCode 
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
        public UriCode Code(MemoryAddress location)
            => MemoryTable[location];

        [MethodImpl(Inline)]
        public HostCode CodeSet(ApiHostUri id)
            => new HostCode(id, HostCode[id]);

        [MethodImpl(Inline)]
        public PartCode CodeSet(PartId id)
            => new PartCode(id, Hosts.Map(CodeSet));

        public UriCode this[MemoryAddress location]
        {
            [MethodImpl(Inline)]
            get => Code(location);
        }

        public HostCode this[ApiHostUri id]
        {
            [MethodImpl(Inline)]
            get => CodeSet(id);
        }

        public PartCode this[PartId id]
        {
            [MethodImpl(Inline)]
            get => CodeSet(id);
        }

        MachineIndex(int i)
        {
            MemoryTable = HashTable<MemoryAddress,UriCode>.Empty;
            MemoryUri = HashTable<MemoryAddress,OpUri>.Empty;
            HostCode = new Dictionary<ApiHostUri, UriCode[]>();
            Parts = Root.array<PartId>();
        }
    }
}