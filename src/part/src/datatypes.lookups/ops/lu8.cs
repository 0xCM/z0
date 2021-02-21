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
        [Op, Closures(Closure)]
        public static Lu8<V> lu8<V>(Index<byte> keys, Index<V> values)
        {
            var count = keys.Length;
            var lu = lu8(alloc<LookupEntry<byte,V>>(count));
            fill(keys, values, ref lu);
            return lu;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lu8<V> lu8<V>(LookupEntry<byte,V>[] src)
            => new Lu8<V>(entries<byte,V>(src));
    }
}