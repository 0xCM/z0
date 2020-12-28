//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SemanticIndex
    {
        [MethodImpl(Inline)]
        public static SemanticIndex<K,T> create<K,T>(T[] data, K key = default)
            where K : unmanaged, Enum
                => new SemanticIndex<K,T>(data);
    }
}