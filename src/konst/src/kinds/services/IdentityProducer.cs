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

    [ApiHost]
    public readonly struct IdentityProducer
    {
        [MethodImpl(Inline), Op]
        public NatIdentity NaturalNumeric(ulong n, NumericKind t)
            => new NatIdentity(null,n,t);

        [MethodImpl(Inline), Op]
        public NatIdentity NaturalNumeric(ulong m, ulong n, NumericKind t)
            => new NatIdentity(m,n,t);

        [MethodImpl(Inline)]
        public NatIdentity NaturalNumeric<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatIdentity(null,value<N>(), NumericKinds.kind<T>());

        [MethodImpl(Inline)]
        public NatIdentity NaturalNumeric<M,N,T>(M m = default,N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatIdentity(value<M>(),value<N>(), NumericKinds.kind<T>());
    }
}