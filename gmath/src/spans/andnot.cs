//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {
        [MethodImpl(Inline)]
        public static Span<T> cnonimpl<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var count = length(lhs,rhs);
            for(var i=0; i<count; i++)
                dst[i] = gmath.cnonimpl(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> cnonimpl<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => cnonimpl(lhs,rhs,lhs);

        public static Span<T> cnonimpl<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => cnonimpl(lhs,rhs, span<T>(length(lhs,rhs)));
    }
}