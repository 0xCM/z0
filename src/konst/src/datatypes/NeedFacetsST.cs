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

    public readonly struct NeedFacets<S,T>
    {
        readonly TableSpan<NeedFacet<S,T>> Data;

        [MethodImpl(Inline)]
        public static implicit operator NeedFacets<S,T>(NeedFacet<S,T>[] src)
            => new NeedFacets<S,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator NeedFacet<S,T>[](NeedFacets<S,T> src)
            => src.Data.Storage;

        [MethodImpl(Inline)]
        public NeedFacets(uint count)
        {
            Data = sys.alloc<NeedFacet<S,T>>(count);
        }

        [MethodImpl(Inline)]
        public NeedFacets(NeedFacet<S,T>[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<NeedFacet<S,T>> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<NeedFacet<S,T>> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref NeedFacet<S,T> this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref NeedFacet<S,T> this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}