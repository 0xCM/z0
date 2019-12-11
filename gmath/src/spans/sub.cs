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
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var count = length(lhs,rhs);
            for(var i = 0; i< count; i++)
                dst[i] = gmath.sub(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<T> sub<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var count = length(lhs,rhs);
            for(var i = 0; i< count; i++)
                lhs[i] = gmath.sub(lhs[i], rhs[i]);
            return lhs;
        }
    }
}