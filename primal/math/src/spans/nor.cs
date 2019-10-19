//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {
        public static Span<T> nor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i=0; i<len; i++)
                dst[i] = gmath.nor(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> nor<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => nor(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<T> nor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => nor(lhs,rhs,lhs.Replicate(true));

    }

}