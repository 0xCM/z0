//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;
    
    public interface IReadOnlyLookup<K,V>
    {
        V Find(K key);

        bool Find(K key, out V value);

        V this[K key] {get;}

        Option<V> TryFind(K key);
        
    }
    
    public interface ILookup<K,V> : IReadOnlyLookup<K,V>
    {
        void Add(K key, V value);
        
        bool TryAdd(K key, V value);
        
        void AddOrReplace(K key, V value);
    }

}