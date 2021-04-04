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

    public readonly struct SymCache<K>
        where K : unmanaged, Enum
    {
        [MethodImpl(Inline)]
        public static SymCache<K> get()
            => new SymCache<K>();

        static SymCache()
            => Storage = Symbols.index<K>();

        public Symbols<K> Index
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        public ReadOnlySpan<Sym<K>> View
        {
            [MethodImpl(Inline)]
            get => Storage.View;
        }

        public MemoryAddress Address
        {
            [MethodImpl(Inline)]
            get => address(Storage);
        }

        [FixedAddressValueType]
        static Symbols<K> Storage;
    }
}