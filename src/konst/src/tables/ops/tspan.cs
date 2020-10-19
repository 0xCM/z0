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

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static TableSpan<M,N,T> tspan<M,N,T>(M m = default, N n = default, T fill = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new TableSpan<M,N,T>(fill);

        [MethodImpl(Inline)]
        public static TableSpan<M,N,T> tspan<M,N,T>(ref T src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new TableSpan<M,N,T>(ref src);

        [MethodImpl(Inline)]
        public static TableSpan<M,N,T> tspan<M,N,T>(Span<T> src, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => TableSpan<M,N,T>.CheckedTransfer(src);
    }
}