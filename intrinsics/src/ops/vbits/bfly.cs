//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using System.Runtime.Intrinsics;

    using static HexConst;

    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vbfly(N1 n, Vector128<byte> x)
            => vbutterfly(x,v666(n128,n8),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vbfly(N1 n, Vector128<ushort> x)
            => vbutterfly(x,v666(n128,n16),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vbfly(N1 n, Vector128<uint> x)
            => vbutterfly(x,v666(n128,n32),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vbfly(N1 n, Vector128<ulong> x)
            => vbutterfly(x,v666(n128,n64),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior 2-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vbfly(N2 n, Vector128<byte> x)
            => vbutterfly(x,v3C(n128,n8),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vbfly(N2 n, Vector128<ushort> x)
            => vbutterfly(x,v3C(n128,n16),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vbfly(N2 n, Vector128<uint> x)
            => vbutterfly(x,v3C(n128,n32),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vbfly(N2 n, Vector128<ulong> x)
            => vbutterfly(x,v3C(n128,n64),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 4-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> [0 1 2 3 ] -> [0 2 1 3] </remarks>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vbfly(N4 n, Vector128<ushort> x)
            => vbutterfly(x,v0FF0(n128,n16),4);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 4-bit segments of each 16-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> 
        /// [0 | 1 2 | 3 || 4 | 5 6 | 7] -> 
        /// [0 | 2 1 | 3 || 4 | 6 5 | 7]
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vbfly(N4 n, Vector128<uint> x)
            => vbutterfly(x,v0FF0(n128,n32),4);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 4-bit segments of each 16-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> 
        /// [0 | 1 2 | 3 || 4 | 5 6 | 7 || 8 | 9 A | B || C | D E | F] ->
        /// [0 | 2 1 | 3 || 4 | 6 5 | 7 || 8 | A 9 | B || C | E D | F]
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vbfly(N4 n, Vector128<ulong> x)
            => vbutterfly(x,v0FF0(n128,n64),4);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 8-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>[0 1 2 3] -> [0 2 1 3]</remarks>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vbfly(N8 n, Vector128<uint> x)
            => vbutterfly(x,v00FFFF00(n128),8);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 8-bit segments of each 32-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> [0 1 2 3 | 4 5 6 7] -> [0 2 1 3 | 4 6 5 7]</remarks>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vbfly(N8 n, Vector128<ulong> x)
            => vbutterfly(x,v00FFFF0000FFFF00(n128),8);
 
        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior 16-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>[0 1 2 3] -> [0 2 1 3]</remarks>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vbfly(N16 n, Vector128<ulong> x)
            => vbutterfly(x,v0000FFFFFFFF0000(n128),16);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vbfly(N1 n, Vector256<byte> x)
            => vbutterfly(x,v666(n256,n8),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vbfly(N1 n, Vector256<ushort> x)
            => vbutterfly(x,v666(n256,n16),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vbfly(N1 n, Vector256<uint> x)
            => vbutterfly(x,v666(n256,n32),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior two bits of each 4-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vbfly(N1 n, Vector256<ulong> x)
            => vbutterfly(x,v666(n256,n64),1);

        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior 2-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vbfly(N2 n, Vector256<byte> x)
            => vbutterfly(x,v3C(n256,n8),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vbfly(N2 n, Vector256<ushort> x)
            => vbutterfly(x,v3C(n256,n16),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vbfly(N2 n, Vector256<uint> x)
            => vbutterfly(x,v3C(n256,n32),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 2-bit segments of each 8-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vbfly(N2 n, Vector256<ulong> x)
            => vbutterfly(x,v3C(n256,n64),2);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 4-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> [0 1 2 3 ] -> [0 2 1 3] </remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vbfly(N4 n, Vector256<ushort> x)
            => vbutterfly(x,v0FF0(n256,n16),4);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 4-bit segments of each 16-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> 
        /// [0 | 1 2 | 3 || 4 | 5 6 | 7] -> 
        /// [0 | 2 1 | 3 || 4 | 6 5 | 7]
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vbfly(N4 n, Vector256<uint> x)
            => vbutterfly(x,v0FF0(n256,n32),4);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 4-bit segments of each 16-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> 
        /// [0 | 1 2 | 3 || 4 | 5 6 | 7 || 8 | 9 A | B || C | D E | F] ->
        /// [0 | 2 1 | 3 || 4 | 6 5 | 7 || 8 | A 9 | B || C | E D | F]
        /// </remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vbfly(N4 n, Vector256<ulong> x)
            => vbutterfly(x,v0FF0(n256,n64),4);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 8-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>[0 1 2 3] -> [0 2 1 3]</remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vbfly(N8 n, Vector256<uint> x)
            => vbutterfly(x,v00FFFF00(n256),8);

        /// <summary>
        /// Effects a butterfly permutation on the bit source that swaps the interior 8-bit segments of each 32-bit segment.
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks> [0 1 2 3 | 4 5 6 7] -> [0 2 1 3 | 4 6 5 7]</remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vbfly(N8 n, Vector256<ulong> x)
            => vbutterfly(x,v00FFFF0000FFFF00(n256),8);
 
        /// <summary>
        /// Effects a butterfly permutation on the source that swaps the interior 16-bit segments
        /// </summary>
        /// <param name="n">The interior segment width selector</param>
        /// <param name="x">The bit source</param>
        /// <remarks>[0 1 2 3] -> [0 2 1 3]</remarks>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vbfly(N16 n, Vector256<ulong> x)
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
        static Vector128<byte> v666(N128 w, N8 n)
            => gvec.vbroadcast(w,BitMasks.Central8x4x2);

        [MethodImpl(Inline)]
        static Vector128<ushort> v666(N128 w, N16 n)
            => gvec.vbroadcast(w,BitMasks.Central16x4x2);

        [MethodImpl(Inline)]
        static Vector128<uint> v666(N128 w, N32 n)
            => gvec.vbroadcast(w,BitMasks.Central32x4x2);

        [MethodImpl(Inline)]
        static Vector128<ulong> v666(N128 w, N64 n)
            => gvec.vbroadcast(w,BitMasks.Central64x4x2);

        [MethodImpl(Inline)]
        static Vector128<byte> v3C(N128 w, N8 f)
            => gvec.vbroadcast(w,BitMasks.Central8x8x4);

        [MethodImpl(Inline)]
        static Vector128<ushort> v3C(N128 w, N16 n)
            => gvec.vbroadcast(w,BitMasks.Central16x8x4);

        [MethodImpl(Inline)]
        static Vector128<uint> v3C(N128 w, N32 n)
            => gvec.vbroadcast(w,BitMasks.Central32x8x4);

        [MethodImpl(Inline)]
        static Vector128<ulong> v3C(N128 w, N64 n)
            => gvec.vbroadcast(w, BitMasks.Central64x8x4);

        [MethodImpl(Inline)]
        static Vector128<ushort> v0FF0(N128 w, N16 n)
            => gvec.vbroadcast(w,BitMasks.Central16x16x8);

        [MethodImpl(Inline)]
        static Vector128<uint> v0FF0(N128 w, N32 n)
            => gvec.vbroadcast(w,BitMasks.Central32x16x8);

        [MethodImpl(Inline)]
        static Vector128<ulong> v0FF0(N128 w, N64 n)
            => gvec.vbroadcast(w,BitMasks.Central64x16x8);

        [MethodImpl(Inline)]
        static Vector128<uint> v00FFFF00(N128 w)
            => gvec.vbroadcast(w,BitMasks.Central32x32x16);

        [MethodImpl(Inline)]
        static Vector128<ulong> v00FFFF0000FFFF00(N128 w)
            => gvec.vbroadcast(w,BitMasks.Central64x32x16);

        [MethodImpl(Inline)]
        static Vector128<ulong> v0000FFFFFFFF0000(N128 w)
            => gvec.vbroadcast(w,BitMasks.Central64x64x32);

        [MethodImpl(Inline)]
        static Vector256<byte> v666(N256 w, N8 n)
            => gvec.vbroadcast(w,BitMasks.Central8x4x2);

        [MethodImpl(Inline)]
        static Vector256<ushort> v666(N256 w, N16 n)
            => gvec.vbroadcast(w,BitMasks.Central16x4x2);

        [MethodImpl(Inline)]
        static Vector256<uint> v666(N256 w, N32 n)
            => gvec.vbroadcast(w,BitMasks.Central32x4x2);

        [MethodImpl(Inline)]
        static Vector256<ulong> v666(N256 w, N64 n)
            => gvec.vbroadcast(w,BitMasks.Central64x4x2);

        [MethodImpl(Inline)]
        static Vector256<byte> v3C(N256 w, N8 n)
            => gvec.vbroadcast(w,BitMasks.Central8x8x4);

        [MethodImpl(Inline)]
        static Vector256<ushort> v3C(N256 w, N16 n)
            => gvec.vbroadcast(w,BitMasks.Central16x8x4);

        [MethodImpl(Inline)]
        static Vector256<uint> v3C(N256 w, N32 n)
            => gvec.vbroadcast(w,BitMasks.Central32x8x4);

        [MethodImpl(Inline)]
        static Vector256<ulong> v3C(N256 w, N64 n)
            => gvec.vbroadcast(w,BitMasks.Central64x8x4);

        [MethodImpl(Inline)]
        static Vector256<ushort> v0FF0(N256 w, N16 n)
            => gvec.vbroadcast(w,BitMasks.Central16x16x8);

        [MethodImpl(Inline)]
        static Vector256<uint> v0FF0(N256 w, N32 n)
            => gvec.vbroadcast(w,BitMasks.Central32x16x8);

        [MethodImpl(Inline)]
        static Vector256<ulong> v0FF0(N256 w, N64 n)
            => gvec.vbroadcast(w,BitMasks.Central64x16x8);

        [MethodImpl(Inline)]
        static Vector256<uint> v00FFFF00(N256 w)
            => gvec.vbroadcast(w,BitMasks.Central32x32x16);

        [MethodImpl(Inline)]
        static Vector256<ulong> v00FFFF0000FFFF00(N256 w)
            => gvec.vbroadcast(w,BitMasks.Central64x32x16);

        [MethodImpl(Inline)]
        static Vector256<ulong> v0000FFFFFFFF0000(N256 w)
            => gvec.vbroadcast(w,BitMasks.Central64x64x32);
    }
}