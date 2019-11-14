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
        public static Span<T> mod<T>(Span<T> lhs, T rhs)
            where T : unmanaged
        {
            for(var i=0; i<lhs.Length; i++)
                gmath.mod(ref lhs[i],rhs);
            return lhs;
        }

        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i=0; i<len; i++)
                dst[i] = gmath.mod(lhs[i],rhs[i]);
            return dst;
        }

        public static Span<T> mod<T>(ReadOnlySpan<T> lhs, T rhs, Span<T> dst)
            where T : unmanaged
        {
            var len = length(lhs,dst);
            for(var i=0; i<len; i++)
                dst[i] = gmath.mod(lhs[i],rhs);
            return dst;
        }

        public static Span<T> mod<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i=0; i<len; i++)
                gmath.mod(ref lhs[i],rhs[i]);
            return lhs;
        }

        /// <summary>
        /// Computes the floating-point modulus of cells in the left and right operands,
        /// overwriting each left operand cell with the result. 
        /// Specifically, lhs[i] = lhs[i] ^ rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> fmod<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                gfp.mod(ref lhs[i], rhs[i]);
            return lhs;
        }

        /// <summary>
        /// Computes the floating-point modulus of cells in the left and right operands,
        /// and writes the result in the target operand
        /// Specifically, dst[i] = lhs[i] ^ rhs[i] for i = 0...n - 1 where n is the common length of the operands
        /// </summary>
        /// <param name="lhs">The left integer source</param>
        /// <param name="rhs">The right integer source</param>
        /// <typeparam name="T">The primal floating-point type</typeparam>
        public static Span<T> fmod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gfp.mod(lhs[i], rhs[i]);
            return dst;
        }
    }
}