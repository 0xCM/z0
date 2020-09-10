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

    public readonly struct NeedFacets
    {
        readonly TableSpan<NeedFacet> Data;

        [MethodImpl(Inline)]
        public static implicit operator NeedFacets(NeedFacet[] src)
            => new NeedFacets(src);

        [MethodImpl(Inline)]
        public static implicit operator NeedFacet[](NeedFacets src)
            => src.Data.Storage;

        [MethodImpl(Inline)]
        public NeedFacets(uint count)
        {
            Data = sys.alloc<NeedFacet>(count);
        }

        [MethodImpl(Inline)]
        public NeedFacets(NeedFacet[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<NeedFacet> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<NeedFacet> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref NeedFacet this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref NeedFacet this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}