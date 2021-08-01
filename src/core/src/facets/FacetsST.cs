//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Facets<K,V> : IIndex<Facet<K,V>>
    {
        readonly Index<Facet<K,V>> Data;

        [MethodImpl(Inline)]
        public Facets(uint count)
            => Data = sys.alloc<Facet<K,V>>(count);

        [MethodImpl(Inline)]
        public Facets(Facet<K,V>[] src)
            => Data = src;

        public ReadOnlySpan<Facet<K,V>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Facet<K,V>[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public Span<Facet<K,V>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref Facet<K,V> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref Facet<K,V> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        [MethodImpl(Inline)]
        public static implicit operator Facets<K,V>(Facet<K,V>[] src)
            => new Facets<K,V>(src);

        [MethodImpl(Inline)]
        public static implicit operator Facet<K,V>[](Facets<K,V> src)
            => src.Data.Storage;
    }
}