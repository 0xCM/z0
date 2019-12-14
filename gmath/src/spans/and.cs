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
        [MethodImpl(Inline)]
        public static Span<T> and<T>(Span<T> lhs, in T rhs)
            where T : unmanaged
        {
            var count = lhs.Length;
            for(var i=0; i< count; i++)
                lhs[i] = gmath.and(lhs[i],rhs);
            return lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var count = length(lhs,rhs);
            for(var i=0; i<count; i++)
                dst[i] = gmath.and(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> and<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => and(lhs,rhs,lhs);

        public static Span<T> and<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => and(lhs,rhs, span<T>(length(lhs,rhs)));

        public static Block256<T> and<T>(Block256<T> lhs, Block256<T> rhs)
            where T : unmanaged
        {
            var dst = DataBlocks.alloc<T>(n256,lhs.BlockCount);
            and(lhs,rhs, dst.Data);
            return dst;
        }            
    }
}