//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Lookups
    {
        [MethodImpl(Inline)]
        public static SemanticLookup<K,T> semantic<K,T>(Index<T> data, K key = default)
            where K : unmanaged, Enum
                => new SemanticLookup<K,T>(data);
    }
}