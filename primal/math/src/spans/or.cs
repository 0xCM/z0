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
        public static Span<T> or<T>(Span<T> lhs, in T rhs)
            where T : unmanaged
        {
            for(var i=0; i<lhs.Length; i++)
                lhs[i] = gmath.or(lhs[i], rhs);
            return lhs;
        }

        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i<lhs.Length; i++)
                dst[i] = gmath.or(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> or<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => or(lhs,rhs,lhs);


        [MethodImpl(Inline)]
        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => or(lhs,rhs,lhs.Replicate(true));

    }
}