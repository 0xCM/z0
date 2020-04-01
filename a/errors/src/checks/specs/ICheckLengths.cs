//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface ICheckLengths : IValidator
    {
        [MethodImpl(Inline)]   
        int length<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            => Claim.length(lhs, rhs);

        [MethodImpl(Inline)]   
        int length<T>(T[] lhs, T[] rhs)
            => Claim.length(lhs, rhs);

        [MethodImpl(Inline)]   
        int length<T>(Span<T> lhs, Span<T> rhs)
            => Claim.length(lhs, rhs);
    }
}
