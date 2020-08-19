//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct KeyedValue
    {
        [MethodImpl(Inline)]
        public static KeyedValue<K,V> define<K,V>(K key, V value)
            => new KeyedValue<K,V>(key, value);
    }

    /// <summary>
    /// Signature for a key function, also called in index function, that computes a K-value for any V-value
    /// </summary>
    /// <param name="src"></param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    public delegate K KeyFunction<K,V>(in V src);

    /// <summary>
    /// Signature for an injective key function that satisfied kf(v1) = kf(v2) => v1 = v2
    /// </summary>
    /// <param name="src"></param>
    /// <typeparam name="K">The key type</typeparam>
    /// <typeparam name="V">The value type</typeparam>
    public delegate K KeyInjection<K,V>(in V src);

    /// <summary>
    /// Correlates a value with a key that uniquely identifies the value within some context
    /// </summary>
    public struct KeyedValue<K,V>
    {
        /// <summary>
        /// The key that identifies the value
        /// </summary>
        public K Key;

        /// <summary>
        /// The value identified by the key
        /// </summary>
        public V Value;

        [MethodImpl(Inline)]
        public static implicit operator KeyedValue<K,V>((K key, V value) src)
            => new KeyedValue<K,V>(src);

        [MethodImpl(Inline)]
        public static implicit operator (K key, V value)(KeyedValue<K,V> src)
            => (src.Key, src.Value);

        [MethodImpl(Inline)]
        public static KeyedValue<K,V> Define(K key, V value)
            => new KeyedValue<K,V>(key,value);

        [MethodImpl(Inline)]
        public KeyedValue(K key, V value)
        {
            Key = key;
            Value = value;
        }

        [MethodImpl(Inline)]
        public KeyedValue((K key, V value) kv)
        {
            Key = kv.key;
            Value = kv.value;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out K key, out V value)
        {
            key = Key;
            value = Value;
        }

        public string Format()
            => $"{Value.GetType().Name}[{Key}]={Value}";

        public override string ToString()
            => Format();
    }
}