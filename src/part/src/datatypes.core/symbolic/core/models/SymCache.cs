//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SymCache<K>
        where K : unmanaged
    {
        [MethodImpl(Inline)]
        public static SymCache<K> get()
            => new SymCache<K>();

        public Symbols<K> Entries
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        [FixedAddressValueType]
        static Symbols<K> Storage;
    }
}