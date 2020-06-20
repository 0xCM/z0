//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections;

    using static Konst;

    /// <summary>
    /// Reifies a K-V parametric hashtable, along with extras
    /// </summary>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    public readonly struct HashTable<K,V> : IHashTable<K,V>
    {        
        public K[] Keys {get;}

        public V[] Values {get;}

        readonly IReadOnlyDictionary<K,V> KeyedValues;

        readonly HashSet<V> ValueSet;

        readonly IReadOnlyDictionary<V,K[]> IndexedValues;

        public ISet<V> DistinctValues
        {
            [MethodImpl(Inline)]
            get => ValueSet;
        }

        public V this[K key] 
        {
            [MethodImpl(Inline)]
            get => KeyedValues[key];
        }
        
        public int Count 
        {
            [MethodImpl(Inline)]
            get => KeyedValues.Count;
        }

        public K[] this[V value]
        {
            [MethodImpl(Inline)]
            get => IndexedValues[value];
        }

        [MethodImpl(Inline)]
        public K[] ValueKeys(V value)
            => this[value];

        [MethodImpl(Inline)]
        public bool ContainsKey(K key)
            => KeyedValues.ContainsKey(key);

        [MethodImpl(Inline)]
        public bool ContainsValue(V value)
            => ValueSet.Contains(value);

        [MethodImpl(Inline)]
        public bool TryGetValue(K key, out V value)
            => KeyedValues.TryGetValue(key, out value);

        [MethodImpl(Inline)]
        public bool TryGetKeys(V value, out K[] keys)
            => IndexedValues.TryGetValue(value, out keys);

        HashTable(int i)
        {
            KeyedValues = new Dictionary<K,V>();
            ValueSet = new HashSet<V>();
            IndexedValues = new Dictionary<V,K[]>();
            Keys = Root.array<K>();
            Values = Root.array<V>();
        }
        
        public HashTable(IReadOnlyDictionary<K,V> data)
        {
            KeyedValues = data;
            Keys = data.Keys.ToArray();
            Values = data.Values.ToArray();
            ValueSet = Values.ToHashSet();
            var valueIndex = new Dictionary<V,K[]>();
            IndexedValues = valueIndex;
        }

        public HashTable(Dictionary<K,V> data)
        {
            KeyedValues = data;
            Keys = data.Keys.ToArray();
            Values = data.Values.ToArray();
            ValueSet = Values.ToHashSet();
            IndexedValues = data.Flip();
        }

        IEnumerable<K> IReadOnlyDictionary<K,V>.Keys 
            => Keys;
        
        IEnumerable<V> IReadOnlyDictionary<K,V>.Values 
            => Values;
        
        IEnumerator<KeyValuePair<K,V>> IEnumerable<KeyValuePair<K,V>>.GetEnumerator()
            => KeyedValues.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => KeyedValues.GetEnumerator();

        /// <summary>
        /// A hashtable that hashes nothing
        /// </summary>
        public static HashTable<K,V> Empty 
            => new HashTable<K,V>(0);
    }
}