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
            => Storage = Symbols.symbols<K>();

        public ref readonly Sym<K> this[K index]
        {
            [MethodImpl(Inline)]
            get => ref Storage[index];
        }

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

        [MethodImpl(Inline)]
        public static implicit operator Symbols<K>(SymCache<K> src)
            => src.Index;

        [MethodImpl(Inline)]
        public static implicit operator SymSource<K>(SymCache<K> src)
            => new SymSource<K>(src.Index);

        [FixedAddressValueType]
        static Symbols<K> Storage;
    }
}