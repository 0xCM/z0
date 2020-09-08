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

    partial struct Table
    {
        /// <summary>
        /// Creates a <see cref='LookupTable{K,T}'/> entry
        /// </summary>
        /// <param name="key">The lookup key</param>
        /// <param name="value">The target value</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static LookupEntry<K,V> entry<K,V>(K key, in V value)
            where K : unmanaged
        {
            if(typeof(K) == typeof(byte))
                return generic<K,V>(entry(uint8(key), value));
            else if(typeof(K) == typeof(ushort))
                return generic<K,V>(entry(uint16(key), value));
            else if(typeof(K) == typeof(uint))
                return generic<K,V>(entry(uint32(key), value));
            else if(typeof(K) == typeof(ulong))
                return generic<K,V>(entry(uint64(key), value));
            else
                throw no<K>();
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static LookupEntry<byte,V> entry<V>(byte key, in V value)
            => new LookupEntry<byte,V>(key,value);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static LookupEntry<ushort,V> entry<V>(ushort key, in V value)
            => new LookupEntry<ushort,V>(key,value);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static LookupEntry<uint,V> entry<V>(uint key, in V value)
            => new LookupEntry<uint,V>(key,value);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        static LookupEntry<ulong,V> entry<V>(ulong key, in V value)
            => new LookupEntry<ulong,V>(key,value);

        [MethodImpl(Inline)]
        static ref LookupEntry<K,V> generic<K,V>(in LookupEntry<byte,V> src)
            where K : unmanaged
                => ref @as<LookupEntry<byte,V>,LookupEntry<K,V>>(src);

        [MethodImpl(Inline)]
        static ref LookupEntry<K,V> generic<K,V>(in LookupEntry<ushort,V> src)
            where K : unmanaged
                => ref @as<LookupEntry<ushort,V>,LookupEntry<K,V>>(src);

        [MethodImpl(Inline)]
        static ref LookupEntry<K,V> generic<K,V>(in LookupEntry<uint,V> src)
            where K : unmanaged
                => ref @as<LookupEntry<uint,V>,LookupEntry<K,V>>(src);

        [MethodImpl(Inline)]
        static ref LookupEntry<K,V> generic<K,V>(in LookupEntry<ulong,V> src)
            where K : unmanaged
                => ref @as<LookupEntry<ulong,V>,LookupEntry<K,V>>(src);

        [MethodImpl(Inline)]
        static ref LookupTable<K,V> generic<K,V>(in LookupTable<byte,V> src)
            where K : unmanaged
                => ref @as<LookupTable<byte,V>,LookupTable<K,V>>(src);

        [MethodImpl(Inline)]
        static ref LookupTable<K,V> generic<K,V>(in LookupTable<ushort,V> src)
            where K : unmanaged
                => ref @as<LookupTable<ushort,V>,LookupTable<K,V>>(src);

        [MethodImpl(Inline)]
        static ref LookupTable<K,V> generic<K,V>(in LookupTable<uint,V> src)
            where K : unmanaged
                => ref @as<LookupTable<uint,V>,LookupTable<K,V>>(src);

        [MethodImpl(Inline)]
        static ref LookupTable<K,V> generic<K,V>(in LookupTable<ulong,V> src)
            where K : unmanaged
                => ref @as<LookupTable<ulong,V>,LookupTable<K,V>>(src);
   }
}