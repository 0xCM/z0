//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;
    using System.Collections;
    using System.Collections.Generic;

    using static Root;

    public static class OpIndex
    {        
        public static OpIndex<T> From<T>(IEnumerable<(OpIdentity,T)> src, bool deduplicate = true)
                => new OpIndex<T>(src, deduplicate);

        public static OpIndex<T> ToOpIndex<T>(this IEnumerable<(OpIdentity,T)> src, bool deduplicate = true)
            => new OpIndex<T>(src, deduplicate);

         public static OpIndex<(L left, R right)> Intersect<L,R>(this IOpIndex<L> left, IOpIndex<R> right)
         {
             var keys = left.Keys.ToHashSet();
             keys.IntersectWith(right.Keys);
             var keylist = keys.ToArray();
             var count = keylist.Length;
             var entries = Arrays.alloc<(OpIdentity,(L,R))>(count);
             for(var i=0; i<count; i++)
             {
                var key = keylist[i];
                entries[i] = (key, (left[key], right[key]));
             }
             return entries.ToOpIndex();
         }   
    }


    public readonly struct OpIndex<T> : IEnumerable<KeyedValue<OpIdentity, T>>, IOpIndex<T>
    {
        readonly Dictionary<OpIdentity, T> HashTable;

        readonly OpIdentity[] Duplicates;

        internal OpIndex(IEnumerable<(OpIdentity,T)> src, bool deduplicate)
        {
            var items = src.ToArray();
            var identities = items.Select(x => x.Item1).ToArray();
            var duplicates = (from g in identities.GroupBy(i => i.Identifier)
                             where g.Count() > 1
                             select g.Key).ToHashSet();
            
            if(duplicates.Count() != 0)
            {
                if(deduplicate)
                    HashTable = items.Where(i => !duplicates.Contains(i.Item1.Identifier)).ToDictionary();
                else
                    throw AppErrors.DuplicateKeys(duplicates);
            }
            else
                HashTable = src.ToDictionary();
            
            Duplicates = duplicates.Select(d => OpIdentity.Define(d)).ToArray();
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

        public int EntryCount => HashTable.Count;

        public IEnumerable<(OpIdentity, T)> Enumerated => HashTable.Select(kvp => (kvp.Key, kvp.Value));

        public IEnumerable<OpIdentity> Keys => HashTable.Keys;
        
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