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
        void Eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => CheckNumeric.eq(lhs,rhs);

        void Eq<T>(Span<T> lhs, Span<T> rhs)
            where T : unmanaged
                => CheckNumeric.eq(lhs,rhs);
    }
}