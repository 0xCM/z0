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

    partial struct Table
    {
        [Op, Closures(UInt8k)]
        public static LookupGrid<byte,byte,byte,T> grid<T>(W8 ixj)
            => new LookupGrid<byte,byte,byte,T>(new byte[256,256], new T[256*256]);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T lookup<T>(in LookupGrid<byte,byte,byte,T> src, byte i, byte j)
            where T : unmanaged
                => ref lookup<byte,byte,byte,T>(src,i,j);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T lookup<T>(in TableSpan<N256,N256,T> src, byte i, byte j)
            where T : unmanaged
                => ref src[i,j];

        [MethodImpl(Inline)]
        public static ref T lookup<I,J,S,T>(in LookupGrid<I,J,S,T> src, I i, J j)
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
        /// Creates a lookup table
        /// </summary>
        /// <param name="src">The table entries</param>
        /// <typeparam name="K">The key type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static LookupTable<K,V> lookup<K,V>(LookupEntry<K,V>[] src)
            where K : unmanaged
                => new LookupTable<K,V>(src);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Lu8<V> lookup<V>(LookupEntry<byte,V>[] src)
            => new Lu8<V>(lookup(src, z8));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Lu16<V> lookup<V>(LookupEntry<ushort,V>[] src)
            => new Lu16<V>(lookup(src, z16));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Lu32<V> lookup<V>(LookupEntry<uint,V>[] src)
            => new Lu32<V>(lookup(src, z32));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Lu64<V> lookup<V>(LookupEntry<ulong,V>[] src)
            => new Lu64<V>(lookup(src, z64));

        [MethodImpl(Inline)]
        public static LookupTable<T,V> lookup<S,T,V>(LookupEntry<S,V>[] src, T t = default)
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
    }
}