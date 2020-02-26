//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public static class Lookup
    {
        public static ILookup<K,V> Define<K,V>(params (K key,V value)[] kvp)
            => new Lookup<K,V>(kvp);
    }

    public static class LookupX
    {
        public static ILookup<K,V> ToLookup<K,V>(this IEnumerable<(K key,V value)> kvp)
            => Lookup.Define(kvp.ToArray());
    }

    class Lookup<K, V> : ILookup<K, V>
    {
        readonly Dictionary<K,V> store;
        
        public Lookup()
            => store = new Dictionary<K, V>();

        public Lookup(params (K key, V value)[] kvp)
            => store = kvp.ToDictionary();

        public V this[K key] 
            => store[key];

        [MethodImpl(Inline)]
        public void Add(K key, V value)
            => store.Add(key,value);

        [MethodImpl(Inline)]
        public void AddOrReplace(K key, V value)
            => store[key] = value;

        [MethodImpl(Inline)]
        public V Find(K key)
            => store[key];

        [MethodImpl(Inline)]
        public bool Find(K key, out V value)
            => store.TryGetValue(key, out value);

        [MethodImpl(Inline)]
        public bool TryAdd(K key, V value)
            => store.TryAdd(key,value);

        [MethodImpl(Inline)]
        public Option<V> TryFind(K key)
        {
            if(Find(key, out V value))
                return value;
            else
                return none<V>();
        }
    }
}