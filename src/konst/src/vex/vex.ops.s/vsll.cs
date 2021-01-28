//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static Part;
    using static memory;

    partial struct cpu
    {
        /// <summary>
        /// Defines the unfortunately missing _mm_slli_epi8 that shifts each vector component leftward by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count left</param>
        [MethodImpl(Inline), Sll]
        public static Vector128<byte> vsll(Vector128<byte> src, [Imm] byte count)
        {
            var y = v8u(vsll(v64u(src), count));
            var m = vmsb(n128, n8, (byte)(8 - count), z8);
            return vand(y,m);
        }

        /// <summary>
        /// Shifts each component in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count each component</param>
        [MethodImpl(Inline), Sll]
        public static Vector128<sbyte> vsll(Vector128<sbyte> src, [Imm] byte count)
            => v8i(vsll(src.AsByte(), count));

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Sll]
        public static Vector128<short> vsll(Vector128<short> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Sll]
        public static Vector128<ushort> vsll(Vector128<ushort> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Sll]
        public static Vector128<int> vsll(Vector128<int> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Sll]
        public static Vector128<uint> vsll(Vector128<uint> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Sll]
        public static Vector128<long> vsll(Vector128<long> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Sll]
        public static Vector128<ulong> vsll(Vector128<ulong> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// Shifts each component in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count each component</param>
        [MethodImpl(Inline), Sll]
        public static Vector256<sbyte> vsll(Vector256<sbyte> src, [Imm] byte count)
            => vsll(src.AsByte(), count).AsSByte();

        /// <summary>
        /// Defines the unfortunately missing _mm256_slli_epi16 that shifts each vector component
        /// leftward by a common number of bits
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bits to count left</param>
        [MethodImpl(Inline), Sll]
        public static Vector256<byte> vsll(Vector256<byte> src, [Imm] byte count)
        {
            var y = v8u(vsll(v64u(src), count));
            var m = vmsb(n256, n8, (byte)(8 - count),z8);
            return vand(y,m);
        }

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Sll]
        public static Vector256<short> vsll(Vector256<short> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Sll]
        public static Vector256<ushort> vsll(Vector256<ushort> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Sll]
        public static Vector256<int> vsll(Vector256<int> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Sll]
        public static Vector256<uint> vsll(Vector256<uint> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Sll]
        public static Vector256<long> vsll(Vector256<long> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The number of bits to count</param>
        [MethodImpl(Inline), Sll]
        public static Vector256<ulong> vsll(Vector256<ulong> src, [Imm] byte count)
            => ShiftLeftLogical(src, (byte)count);

        [MethodImpl(Inline), Op]
        static byte msb8f(byte density)
            => (byte)(byte.MaxValue << (8 - density));

        /// <summary>
        /// The f most significant bits of each 8 bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">A value in the range [2,7] that defines the bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        static Vector128<T> vmsb<T>(N128 w, N8 f, byte d, T t = default)
            where T : unmanaged
                => generic<T>(gcpu.vbroadcast<byte>(w, msb8f(d)));

        /// <summary>
        /// Creates a mask where f most significant bits of each 8 bits are enabled
        /// </summary>
        /// <param name="w">The target vector width</param>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">A value in the range [2,7] that defines the bit density</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        static Vector256<T> vmsb<T>(N256 w, N8 f, byte d, T t = default)
            where T : unmanaged
                => generic<T>(gcpu.vbroadcast<byte>(w, msb8f(d)));
    }
}