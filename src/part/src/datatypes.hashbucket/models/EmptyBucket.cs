//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct EmptyBucket<K,V> : IHashBucket<K,V>
        where K : unmanaged, IHashCode<K>
    {
        public K Key {get;}

        public V Value {get;}

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => true;
        }

        public IHashBucket<K,V> Next
        {
            [MethodImpl(Inline)]
            get => default(EmptyBucket<K,V>);
        }

        [MethodImpl(Inline)]
        public static implicit operator HashBucket<K,V>(EmptyBucket<K,V> src)
            => default;
    }
}