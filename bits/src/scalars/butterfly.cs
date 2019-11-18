//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;

    using static zfunc;

    partial class Bits
    {                
        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static byte butterfly(N1 n, byte x)
            => butterfly(x,x66,1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort butterfly(N1 n, ushort x)
            => butterfly(x,x6666,1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static uint butterfly(N1 n, uint x)
            => butterfly(x,x66666666,1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong butterfly(N1 n, ulong x)
            => butterfly(x,x6666666666666666,1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior 2-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static byte butterfly(N2 n, byte x)
            => butterfly(x,x3C,2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort butterfly(N2 n, ushort x)
            => butterfly(x,x3C3C,2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static uint butterfly(N2 n, uint x)
            => butterfly(x,x3C3C3C3C,2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static ulong butterfly(N2 n, ulong x)
            => butterfly(x,x3C3C3C3C3C3C3C3C,2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 4-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> [0 1 2 3 ] -> [0 2 1 3] </remarks>
        [MethodImpl(Inline)]
        public static ushort butterfly(N4 n, ushort x)
            => butterfly(x,x0FF0,4);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 4-bit segments of each 16-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> 
        /// [0 | 1 2 | 3 || 4 | 5 6 | 7] -> 
        /// [0 | 2 1 | 3 || 4 | 6 5 | 7]
        /// </remarks>
        [MethodImpl(Inline)]
        public static uint butterfly(N4 n, uint x)
            => butterfly(x,x0FF00FF0,4);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 4-bit segments of each 16-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> 
        /// [0 | 1 2 | 3 || 4 | 5 6 | 7 || 8 | 9 A | B || C | D E | F] ->
        /// [0 | 2 1 | 3 || 4 | 6 5 | 7 || 8 | A 9 | B || C | E D | F]
        /// </remarks>
        [MethodImpl(Inline)]
        public static ulong butterfly(N4 n, ulong x)
            => butterfly(x,x0FF00FF00FF00FF0,4);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 8-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>[0 1 2 3] -> [0 2 1 3]</remarks>
        [MethodImpl(Inline)]
        public static uint butterfly(N8 n, uint x)
            => butterfly(x,x00FFFF00,8);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 8-bit segments of each 32-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> [0 1 2 3 | 4 5 6 7] -> [0 2 1 3 | 4 6 5 7]</remarks>
        [MethodImpl(Inline)]
        public static ulong butterfly(N8 n, ulong x)
            => butterfly(x,x00FFFF0000FFFF00,8);
 
        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior 16-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>[0 1 2 3] -> [0 2 1 3]</remarks>
        [MethodImpl(Inline)]
        public static ulong butterfly(N16 n, ulong x)
            => butterfly(x,x0000FFFFFFFF0000,16);

        /// <summary>
        /// Effects a butterfly permutation on the source value, predicated on a supplied mask and shift amount
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>The algorithm follows that of Arndt's Matters Computational, bitbutterfly.h.</remarks>
        [MethodImpl(Inline)]
        static T butterfly<T>(T x, T mask, int shift)
            where T : unmanaged
        {
            var y = gmath.and(x, mask);
            y = gmath.xors(y, shift);
            y = gmath.xor(gmath.and(y, mask), x);
            return y;
        }
    }
}