//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BitFieldIndex<E,W>
        where E : unmanaged, Enum
        where W : unmanaged, Enum
    {
        readonly BitFieldIndexEntry<E,W>[] Storage;

        [MethodImpl(Inline)]
        public static implicit operator BitFieldIndex<E,W>(BitFieldIndexEntry<E,W>[] entries)
            => new BitFieldIndex<E,W>(entries);

        [MethodImpl(Inline)]
        public static implicit operator BitFieldIndexEntry<E,W>[](BitFieldIndex<E,W> src)
            => src.Storage;

        [MethodImpl(Inline)]
        public BitFieldIndex(BitFieldIndexEntry<E,W>[] src)
        {
            Storage = src;
        }

        public ReadOnlySpan<BitFieldIndexEntry<E,W>> View
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        public Span<BitFieldIndexEntry<E,W>> Edit
        {
            [MethodImpl(Inline)]
            get => Storage;
        }

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => (uint)Storage.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Storage.Length;
        }

        public ref BitFieldIndexEntry<E,W> this[E index]
        {
            [MethodImpl(Inline)]
            get => ref Storage[Enums.scalar<E,int>(index)];
        }

        public ref BitFieldIndexEntry<E,W> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Storage[index];
        }

        public ref BitFieldIndexEntry<E,W> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Storage[index];
        }
    }
}