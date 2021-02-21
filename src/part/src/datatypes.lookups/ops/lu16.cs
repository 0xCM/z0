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
        public static Lu16<V> lu16<V>(Index<ushort> keys, Index<V> values)
        {
            var count = keys.Length;
            var lu = lu16(alloc<LookupEntry<ushort,V>>(count));
            fill(keys, values, ref lu);
            return lu;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lu16<V> lu16<V>(LookupEntry<ushort,V>[] src)
            => new Lu16<V>(entries<ushort,V>(src));
    }
}