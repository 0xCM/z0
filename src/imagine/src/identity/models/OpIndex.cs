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
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct OpIndex
    {
        public static OpIndex<T> create<T>(IEnumerable<(OpIdentity,T)> src)
        {
            try
            {
                var items = src.ToArray();
                var identities = items.Select(x => x.Item1).ToArray();
                var duplicates = (from g in identities.GroupBy(i => i.Identifier)
                                where g.Count() > 1
                                select g.Key).ToHashSet();
                
                var dst = new Dictionary<OpIdentity,T>();                        
                if(duplicates.Count() != 0)
                    dst = items.Where(i => !duplicates.Contains(i.Item1.Identifier)).ToDictionary();
                else
                    dst = src.ToDictionary();            
                return new OpIndex<T>(dst, duplicates.Select(d => OpIdentityParser.parse(d)).Array());
            }
            catch(Exception e)
            {
                term.error(e);
                return OpIndex<T>.Empty;
            }
        }
    }

    public readonly struct OpIndex<T> : IEnumerable<KeyedValue<OpIdentity,T>>, IOpIndex<T>
    {
        
        public readonly Dictionary<OpIdentity,T> HashTable;

        public readonly OpIdentity[] Duplicates;

        public OpIndex(Dictionary<OpIdentity, T> index, OpIdentity[] duplicates)
        {
            HashTable = index;
            Duplicates = duplicates;
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

       public static OpIndex<T> Empty 
            => new OpIndex<T>(new Dictionary<OpIdentity,T>(), sys.empty<OpIdentity>());
            
    }
}