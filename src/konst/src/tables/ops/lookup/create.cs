//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct LookupTables
    {
        /// <summary>
        /// Creates a lookup table
        /// </summary>
        /// <param name="src">The table entries</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static LookupTable<K,V> create<K,V>(LookupEntry<K,V>[] src)
            where K : unmanaged
                => new LookupTable<K,V>(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Lu8<V> create<V>(LookupEntry<byte,V>[] src)
            => new Lu8<V>(create(src, z8));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Lu16<V> create<V>(LookupEntry<ushort,V>[] src)
            => new Lu16<V>(create(src, z16));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Lu32<V> create<V>(LookupEntry<uint,V>[] src)
            => new Lu32<V>(create(src, z32));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Lu64<V> create<V>(LookupEntry<ulong,V>[] src)
            => new Lu64<V>(create(src, z64));

        [MethodImpl(Inline)]
        static LookupTable<T,V> create<S,T,V>(LookupEntry<S,V>[] src, T t = default)
            where S : unmanaged
            where T : unmanaged
        {
            ref var eV = ref first(span(src));
            ref var dst = ref @as<LookupEntry<S,V>,LookupEntry<T,V>>(eV);
            var count = src.Length;
            for(var i=0u; i<count; i++)
            {
                ref var eSrc = ref seek(eV,i);
                ref var eDst = ref @as<LookupEntry<S,V>,LookupEntry<T,V>>(eSrc);
                seek(dst,i) = eDst;
            }

            return new LookupTable<T,V>();
        }

        [MethodImpl(Inline)]
        static LookupTable<K,V> table<K,V>(LookupEntry<K,V>[] entries)
            where K : unmanaged
        {
            if(typeof(K) == typeof(byte))
                return generic<K,V>(create(entries, z8));
            else if(typeof(K) == typeof(ushort))
                return generic<K,V>(create(entries, z16));
            if(typeof(K) == typeof(uint))
                return generic<K,V>(create(entries, z32));
            if(typeof(K) == typeof(ulong))
                return generic<K,V>(create(entries, z64));
            else
                throw no<K>();
        }
    }
}