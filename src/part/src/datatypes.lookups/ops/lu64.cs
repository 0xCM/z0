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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lu64<V> lu64<V>(LookupEntry<ulong,V>[] src)
            => new Lu64<V>(entries<ulong,V>(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LuFx64<T> lu64<T>(Index<ulong> index, T[] values)
            where T : unmanaged
                => new LuFx64<T>(index, values);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LuFx64<T> lu64<T>(Paired<ulong,T>[] pairs)
            where T : unmanaged
                => new LuFx64<T>(pairs);
    }
}