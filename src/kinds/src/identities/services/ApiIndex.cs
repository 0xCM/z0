//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using static Seed;

    public readonly struct ApiIndex : IApiIndex
    {
        public static ApiIndex Create(IEnumerable<Member> src)
        {
            var pairs = src.Select(h => (h.Id, h));
            var opindex = Identify.index(pairs,true);
            return new ApiIndex(opindex.HashTable, opindex.Duplicates);                
        }
            
        readonly Dictionary<OpIdentity, Member> Data;

        readonly OpIdentity[] Duplicates;

        internal ApiIndex(Dictionary<OpIdentity, Member> index, OpIdentity[] duplicates)
        {
            this.Data = index;
            this.Duplicates = duplicates;
        }
    
        public Option<Member> Lookup(OpIdentity id)
            => Data.TryFind(id);

        public Member this[OpIdentity id]
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

        public IEnumerable<(OpIdentity, Member)> Enumerated 
            => Data.Select(kvp => (kvp.Key, kvp.Value));

        public IEnumerable<OpIdentity> Keys 
            => Data.Keys;
        
        public IReadOnlyList<OpIdentity> DuplicateKeys
            => Duplicates;

        IEnumerable<KeyedValue<OpIdentity,Member>> KeyedValues
            => Data.Select(x => KeyedValue.Define(x.Key, x.Value));

        public IEnumerator<KeyedValue<OpIdentity, Member>> GetEnumerator()
            => KeyedValues.GetEnumerator();
    }
}