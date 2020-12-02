//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface TCheckSpans : TValidator, TCheckGeneric
    {
        void eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => CheckNumeric.eq(lhs,rhs);

        void eq<T>(Span<T> lhs, Span<T> rhs)
            where T : unmanaged
                => CheckNumeric.eq(lhs,rhs);

        void eq<N,T>(NatSpan<N,T> lhs, NatSpan<N,T> rhs)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                 => CheckNumeric.eq(lhs,rhs);

       void eq<M,N,T>(TableSpan<M,N,T> lhs, TableSpan<M,N,T> rhs)
            where N : unmanaged, ITypeNat
            where M : unmanaged, ITypeNat
            where T : unmanaged
                => CheckNumeric.eq(lhs,rhs);
    }
}