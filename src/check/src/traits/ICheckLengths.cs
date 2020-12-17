//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using api = CheckLengths;

    public interface ICheckLengths : IValidator
    {
        int length<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            => api.length(lhs, rhs);

        int length<T>(T[] lhs, T[] rhs)
             => api.length(lhs, rhs);

        int length<T>(Span<T> lhs, Span<T> rhs)
            => api.length(lhs, rhs);
    }
}
