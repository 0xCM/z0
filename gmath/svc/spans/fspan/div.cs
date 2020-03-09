//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    
    using static As;
    using static Checks;
        
    partial class fspan
    {                
        /// <summary>
        /// Computes the floating-point quotient of cells in the left and right operands,
        /// overwriting each left operand cell with the result. 
        /// Specifically, lhs[i] = lhs[i] / rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left source span</param>
        /// <param name="rhs">The right source span</param>
        /// <typeparam name="T">The floating-point type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> div<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var len = Checks.length(lhs,rhs);
            for(var i = 0; i< len; i++)
                lhs[i] = gfp.div(lhs[i], rhs[i]);
            return lhs;
        }

        /// <summary>
        /// Computes in-place the quotient of each source element in the left operand and the right operand
        /// </summary>
        /// <param name="lhs">The left source span</param>
        /// <param name="rhs">The right source span</param>
        /// <typeparam name="T">The floating-point type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> div<T>(Span<T> lhs, T rhs)
            where T : unmanaged
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] = gfp.div(lhs[i], rhs);
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
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Span<T> div<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gfp.div(lhs[i], rhs[i]);
            return dst;
        }
    }
}