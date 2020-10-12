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

    public readonly struct KeyMap<K,I> : IKeyMap<KeyMap<K,I>,K,I>
        where K : unmanaged
        where I : unmanaged
    {
        readonly KeyedIndex<K,I>[] Data;

        public I MinIndex {get;}

        public I MaxIndex {get;}

        public I[] IndexEntries {get;}

        public ClosedInterval<ulong> Positions {get;}

        public ClosedInterval<ulong> Indices {get;}

        public ulong Offset {get;}

        readonly ulong Count;

        [MethodImpl(Inline)]
        public KeyMap(KeyedIndex<K,I>[] src, I min, I max)
        {
            Data = src;
            MinIndex = min;
            MaxIndex = max;
            Positions = KeyMaps.positions(min,max);
            Count = Positions.Width;
            IndexEntries = sys.alloc<I>(Count);
            Offset = Positions.Min;
            Indices = KeyMaps.indices<I>(Positions, MinIndex, MaxIndex);
        }

        [MethodImpl(Inline)]
        public ref KeyedIndex<K,I> Lookup(K key)
            => ref Data[index(Positions, key)];


        [MethodImpl(Inline)]
        public ref KeyedIndex<K,I> Lookup(I index)
            => ref Data[uint64(index)];

        public ref KeyedIndex<K,I> this[K key]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(key);
        }

        public ref KeyedIndex<K,I> this[I index]
        {
            [MethodImpl(Inline)]
            get => ref Data[uint64(index)];
        }

        public ref KeyedIndex<K,I> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ReadOnlySpan<KeyedIndex<K,I>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<KeyedIndex<K,I>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        [MethodImpl(Inline)]
        static ulong scalar<D,S>(D id)
            where D : unmanaged
            where S : unmanaged
                => force<S,ulong>(z.@as<D,S>(id));

        [MethodImpl(Inline)]
        static ulong index(in ClosedInterval<ulong> positions, in K key)
        {
            var position = scalar<K,I>(key);
            var offset = positions.Min;
            return position - offset;
        }

        [MethodImpl(Inline)]
        static ulong index(in KeyedIndex<K,I> selector, ulong offset)
            => uint64(selector.Index) - offset;
    }
}