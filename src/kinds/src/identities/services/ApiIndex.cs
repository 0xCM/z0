//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct ApiIndex : IApiIndex
    {
        readonly Dictionary<OpIdentity, ApiMember> Data;

        readonly OpIdentity[] Duplicates;

        public static ApiIndex Create(IEnumerable<ApiMember> src)
        {
            var pairs = src.Select(h => (h.Id, h));
            var opindex = Identify.index(pairs,true);
            return new ApiIndex(opindex.HashTable, opindex.Duplicates);                
        }            

        [MethodImpl(Inline)]
        internal ApiIndex(Dictionary<OpIdentity, ApiMember> index, OpIdentity[] duplicates)
        {
            this.Data = index;
            this.Duplicates = duplicates;
        }
    
        [MethodImpl(Inline)]
        public Option<ApiMember> Lookup(OpIdentity id)
            => Data.TryFind(id);

        public ApiMember this[OpIdentity id]
        {
            [MethodImpl(Inline)]
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