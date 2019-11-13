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
       public static Span<T> andnot<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i=0; i<len; i++)
                dst[i] = gmath.cnotimply(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> andnot<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => andnot(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<T> andnot<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => andnot(lhs,rhs,lhs.Replicate(true));
    }
}