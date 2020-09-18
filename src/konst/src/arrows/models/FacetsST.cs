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

    public readonly struct Facets<S,T>
    {
        readonly TableSpan<Facet<S,T>> Data;

        [MethodImpl(Inline)]
        public static implicit operator Facets<S,T>(Facet<S,T>[] src)
            => new Facets<S,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator Facet<S,T>[](Facets<S,T> src)
            => src.Data.Storage;

        [MethodImpl(Inline)]
        public Facets(uint count)
        {
            Data = sys.alloc<Facet<S,T>>(count);
        }

        [MethodImpl(Inline)]
        public Facets(Facet<S,T>[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<Facet<S,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<Facet<S,T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref Facet<S,T> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref Facet<S,T> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}