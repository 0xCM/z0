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
         /// <summary>
        /// Returns true if all supplied values are equal to a target value; false otherwise
        /// </summary>
        /// <param name="src">The values to examine</param>
        /// <param name="target">The value to match</param>
        public static bool eq<T>(ReadOnlySpan<T> src, T target)
            where T : unmanaged
        {
            for(var i=0; i<src.Length; i++)
                if(gmath.neq(src[i], target))
                    return false;
            return true;
        }

        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gmath.eq(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => eq(lhs,rhs,span<bool>(length(lhs,rhs)));

       public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => neq(lhs,rhs,span<bool>(length(lhs,rhs)));

        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : unmanaged
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gmath.neq(lhs[i], rhs[i]);
            return dst;
       }

        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : unmanaged
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gmath.gteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => gteq(lhs,rhs,span<bool>(length(lhs,rhs)));

        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i=0; i< len; i++)
                dst[i] = gmath.gt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => gt(lhs,rhs,span<bool>(length(lhs,rhs)));


        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : unmanaged
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gmath.lt(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => lt(lhs,rhs, span<bool>(length(lhs,rhs)));

        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : unmanaged
        {
            for(var i = 0; i< lhs.Length; i++)
                dst[i] = gmath.lteq(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => lteq(lhs,rhs,span<bool>(length(lhs,rhs)));
    }
}