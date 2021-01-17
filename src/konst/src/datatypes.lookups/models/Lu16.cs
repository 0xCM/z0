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
        /// Defines a 16-bit lookup tablee
        /// </summary>
        public readonly struct Lu16<V>
        {
            readonly LookupTable<ushort,V> Entries;

            [MethodImpl(Inline)]
            public Lu16(LookupTable<ushort,V> src)
                => Entries = src;

            public ref LookupEntry<ushort,V> First
            {
                [MethodImpl(Inline)]
                get => ref Entries.First;
            }
        }
    }
}