//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public interface ITypeKindN<N> : ITypeKind
        where N : unmanaged, ITypeNat
    {
        int NaturalArity
        {
            [MethodImpl(Inline)]
            get => (int)NatMath2.natval<N>();
        }
    }

    public interface ITypeKindN1<N> : ITypeKindN<N1>, ITypeKind<N>
        where N : unmanaged, ITypeNat
    {

    }

    public interface ITypeKindN1<N,T> : ITypeKindN<N1>, ITypeKind<N,T>
        where N : unmanaged, ITypeNat
    {

    }


    public interface ITypeKindN2<M,N,T> : ITypeKindN<N2>, ITypeKind<M,N>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
    {

    }
}