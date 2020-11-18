//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    /// <summary>
    /// Defines a finite bijection member that correlates keys and indexes
    /// </summary>
    [DataType]
    public readonly struct IndexKey<K,I>
        where K : unmanaged
        where I : unmanaged
    {
        /// <summary>
        /// The key value
        /// </summary>
        public K Key {get;}

        /// <summary>
        /// The index value
        /// </summary>
        public I Index {get;}

        [MethodImpl(Inline)]
        public IndexKey(K key, I index)
        {
            Key = key;
            Index = index;
        }

        [MethodImpl(Inline)]
        public static implicit operator IndexKey<K,I>(Paired<K,I> src)
            => new IndexKey<K,I>(src.Left, src.Right);
    }
}