//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    using System.Linq;
    using System.Collections.Generic;

    using static Konst;

    public readonly struct MachineIndexBuilder : IMachineIndexBuilder
    {
        public static IMachineIndexBuilder Service => new MachineIndexBuilder(0);

        readonly ConcurrentDictionary<MemoryAddress,MemberCode> MemoryCode;

        readonly ConcurrentDictionary<MemoryAddress,OpUri> MemoryUri;

        readonly ConcurrentDictionary<OpUri,MemberCode> UriCodes;

        MachineIndexBuilder(int x)
        {            
            MemoryCode = new ConcurrentDictionary<MemoryAddress,MemberCode>();
            MemoryUri = new ConcurrentDictionary<MemoryAddress,OpUri>();
            UriCodes = new ConcurrentDictionary<OpUri,MemberCode>();
        }

        public EncodedIndex Freeze()
        {
            var memtable = HashTable.Create(MemoryCode);
            var memuri = HashTable.Create(MemoryUri);  
            var hc = memtable.Values.Select(x => (x.OpUri.Host, x))
                                         .GroupBy(g => g.Host)
                                         .Select(x => (x.Key, x.Select(y => y.x).ToArray()))
                                         .ToDictionary();
            var parts = hc.Keys.Select(x => x.Owner).Distinct().ToArray();

            return new EncodedIndex(parts, memtable, memuri, hc); 
            //return new MachineIndex(MemoryCode, MemoryUri);
        }

        public int Include(params MemberCode[] src)
        {
            var count = 0;
            for(var i=0; i<src.Length; i++)
            {
                var code = src[i];
                if(!MemoryCode.TryAdd(code.Address, code))
                    term.yellow($"The address {code.Address} has already been asoociated with code");
                else
                    count++;

                MemoryUri.TryAdd(code.Address, code.OpUri);
                UriCodes.TryAdd(code.OpUri, code);
            }
            return count;
        }
    }
}