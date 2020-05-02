//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IIdentityProducer : IStateless<IdentityProducer,IIdentityProducer>
    {
        [MethodImpl(Inline)]
        NatNumericIdentity NaturalNumeric(ulong n, NumericKind t)   
            => IdentityProducer.Service.NaturalNumeric(n,t);
    }

    [ApiHost]
    public readonly struct IdentityProducer : IIdentityProducer, IApiHost<IdentityProducer>
    {
        public static IIdentityProducer Service => default(IdentityProducer);
        
        [MethodImpl(Inline), Op]
        public NatNumericIdentity NaturalNumeric(ulong n, NumericKind t)   
            => new NatNumericIdentity(null,n,t);

        [MethodImpl(Inline), Op]
        public NatNumericIdentity NaturalNumeric(ulong m, ulong n, NumericKind t)   
            => new NatNumericIdentity(m,n,t);

        [MethodImpl(Inline)]
        public NatNumericIdentity NaturalNumeric<N,T>(N n = default, T t = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatNumericIdentity(null,value<N>(), NumericKinds.kind<T>());

        [MethodImpl(Inline)]
        public NatNumericIdentity NaturalNumeric<M,N,T>(M m = default,N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatNumericIdentity(value<M>(),value<N>(), NumericKinds.kind<T>());
    }
}