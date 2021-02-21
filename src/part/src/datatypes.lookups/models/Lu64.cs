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
        /// <summary>
        /// Defines a 64-bit lookup tablee
        /// </summary>
        public readonly struct Lu64<V>
        {
            readonly LookupEntries<ulong,V> Entries;

            [MethodImpl(Inline)]
            public Lu64(LookupEntries<ulong,V> src)
                => Entries = src;

            public ref LookupEntry<ulong,V> First
            {
                [MethodImpl(Inline)]
                get => ref Entries.First;
            }
        }
    }
}