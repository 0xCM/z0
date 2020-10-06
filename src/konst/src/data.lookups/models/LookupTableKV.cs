//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Defines a K-V lookup table
    /// </summary>
    public struct LookupTable<K,V>
        where K : unmanaged
    {
        TableSpan<LookupEntry<K,V>> Entries;

        [MethodImpl(Inline)]
        public LookupTable(LookupEntry<K,V>[] src)
        {
            Entries = src;
        }
    }
}