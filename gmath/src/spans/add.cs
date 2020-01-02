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
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var count = length(lhs,rhs);
            for(var i=0; i < count; i++)
                dst[i] = gmath.add(lhs[i],rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> add<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged        
        {
            for(var i=0; i< length(lhs,rhs); i++)
                lhs[i] = gmath.add(lhs[i], rhs[i]);
            return lhs;
        }

        /// <summary>
        /// Adds a scalar value to each element of the source span in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="scalar">The scalar value</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> add<T>(Span<T> src, T scalar)
            where T : unmanaged
        {
            for(var i=0; i< src.Length; i++)
                src[i] = gmath.add(src[i],scalar);
            return src;
        }

    }
}