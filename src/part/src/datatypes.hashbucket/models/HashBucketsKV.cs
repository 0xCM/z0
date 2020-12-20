//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct HashBuckets<K,V> : IIndex<HashBucket<K,V>>
        where K : unmanaged, IHashCode<K>
    {
        HashBucket<K,V>[] Data;

        [MethodImpl(Inline)]
        public HashBuckets(HashBucket<K,V>[] src)
            => Data = src;

        public Span<HashBucket<K,V>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ReadOnlySpan<HashBucket<K,V>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public HashBucket<K,V>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}