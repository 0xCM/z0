//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using api = TableMaps;

    public readonly struct KeyMapIndex<K,I> : IKeyMapIndex<KeyMapIndex<K,I>,K,I>
        where K : unmanaged
        where I : unmanaged
    {
        readonly KeyMap<K,I>[] Data;

        public I MinIndex {get;}

        public I MaxIndex {get;}

        public I[] IndexEntries {get;}

        public ClosedInterval<ulong> Positions {get;}

        public ClosedInterval<ulong> Indices {get;}

        public ulong Offset {get;}

        readonly ulong Count;

        [MethodImpl(Inline)]
        public KeyMapIndex(KeyMap<K,I>[] src, I min, I max)
        {
            Data = src;
            MinIndex = min;
            MaxIndex = max;
            Positions = api.positions(min,max);
            Count = Positions.Width;
            IndexEntries = sys.alloc<I>(Count);
            Offset = Positions.Min;
            Indices = api.indices<K,I>(Positions, MinIndex, MaxIndex);
        }

        [MethodImpl(Inline)]
        public ref KeyMap<K,I> Lookup(K id)
        {
            var index = api.index<K,I>(Positions, id);
            return ref Data[index];
        }

        public ref KeyMap<K,I> this[K id]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(id);
        }

        public ref KeyMap<K,I> this[I index]
        {
            [MethodImpl(Inline)]
            get => ref Data[uint64(index)];
        }

        public ref KeyMap<K,I> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ReadOnlySpan<KeyMap<K,I>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<KeyMap<K,I>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}