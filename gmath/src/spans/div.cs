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
                gfp.div(ref lhs[i], rhs[i]);
            return lhs;
        }

        public static Span<T> idiv<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gmath.div(lhs[i], rhs[i]);
            return dst;
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
                gfp.div(ref src[i], rhs);
            return src;
        }


        /// <summary>
        /// Computes integer division between cells in the left and right operands,
        /// overwriting the left operand cell with the result, i.e., lhs[i] = lhs[i] / rhs[i]
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        public static Span<T> idiv<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] = gmath.div(lhs[i], rhs[i]);
            return lhs;
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