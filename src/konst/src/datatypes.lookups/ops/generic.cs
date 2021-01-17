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