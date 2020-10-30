
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct CellVec<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged, IDataCell
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        internal CellVec(T[] src)
            => Data = src;

        public NatSpan<N,T> Cells
        {
            [MethodImpl(Inline)]
            get => new NatSpan<N,T>(Data);
        }

        [MethodImpl(Inline)]
        public ref T Cell<I>(I i)
            where I : unmanaged, ITypeNat
                => ref Data[z.nat32i(i)];
    }
}