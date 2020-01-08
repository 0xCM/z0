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
        /// <summary>
        /// Computes the floating-point quotient of cells in the left and right operands,
        /// overwriting each left operand cell with the result. 
        /// Specifically, lhs[i] = lhs[i] / rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        public static Span<T> fdiv<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] = gfp.div(lhs[i], rhs[i]);
            return lhs;
        }

        /// <summary>
        /// Computes in-place the quotient of each source element in the left operand and the right operand
        /// </summary>
        /// <param name="src"></param>
        /// <param name="rhs"></param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        public static Span<T> fdiv<T>(Span<T> src, T rhs)
            where T : unmanaged
        {
            for(var i = 0; i< src.Length; i++)
                src[i] = gfp.div(src[i], rhs);
            return src;
        }


        /// <summary>
        /// Computes the floating-point quotient of cells in the left and right operands,
        /// and writes the result in the target operand
        /// Specifically, dst[i] = lhs[i] / rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        public static Span<T> fdiv<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gfp.div(lhs[i], rhs[i]);
            return dst;
        }
    }

}