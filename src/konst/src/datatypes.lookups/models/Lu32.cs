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
        /// Defines a 32-bit lookup tablee
        /// </summary>
        public readonly struct Lu32<V>
        {
            readonly LookupTable<uint,V> Entries;

            [MethodImpl(Inline)]
            public Lu32(LookupTable<uint,V> src)
                => Entries = src;

            public ref LookupEntry<uint,V> First
            {
                [MethodImpl(Inline)]
                get => ref Entries.First;
            }
        }
    }
}