//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static Seed;

    public readonly struct UriCodeIndex
    {
        public static UriCodeIndex Empty => new UriCodeIndex(0);

        readonly ConcurrentDictionary<MemoryAddress,UriCode> MemoryCode;

        readonly ConcurrentDictionary<MemoryAddress,OpUri> MemoryUri;

        readonly ConcurrentDictionary<OpUri,UriCode> UriCodes;

        UriCodeIndex(int x)
        {            
            MemoryCode = new ConcurrentDictionary<MemoryAddress, UriCode>();
            MemoryUri = new ConcurrentDictionary<MemoryAddress, OpUri>();
            UriCodes = new ConcurrentDictionary<OpUri, UriCode>();
        }

        public int EntryCount 
            => MemoryCode.Keys.Count;

        public ICollection<MemoryAddress> Memories
            => MemoryCode.Keys;

        public ICollection<UriCode> IndexedCode 
            => MemoryCode.Values;

        public ICollection<OpUri> IndexedUri 
            => MemoryUri.Values;

        public UriCode GetCode(MemoryAddress address)    
            => MemoryCode[address];

        public UriCode GetCode(OpUri uri)    
            => UriCodes[uri];

        public OpUri GetUri(MemoryAddress address)    
            => MemoryUri[address];

        public Option<UriCode> FindCode(MemoryAddress address)    
        {
            if(MemoryCode.TryGetValue(address, out var code))
                return Option.some(code);                
            else
                return Option.none<UriCode>();
        }

        public int Include(params UriCode[] src)
        {
            var count = 0;
            for(var i=0; i<src.Length; i++)
            {
                var code = src[i];
                if(!MemoryCode.TryAdd(code.Address, code))
                    term.yellow($"The address {code.Address} has already been asoociated with code");
                else
                    count++;

                MemoryUri.TryAdd(code.Address, code.Uri);
                UriCodes.TryAdd(code.Uri, code);
            }
            return count;
        }
    }
}