//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    
    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;
    
    using static Konst;        
    using static core;

    partial class math
    {                
        /// <summary>
        /// Computes the full 128-bit product between two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static unsafe void mul64x128(in Pair<ulong> src, ref Pair<ulong> dst)                 
            => dst.Right = MultiplyNoFlags(src.Left, src.Right, gptr(dst.Left));

        /// <summary>
        /// Computes the full 128-bit product between two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="z">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static ref Pair<ulong> mul64x128(in ulong a, in ulong b, ref Pair<ulong> z)
        {                         
            mul64x128((a,b), ref z);
            return ref z;
        }

        /// <summary>
        /// Computes the full 128-bit products between corresponding 64-bit span elements
        /// </summary>
        /// <param name="xs">The left operands</param>
        /// <param name="xs">The right operands</param>
        /// <param name="zs">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static void mul64x128(ReadOnlySpan<ulong> xs, ReadOnlySpan<ulong> ys, Span<Pair<ulong>> zs)
        {
            var count = min(min(xs.Length, ys.Length), zs.Length);
            for(var i=0u; i<count; i++)
                mul64x128(skip(first(xs), i), skip(in first(ys), i), ref seek(first(zs), i));
        }

        /// <summary>
        /// Computes the full 128-bit products between 64-bit span elements and a 64-bit scalar
        /// </summary>
        /// <param name="xs">The left operands</param>
        /// <param name="xs">The scalar value</param>
        /// <param name="zs">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static void mul64x128(ReadOnlySpan<ulong> xs, ulong a, Span<Pair<ulong>> zs)
        {
            var count = xs.Length;
            for(var i=0u; i<count; i++)
                mul64x128(skip(first(xs), i), a, ref seek(first(zs), i));
        }
    }
}