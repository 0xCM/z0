//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines an entry in a <see cref='LookupEntries{T,K}'/>
    /// </summary>
    public readonly struct LookupEntry<K,V>
        where K : unmanaged
    {
        public K Key {get;}

        public V Value {get;}

        [MethodImpl(Inline)]
        public LookupEntry(K key, V value)
        {
            Key = key;
            Value = value;
        }

        [MethodImpl(Inline)]
        public static implicit operator LookupEntry<K,V>((K key, V value) src)
            => new LookupEntry<K,V>(src.key, src.value);

        [MethodImpl(Inline)]
        public static implicit operator LookupEntry<K,V>(Paired<K,V> src)
            => new LookupEntry<K,V>(src.Left, src.Right);

        [MethodImpl(Inline)]
        public static implicit operator Paired<K,V>(LookupEntry<K,V> src)
            => root.paired(src.Key,src.Value);
    }
}