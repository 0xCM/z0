//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class BitVector
    {
        [MethodImpl(Inline), Eq, Closures(Closure)]
        public static bit eq<T>(in BitVector<T> x, in BitVector<T> y)
            where T : unmanaged
                => gmath.eq(x.Content, y.Content);

        [MethodImpl(Inline)]
        public static bit eq<N,T>(in BitVector<N,T> x, in BitVector<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gmath.eq(x.Content, y.Content);

        [MethodImpl(Inline)]
        public static bit eq<N,T>(in BitVector128<N,T> x, in BitVector128<N,T> y)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => gcpu.vsame(x.Content, y.Content);
    }
}