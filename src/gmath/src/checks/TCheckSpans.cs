//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using api = CheckSpans;

    public interface TCheckSpans : TValidator, TCheckGeneric
    {
        void Eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => api.eq(lhs,rhs);

        void Eq<T>(Span<T> lhs, Span<T> rhs)
            where T : unmanaged
                => api.eq(lhs,rhs);

    }
}