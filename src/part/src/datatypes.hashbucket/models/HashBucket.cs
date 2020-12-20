//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct HashBucket<K,V> : IHashBucket<K,V>
        where K : unmanaged, IHashCode
    {
        public K Key {get;}

        public V Value {get;}

        public IHashBucket<K,V> Next {get; internal set;}

        internal HashBucket(K key, V value, IHashBucket<K,V> next)
        {
            Key = key;
            Value = value;
            Next = next;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Key.Equals(default);
        }

        public static HashBucket<K,V> Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}