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

    public readonly struct OpIndex<T> : IEnumerable<KeyedValue<OpIdentity, T>>, IOpIndex<T>
    {
        public readonly Dictionary<OpIdentity, T> HashTable;

        public readonly OpIdentity[] Duplicates;

        internal OpIndex(Dictionary<OpIdentity, T> index, OpIdentity[] duplicates)
        {
            this.HashTable = index;
            this.Duplicates = duplicates;
        }
            
        public Option<T> Lookup(OpIdentity id)
            => HashTable.TryFind(id);

        public T this[OpIdentity id]
        {
            get 
            {
                if(HashTable.TryGetValue(id, out var value))
                    return value;
                else
                    return default;
            }
        }

        public int EntryCount 
            => HashTable.Count;

        public IEnumerable<(OpIdentity, T)> Enumerated 
            => HashTable.Select(kvp => (kvp.Key, kvp.Value));

        public IEnumerable<OpIdentity> Keys 
            => HashTable.Keys;
        
        public IReadOnlyList<OpIdentity> DuplicateKeys
            => Duplicates;

        IEnumerable<KeyedValue<OpIdentity,T>> KeyedValues
            => HashTable.Select(x => KeyedValue.Define(x.Key, x.Value));

        public IEnumerator<KeyedValue<OpIdentity, T>> GetEnumerator()
            => KeyedValues.GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}