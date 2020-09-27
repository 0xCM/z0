//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BitFieldIndex : IBitFieldIndex<BitFieldIndexEntry>
    {
        readonly BitFieldIndexEntry[] Storage;

        [MethodImpl(Inline)]
        public static implicit operator BitFieldIndex(BitFieldIndexEntry[] entries)
            => new BitFieldIndex(entries);

        [MethodImpl(Inline)]
        public BitFieldIndex(BitFieldIndexEntry[] entries)
            => Storage = entries;

        public ReadOnlySpan<BitFieldIndexEntry> Entries
        {
            [MethodImpl(Inline)]
            get => Storage;
        }
    }
}