//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct HashBucket32<V> : IHashBucket<Hash32,V>
    {
        public Hash32 Key {get;}

        public V Value {get;}

        public IHashBucket<Hash32,V> Next {get; internal set;}

        internal HashBucket32(Hash32 key, V value, IHashBucket<Hash32,V> next)
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

        public static HashBucket<Hash32,V> Empty
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}