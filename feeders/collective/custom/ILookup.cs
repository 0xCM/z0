//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IReadOnlyLookup<K,V>
    {
        V Find(K key);

        bool Find(K key, out V value);

        V this[K key] {get;}
        
    }
    
    public interface ILookup<K,V> : IReadOnlyLookup<K,V>
    {
        void Add(K key, V value);
        
        bool TryAdd(K key, V value);
        
        void AddOrReplace(K key, V value);
    }
}