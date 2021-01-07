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

    partial class Kinds
    {
        [MethodImpl(Inline), Op]
        public static NatKind nat(ulong n, NumericKind t)
            => new NatKind(null,n,t);

        [MethodImpl(Inline), Op]
        public static NatKind nat(ulong m, ulong n, NumericKind t)
            => new NatKind(m,n,t);

        [MethodImpl(Inline)]
        public static NatKind nat<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatKind(null,nat64u<N>(), Numeric.kind<T>());

        [MethodImpl(Inline)]
        public static NatKind nat<M,N,T>(M m = default,N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatKind(nat64u<M>(),nat64u<N>(), Numeric.kind<T>());
    }
}