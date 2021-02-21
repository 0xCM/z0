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
    /// Defines a K-V lookup table
    /// </summary>
    public struct LookupEntries<K,V>
        where K : unmanaged
    {
        public Index<LookupEntry<K,V>> Data;

        [MethodImpl(Inline)]
        public LookupEntries(Index<LookupEntry<K,V>> src)
            => Data = src;

        public ref LookupEntry<K,V> First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }
    }
}