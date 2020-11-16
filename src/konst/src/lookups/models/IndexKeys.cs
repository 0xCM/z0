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

    public readonly struct IndexKeys<K,I> : IKeyMap<IndexKeys<K,I>,K,I>
        where K : unmanaged
        where I : unmanaged
    {
        readonly IndexKey<K,I>[] Data;

        public I MinIndex {get;}

        public I MaxIndex {get;}

        public I[] IndexEntries {get;}

        public ClosedInterval<ulong> Positions {get;}

        public ClosedInterval<ulong> Indices {get;}

        public ulong Offset {get;}

        readonly ulong Count;

        [MethodImpl(Inline)]
        public IndexKeys(IndexKey<K,I>[] src, I min, I max)
        {
            Data = src;
            MinIndex = min;
            MaxIndex = max;
            Positions = IndexKeys.positions(min,max);
            Count = Positions.Width;
            IndexEntries = sys.alloc<I>(Count);
            Offset = Positions.Min;
            Indices = IndexKeys.indices<I>(Positions, MinIndex, MaxIndex);
        }

        [MethodImpl(Inline)]
        public ref IndexKey<K,I> Lookup(K key)
            => ref Data[index(Positions, key)];


        [MethodImpl(Inline)]
        public ref IndexKey<K,I> Lookup(I index)
            => ref Data[uint64(index)];

        public ref IndexKey<K,I> this[K key]
        {
            [MethodImpl(Inline)]
            get => ref Lookup(key);
        }

        public ref IndexKey<K,I> this[I index]
        {
            [MethodImpl(Inline)]
            get => ref Data[uint64(index)];
        }

        public ref IndexKey<K,I> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ReadOnlySpan<IndexKey<K,I>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<IndexKey<K,I>> Edit
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
        static ulong index(in IndexKey<K,I> selector, ulong offset)
            => uint64(selector.Index) - offset;
    }
}