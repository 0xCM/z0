//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// int _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), MoveMask]
        public static ushort vmask16u(Vector128<byte> src)
            => (ushort)MoveMask(src);

        /// <summary>
        /// int _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), MoveMask]
        public static ushort vmask16u(Vector128<ushort> src)
            => (ushort)MoveMask(v8u(src));

        /// <summary>
        /// int _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), MoveMask]
        public static ushort vmask16u(Vector128<uint> src)
            => (ushort)MoveMask(v8u(src));

        /// <summary>
        /// int _mm_movemask_epi8 (__m128i a) PMOVMSKB reg, xmm
        /// Constructs an integer from the most significant bit of each 8-bit vector segment
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), MoveMask]
        public static ushort vmask16u(Vector128<ulong> src)
            => (ushort)MoveMask(v8u(src));

        /// <summary>
        /// Creates a 32-bit mask from each byte at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), MoveMask]
        public static ushort vmask16u(Vector128<byte> src, [Imm] byte index)
            => vmask16u(vsll(v64u(src), (byte)(7 - index)));

        /// <summary>
        /// Creates a 32-bit mask from each byte at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), MoveMask]
        public static ushort vmask16u(Vector128<ushort> src, [Imm] byte index)
            => vmask16u(vsll(v64u(src), (byte)(7 - index)));

        /// <summary>
        /// Creates a 32-bit mask from each byte at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), MoveMask]
        public static ushort vmask16u(Vector128<uint> src, [Imm] byte index)
            => vmask16u(vsll(v64u(src), (byte)(7 - index)));

        /// <summary>
        /// Creates a 32-bit mask from each byte at a byte-relative bit index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">An integer between 0 and 7</param>
        [MethodImpl(Inline), MoveMask]
        public static ushort vmask16u(Vector128<ulong> src, [Imm] byte index)
            => vmask16u(vsll(v64u(src), (byte)(7 - index)));

        [MethodImpl(Inline), MoveMask]
        public static ushort vmask16u(Vector128<byte> src, byte offset, [Imm] byte index)
            => vmask16u(vsllx(src, offset), index);

        [MethodImpl(Inline), MoveMask]
        public static ushort vmask16u(Vector128<ushort> src, byte offset, [Imm] byte index)
            => vmask16u(vsllx(src, offset), index);

        [MethodImpl(Inline), MoveMask]
        public static ushort vmask16u(Vector128<uint> src, Vector128<uint> offsets, [Imm] byte index)
            => vmask16u(vsllv(src, offsets), index);

        [MethodImpl(Inline), MoveMask]
        public static ushort vmask16u(Vector128<ulong> src, Vector128<ulong> offsets, [Imm] byte index)
            => vmask16u(vsllv(src, offsets), index);

        /// <summary>
        /// int _mm_movemask_ps (__m128 a) MOVMSKPS reg, xmm<
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        [MethodImpl(Inline), Op]
        public static int vmovemask(Vector128<float> src)
            => MoveMask(src);

        /// <summary>
        /// int _mm_movemask_pd (__m128d a) MOVMSKPD reg, xmm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        [MethodImpl(Inline), Op]
        public static int vmovemask(Vector128<double> src)
            => MoveMask(src);

        /// <summary>
        /// int _mm256_movemask_ps (__m256 a) VMOVMSKPS reg, ymm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static int vmovemask(Vector256<float> src)
            => MoveMask(src);

        /// <summary>
        /// int _mm256_movemask_pd (__m256d a) VMOVMSKPD reg, ymm
        /// Constructs an integer from the most significant bit of each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static int vmovemask(Vector256<double> src)
            => MoveMask(src);
    }
}