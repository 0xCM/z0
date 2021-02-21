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

    partial struct Lookups
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lu32<V> lu32<V>(LookupEntry<uint,V>[] src)
            => new Lu32<V>(entries<uint,V>(src));
    }
}