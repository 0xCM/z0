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

    [ApiHost(ApiNames.Lookups)]
    public partial struct Lookups
    {
        [Op, Closures(UInt8k)]
        public static LookupGrid<byte,byte,byte,T> grid<T>(W8 ixj)
            => new LookupGrid<byte,byte,byte,T>(new byte[256,256], new T[256*256]);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Lu8<V> lookup<V>(LookupEntry<byte,V>[] src)
            => new Lu8<V>(lookup<byte,V>(src));

        public static Lu8<V> lookup<V>(byte[] keys, V[] values)
        {
            var count = keys.Length;
            var lu = lookup(alloc<LookupEntry<byte,V>>(count));
            fill(keys,values, ref lu);
            return lu;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref Lu8<V> fill<V>(byte[] keys, V[] values, ref Lu8<V> dst)
        {
            var count = keys.Length;
            ref readonly var kSrc = ref first(@readonly(keys));
            ref readonly var vSrc = ref first(@readonly(values));
            ref var luDst = ref first(span(dst.Entries.Entries));
            for(var i=0; i<count; i++)
                seek(luDst,i) = entry(skip(kSrc,i), skip(vSrc,i));
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static LookupEntry<K,V> entry<K,V>(K key, V value)
            where K : unmanaged
                => new LookupEntry<K,V>(key,value);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Lu16<V> lookup<V>(LookupEntry<ushort,V>[] src)
            => new Lu16<V>(lookup<ushort,V>(src));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Lu32<V> lookup<V>(LookupEntry<uint,V>[] src)
            => new Lu32<V>(lookup<uint,V>(src));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Lu64<V> lookup<V>(LookupEntry<ulong,V>[] src)
            => new Lu64<V>(lookup<ulong,V>(src));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static LuFx64<T> lookup<T>(ulong[] index, T[] values)
            where T : unmanaged
                => new LuFx64<T>(index, values);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static LuFx64<T> lookup<T>(Paired<ulong,T>[] pairs)
            where T : unmanaged
                => new LuFx64<T>(pairs);

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


        [MethodImpl(Inline)]
        public static Span<LookupEntry<T,V>> convert<S,V,T>(Span<LookupEntry<S,V>> src, T t = default)
            where S : unmanaged
            where T : unmanaged
        {
            var edit = src;
            ref var sv = ref first(edit);
            var tv = recover<LookupEntry<S,V>,LookupEntry<T,V>>(src);
            var count = src.Length;
            for(var i=0u; i<count; i++)
                seek(tv, i) = @as<LookupEntry<S,V>,LookupEntry<T,V>>(skip(sv,i));
            return tv;
        }
    }
}