//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.Intrinsics;

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
        public static Vector128<byte> vbutterfly(N1 n, Vector128<byte> x)
            => vbutterfly(x,v66(n128),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vbutterfly(N1 n, Vector128<ushort> x)
            => vbutterfly(x,v6666(n128),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vbutterfly(N1 n, Vector128<uint> x)
            => vbutterfly(x,v66666666(n128),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vbutterfly(N1 n, Vector128<ulong> x)
            => vbutterfly(x,v6666666666666666(n128),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior 2-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vbutterfly(N2 n, Vector128<byte> x)
            => vbutterfly(x,v3C(n128),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vbutterfly(N2 n, Vector128<ushort> x)
            => vbutterfly(x,v3C3C(n128),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vbutterfly(N2 n, Vector128<uint> x)
            => vbutterfly(x,v3C3C3C3C(n128),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vbutterfly(N2 n, Vector128<ulong> x)
            => vbutterfly(x,v3C3C3C3C3C3C3C3C(n128),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 4-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> [0 1 2 3 ] -> [0 2 1 3] </remarks>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vbutterfly(N4 n, Vector128<ushort> x)
            => vbutterfly(x,v0FF0(n128),4);

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
        public static Vector128<uint> vbutterfly(N4 n, Vector128<uint> x)
            => vbutterfly(x,v0FF00FF0(n128),4);

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
        public static Vector128<ulong> vbutterfly(N4 n, Vector128<ulong> x)
            => vbutterfly(x,v0FF00FF00FF00FF0(n128),4);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 8-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>[0 1 2 3] -> [0 2 1 3]</remarks>
        [MethodImpl(Inline)]
        public static Vector128<uint> vbutterfly(N8 n, Vector128<uint> x)
            => vbutterfly(x,v00FFFF00(n128),8);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 8-bit segments of each 32-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> [0 1 2 3 | 4 5 6 7] -> [0 2 1 3 | 4 6 5 7]</remarks>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vbutterfly(N8 n, Vector128<ulong> x)
            => vbutterfly(x,v00FFFF0000FFFF00(n128),8);
 
        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior 16-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>[0 1 2 3] -> [0 2 1 3]</remarks>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vbutterfly(N16 n, Vector128<ulong> x)
            => vbutterfly(x,v0000FFFFFFFF0000(n128),16);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vbutterfly(N1 n, Vector256<byte> x)
            => vbutterfly(x,v66(n256),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vbutterfly(N1 n, Vector256<ushort> x)
            => vbutterfly(x,v6666(n256),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vbutterfly(N1 n, Vector256<uint> x)
            => vbutterfly(x,v66666666(n256),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vbutterfly(N1 n, Vector256<ulong> x)
            => vbutterfly(x,v6666666666666666(n256),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior 2-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vbutterfly(N2 n, Vector256<byte> x)
            => vbutterfly(x,v3C(n256),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vbutterfly(N2 n, Vector256<ushort> x)
            => vbutterfly(x,v3C3C(n256),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vbutterfly(N2 n, Vector256<uint> x)
            => vbutterfly(x,v3C3C3C3C(n256),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vbutterfly(N2 n, Vector256<ulong> x)
            => vbutterfly(x,v3C3C3C3C3C3C3C3C(n256),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 4-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> [0 1 2 3 ] -> [0 2 1 3] </remarks>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vbutterfly(N4 n, Vector256<ushort> x)
            => vbutterfly(x,v0FF0(n256),4);

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
        public static Vector256<uint> vbutterfly(N4 n, Vector256<uint> x)
            => vbutterfly(x,v0FF00FF0(n256),4);

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
        public static Vector256<ulong> vbutterfly(N4 n, Vector256<ulong> x)
            => vbutterfly(x,v0FF00FF00FF00FF0(n256),4);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 8-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>[0 1 2 3] -> [0 2 1 3]</remarks>
        [MethodImpl(Inline)]
        public static Vector256<uint> vbutterfly(N8 n, Vector256<uint> x)
            => vbutterfly(x,v00FFFF00(n256),8);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 8-bit segments of each 32-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> [0 1 2 3 | 4 5 6 7] -> [0 2 1 3 | 4 6 5 7]</remarks>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vbutterfly(N8 n, Vector256<ulong> x)
            => vbutterfly(x,v00FFFF0000FFFF00(n256),8);
 
        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior 16-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>[0 1 2 3] -> [0 2 1 3]</remarks>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vbutterfly(N16 n, Vector256<ulong> x)
            => vbutterfly(x,v0000FFFFFFFF0000(n256),16);

        /// <summary>
        /// Effects a butterfly permutation on the source value, predicated on a supplied mask and shift amount
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>The algorithm follows that of Arndt's Matters Computational, bitbutterfly.h.</remarks>
        [MethodImpl(Inline)]
        static Vector128<T> vbutterfly<T>(Vector128<T> x, Vector128<T> mask, byte shift)
            where T : unmanaged
        {
            var y = ginx.vand(x, mask);
            y = ginx.vxors(y, shift);
            y = ginx.vxor(ginx.vand(y, mask), x);
            return y;
        }

        /// <summary>
        /// Effects a butterfly permutation on the source value, predicated on a supplied mask and shift amount
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>The algorithm follows that of Arndt's Matters Computational, bitbutterfly.h.</remarks>
        [MethodImpl(Inline)]
        static Vector256<T> vbutterfly<T>(Vector256<T> x, Vector256<T> mask, byte shift)
            where T : unmanaged
        {
            var y = ginx.vand(x, mask);
            y = ginx.vxors(y, shift);
            y = ginx.vxor(ginx.vand(y, mask), x);
            return y;
        }

        [MethodImpl(Inline)]
        static Vector128<byte> v66(N128 n)
            => dinx.vbroadcast(n,x66);

        [MethodImpl(Inline)]
        static Vector128<ushort> v6666(N128 n)
            => dinx.vbroadcast(n,x6666);

        [MethodImpl(Inline)]
        static Vector128<uint> v66666666(N128 n)
            => dinx.vbroadcast(n,x66666666);

        [MethodImpl(Inline)]
        static Vector128<ulong> v6666666666666666(N128 n)
            => dinx.vbroadcast(n,x6666666666666666);

        [MethodImpl(Inline)]
        static Vector128<byte> v3C(N128 n)
            => dinx.vbroadcast(n,x3C);

        [MethodImpl(Inline)]
        static Vector128<ushort> v3C3C(N128 n)
            => dinx.vbroadcast(n,x3C3C);

        [MethodImpl(Inline)]
        static Vector128<uint> v3C3C3C3C(N128 n)
            => dinx.vbroadcast(n,x3C3C3C3C);

        [MethodImpl(Inline)]
        static Vector128<ulong> v3C3C3C3C3C3C3C3C(N128 n)
            => dinx.vbroadcast(n,x3C3C3C3C3C3C3C3C);

        [MethodImpl(Inline)]
        static Vector128<ushort> v0FF0(N128 n)
            => dinx.vbroadcast(n,x0FF0);

        [MethodImpl(Inline)]
        static Vector128<uint> v0FF00FF0(N128 n)
            => dinx.vbroadcast(n,x0FF00FF0);

        [MethodImpl(Inline)]
        static Vector128<ulong> v0FF00FF00FF00FF0(N128 n)
            => dinx.vbroadcast(n,x0FF00FF00FF00FF0);

        [MethodImpl(Inline)]
        static Vector128<uint> v00FFFF00(N128 n)
            => dinx.vbroadcast(n,x00FFFF00);

        [MethodImpl(Inline)]
        static Vector128<ulong> v00FFFF0000FFFF00(N128 n)
            => dinx.vbroadcast(n,x00FFFF0000FFFF00);

        [MethodImpl(Inline)]
        static Vector128<ulong> v0000FFFFFFFF0000(N128 n)
            => dinx.vbroadcast(n,x0000FFFFFFFF0000);

        [MethodImpl(Inline)]
        static Vector256<byte> v66(N256 n)
            => dinx.vbroadcast(n,x66);

        [MethodImpl(Inline)]
        static Vector256<ushort> v6666(N256 n)
            => dinx.vbroadcast(n,x6666);

        [MethodImpl(Inline)]
        static Vector256<uint> v66666666(N256 n)
            => dinx.vbroadcast(n,x66666666);

        [MethodImpl(Inline)]
        static Vector256<ulong> v6666666666666666(N256 n)
            => dinx.vbroadcast(n,x6666666666666666);

        [MethodImpl(Inline)]
        static Vector256<byte> v3C(N256 n)
            => dinx.vbroadcast(n,x3C);

        [MethodImpl(Inline)]
        static Vector256<ushort> v3C3C(N256 n)
            => dinx.vbroadcast(n,x3C3C);

        [MethodImpl(Inline)]
        static Vector256<uint> v3C3C3C3C(N256 n)
            => dinx.vbroadcast(n,x3C3C3C3C);

        [MethodImpl(Inline)]
        static Vector256<ulong> v3C3C3C3C3C3C3C3C(N256 n)
            => dinx.vbroadcast(n,x3C3C3C3C3C3C3C3C);

        [MethodImpl(Inline)]
        static Vector256<ushort> v0FF0(N256 n)
            => dinx.vbroadcast(n,x0FF0);

        [MethodImpl(Inline)]
        static Vector256<uint> v0FF00FF0(N256 n)
            => dinx.vbroadcast(n,x0FF00FF0);

        [MethodImpl(Inline)]
        static Vector256<ulong> v0FF00FF00FF00FF0(N256 n)
            => dinx.vbroadcast(n,x0FF00FF00FF00FF0);

        [MethodImpl(Inline)]
        static Vector256<uint> v00FFFF00(N256 n)
            => dinx.vbroadcast(n,x00FFFF00);

        [MethodImpl(Inline)]
        static Vector256<ulong> v00FFFF0000FFFF00(N256 n)
            => dinx.vbroadcast(n,x00FFFF0000FFFF00);

        [MethodImpl(Inline)]
        static Vector256<ulong> v0000FFFFFFFF0000(N256 n)
            => dinx.vbroadcast(n,x0000FFFFFFFF0000);

    }

}