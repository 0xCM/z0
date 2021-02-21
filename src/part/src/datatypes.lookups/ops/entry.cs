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
        public static LookupEntry<byte,V> entry<V>(byte key, in V value)
            => new LookupEntry<byte,V>(key,value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LookupEntry<ushort,V> entry<V>(ushort key, in V value)
            => new LookupEntry<ushort,V>(key,value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LookupEntry<uint,V> entry<V>(uint key, in V value)
            => new LookupEntry<uint,V>(key,value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static LookupEntry<ulong,V> entry<V>(ulong key, in V value)
            => new LookupEntry<ulong,V>(key,value);

        [MethodImpl(Inline)]
        public static LookupEntry<K,V> entry<K,V>(K key, V value)
            where K : unmanaged
                => new LookupEntry<K,V>(key,value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T entry<T>(in LookupGrid<byte,byte,byte,T> src, byte i, byte j)
            where T : unmanaged
                => ref entry<byte,byte,byte,T>(src, i, j);

        [MethodImpl(Inline)]
        public static ref T entry<I,J,S,T>(in LookupGrid<I,J,S,T> src, I i, J j)
            where I : unmanaged
            where J : unmanaged
            where S : unmanaged
        {
            var i64 = uint64(i);
            var j64 = uint64(j);
            var ixj = uint64(src.Index[i64,j64]);
            return ref src.Values[ixj];
        }

        /// <summary>
        /// Creates a <see cref='LookupEntries{K,T}'/> entry
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
    }
}