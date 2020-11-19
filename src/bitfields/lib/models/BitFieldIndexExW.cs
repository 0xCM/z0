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
        where E : unmanaged
        where W : unmanaged
    {
        readonly BitFieldIndexEntry<E,W>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator BitFieldIndex<E,W>(BitFieldIndexEntry<E,W>[] entries)
            => new BitFieldIndex<E,W>(entries);

        [MethodImpl(Inline)]
        public static implicit operator BitFieldIndexEntry<E,W>[](BitFieldIndex<E,W> src)
            => src.Data;

        [MethodImpl(Inline)]
        public BitFieldIndex(BitFieldIndexEntry<E,W>[] src)
            => Data = src;

        public ReadOnlySpan<BitFieldIndexEntry<E,W>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<BitFieldIndexEntry<E,W>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public uint EntryCount
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ref BitFieldIndexEntry<E,W> this[E index]
        {
            [MethodImpl(Inline)]
            get => ref Data[z.@as<E,int>(index)];
        }

        public ref BitFieldIndexEntry<E,W> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref BitFieldIndexEntry<E,W> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}