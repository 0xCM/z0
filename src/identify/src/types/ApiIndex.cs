//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    using static Seed;

    public readonly struct ApiIndex : IOpIndex<ApiMember>
    {
        public static ApiIndex From(IEnumerable<ApiMember> src)
        {
            var pairs = src.Select(h => (h.Id, h));
            var opindex = OpIndex.Create(pairs,true);
            return new ApiIndex(opindex.HashTable, opindex.Duplicates);                
        }
            
        readonly Dictionary<OpIdentity, ApiMember> Data;

        readonly OpIdentity[] Duplicates;

        internal ApiIndex(Dictionary<OpIdentity, ApiMember> index, OpIdentity[] duplicates)
        {
            this.Data = index;
            this.Duplicates = duplicates;
        }
    
        public Option<ApiMember> Lookup(OpIdentity id)
            => Data.TryFind(id);

        public ApiMember this[OpIdentity id]
        {
            get 
            {
                if(Data.TryGetValue(id, out var value))
                    return value;
                else
                    return default;
            }
        }

        public int EntryCount 
            => Data.Count;

        public IEnumerable<(OpIdentity, ApiMember)> Enumerated 
            => Data.Select(kvp => (kvp.Key, kvp.Value));

        public IEnumerable<OpIdentity> Keys 
            => Data.Keys;
        
        public IReadOnlyList<OpIdentity> DuplicateKeys
            => Duplicates;

        IEnumerable<KeyedValue<OpIdentity,ApiMember>> KeyedValues
            => Data.Select(x => KeyedValue.Define(x.Key, x.Value));

        public IEnumerator<KeyedValue<OpIdentity, ApiMember>> GetEnumerator()
            => KeyedValues.GetEnumerator();        

    }
}