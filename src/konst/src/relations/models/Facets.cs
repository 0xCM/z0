//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static z;

    public readonly struct Facets
    {
        readonly TableSpan<Facet> Data;

        [MethodImpl(Inline)]
        public static implicit operator Facets(Facet[] src)
            => new Facets(src);

        [MethodImpl(Inline)]
        public static implicit operator Facet[](Facets src)
            => src.Data.Storage;

        [MethodImpl(Inline)]
        public Facets(uint count)
        {
            Data = sys.alloc<Facet>(count);
        }

        [MethodImpl(Inline)]
        public Facets(Facet[] src)
        {
            Data = src;
        }

        public ReadOnlySpan<Facet> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<Facet> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        public ref Facet this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref Facet this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }
    }
}