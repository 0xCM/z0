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
        static ref LookupEntries<K,V> generic<K,V>(in LookupEntries<byte,V> src)
            where K : unmanaged
                => ref @as<LookupEntries<byte,V>,LookupEntries<K,V>>(src);

        [MethodImpl(Inline)]
        static ref LookupEntries<K,V> generic<K,V>(in LookupEntries<ushort,V> src)
            where K : unmanaged
                => ref @as<LookupEntries<ushort,V>,LookupEntries<K,V>>(src);

        [MethodImpl(Inline)]
        static ref LookupEntries<K,V> generic<K,V>(in LookupEntries<uint,V> src)
            where K : unmanaged
                => ref @as<LookupEntries<uint,V>,LookupEntries<K,V>>(src);

        [MethodImpl(Inline)]
        static ref LookupEntries<K,V> generic<K,V>(in LookupEntries<ulong,V> src)
            where K : unmanaged
                => ref @as<LookupEntries<ulong,V>,LookupEntries<K,V>>(src);
    }
}