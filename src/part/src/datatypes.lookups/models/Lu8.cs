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
        /// Defines an 8-bit lookup table predicated on an explicit lookup function
        /// </summary>
        public readonly struct Lu8<V>
        {
            internal readonly LookupEntries<byte,V> Entries;

            [MethodImpl(Inline)]
            public Lu8(LookupEntries<byte,V> src)
                => Entries = src;

            public ref LookupEntry<byte,V> First
            {
                [MethodImpl(Inline)]
                get => ref Entries.First;
            }
        }
    }
}