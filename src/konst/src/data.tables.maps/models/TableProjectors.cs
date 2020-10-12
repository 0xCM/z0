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

    public readonly struct TableProjectors<D,S,T,Y>
        where D : unmanaged
        where T : struct
        where S : unmanaged
    {
        readonly TableProjector<D,S,T,Y>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator TableProjectors<D,S,T,Y>(TableProjector<D,S,T,Y>[] src)
            => new TableProjectors<D,S,T,Y>(src);

        [MethodImpl(Inline)]
        public TableProjectors(TableProjector<D,S,T,Y>[] src)
            => Data = src;

        public Count Count
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<TableProjector<D,S,T,Y>> View
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public Span<TableProjector<D,S,T,Y>> Edit
        {
            [MethodImpl(Inline)]
            get => Data;
        }
    }
}