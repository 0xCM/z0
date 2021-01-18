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
        public static Lu8<V> define<V>(Index<byte> keys, Index<V> values)
        {
            var count = keys.Length;
            var lu = define(alloc<LookupEntry<byte,V>>(count));
            fill(keys, values, ref lu);
            return lu;
        }

        [Op, Closures(Closure)]
        public static Lu16<V> define<V>(Index<ushort> keys, Index<V> values)
        {
            var count = keys.Length;
            var lu = define(alloc<LookupEntry<ushort,V>>(count));
            fill(keys, values, ref lu);
            return lu;
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lu8<V> define<V>(LookupEntry<byte,V>[] src)
            => new Lu8<V>(table<byte,V>(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lu16<V> define<V>(LookupEntry<ushort,V>[] src)
            => new Lu16<V>(table<ushort,V>(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lu32<V> define<V>(LookupEntry<uint,V>[] src)
            => new Lu32<V>(table<uint,V>(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Lu64<V> define<V>(LookupEntry<ulong,V>[] src)
            => new Lu64<V>(table<ulong,V>(src));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LuFx64<T> define<T>(Index<ulong> index, T[] values)
            where T : unmanaged
                => new LuFx64<T>(index, values);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LuFx64<T> define<T>(Paired<ulong,T>[] pairs)
            where T : unmanaged
                => new LuFx64<T>(pairs);
    }
}