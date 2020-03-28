//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Canonical;

    public readonly struct KeyedValue
    {
        [MethodImpl(Inline)]
        public static KeyedValue<K,V> Define<K,V>(K key, V value)
            => KeyedValue<K,V>.Define(key,value);
    }

    /// <summary>
    /// Correlates a value with a key that uniquely identifies the value within some context
    /// </summary>
    public readonly struct KeyedValue<K,V> 
    {
        /// <summary>
        /// The key that identifies the value
        /// </summary>
        public readonly K Key;

        /// <summary>
        /// The value identified by the key
        /// </summary>
        public readonly V Value;

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
            this.Key = key;
            this.Value = value;
        }

        [MethodImpl(Inline)]
        public KeyedValue((K key, V value) kv)
        {
            this.Key = kv.key;
            this.Value = kv.value;
        }        

        [MethodImpl(Inline)]
        public void Deconstruct(out K key, out V value)
        {
            key = this.Key;
            value = this.Value;
        }

        public string Format()
            => $"{Value.GetType().Name}[{Key}]={Value}";

        public override string ToString()
            => Format();
    }
}