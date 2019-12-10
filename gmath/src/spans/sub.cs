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
        /// Subracts a common value from each element in the left operand
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The primal element type</typeparam>
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, T rhs)
            where T : unmanaged
        {
            Span<T> dst = new T[lhs.Length];
            dst.Fill(rhs);   
            sub(lhs, dst, dst);
            return dst;
        }

        /// <summary>
        /// Subtracts a scalar value from each element of the source span in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="scalar">The scalar value</param>
        /// <typeparam name="T">The span element type</typeparam>
        public static Span<T> sub<T>(Span<T> src, T scalar)
            where T : unmanaged
        {
            for(var i=0; i< src.Length; i++)
                src[i] = gmath.sub(src[i],scalar);
            return src;
        }
        
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gmath.sub(lhs[i], rhs[i]);
            return dst;
        }

        public static Span<T> sub<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] = gmath.sub(lhs[i], rhs[i]);
            return lhs;
        }
    }
}