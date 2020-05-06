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

    public readonly struct UriCodeIndexer : IUriCodeIndexer
    {
        public static IUriCodeIndexer Service => new UriCodeIndexer(0);

        readonly ConcurrentDictionary<MemoryAddress,UriCode> MemoryCode;

        readonly ConcurrentDictionary<MemoryAddress,OpUri> MemoryUri;

        readonly ConcurrentDictionary<OpUri,UriCode> UriCodes;

        UriCodeIndexer(int x)
        {            
            MemoryCode = new ConcurrentDictionary<MemoryAddress, UriCode>();
            MemoryUri = new ConcurrentDictionary<MemoryAddress, OpUri>();
            UriCodes = new ConcurrentDictionary<OpUri, UriCode>();
        }

        public UriCodeIndex Freeze()
            => new UriCodeIndex(MemoryCode, MemoryUri);

        public int EntryCount 
            => MemoryCode.Keys.Count;

        public ICollection<UriCode> Included 
            => MemoryCode.Values;

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

                MemoryUri.TryAdd(code.Address, code.OpUri);
                UriCodes.TryAdd(code.OpUri, code);
            }
            return count;
        }
    }
}