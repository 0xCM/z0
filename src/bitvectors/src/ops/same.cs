//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class BitVector
    {
        [MethodImpl(Inline), Eq, Closures(UnsignedInts)]
        public static Bit32 eq<T>(in BitVector<T> x, in BitVector<T> y)
            where T : unmanaged
                => gmath.eq(x.Data,y.Data);

        [MethodImpl(Inline)]
        public static Bit32 eq<N,T>(in BitVector<N,T> x, in BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.eq(x.Data,y.Data);

        [MethodImpl(Inline)]
        public static Bit32 eq<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gvec.vsame(x.Data, y.Data);
    }
}