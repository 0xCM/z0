//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;


    public readonly struct HashBuckets
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline)]
        internal static ref HashBucket<K,V> next<K,V>(IHashBucket<K,V> src, ref HashBucket<K,V> dst)
            where K : unmanaged, IHashCode<K>
        {
            dst.Next = src;
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static EmptyBucket<K,V> empty<K,V>()
            where K : unmanaged, IHashCode<K>
                => default;

        [MethodImpl(Inline)]
        public static HashBucket<K,V> bucket<K,V>(K hash, V value)
            where K : unmanaged, IHashCode<K>
                => new HashBucket<K,V>(hash, value, empty<K,V>());

        [MethodImpl(Inline)]
        public static HashBucket<K,V> bucket<K,V>(K hash, V value, IHashBucket<K,V> next)
            where K : unmanaged, IHashCode<K>
                => new HashBucket<K,V>(hash, value, next);

        [MethodImpl(Inline)]
        public static HashBucket32<V> bucket<V>(Hash32 hash, V value)
            => new HashBucket32<V>(hash, value, HashBucket32<V>.Empty);

        [MethodImpl(Inline)]
        public static HashBucket32<V> bucket<V>(Hash32 hash, V value, IHashBucket<Hash32,V> next)
            => new HashBucket32<V>(hash, value, next);
    }
}
