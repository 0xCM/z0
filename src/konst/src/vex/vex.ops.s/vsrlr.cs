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

    partial struct cpu
    {
        /// <summary>
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vsrlr(Vector128<byte> src, Vector128<byte> count)
        {
            var y = v16u(count);
            var dst = vsrlr(cpu.vinflate16u(src,w256),y);
            return cpu.vcompact8u(dst, w128);
        }

        /// <summary>
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vsrlr(Vector128<sbyte> src, Vector128<sbyte> count)
        {
            var y = v16i(count);
            var dst = vsrlr(cpu.vinflate16i(src, w256),y);
            return cpu.vcompact8i(dst, w128);
        }

        /// <summary>
        ///  __m128i _mm_srl_epi16 (__m128i a, __m128i count) PSRLW xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vsrlr(Vector128<short> src, Vector128<short> count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m128i _mm_srl_epi16 (__m128i a, __m128i count) PSRLW xmm, xmm/m128
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vsrlr(Vector128<ushort> src, Vector128<ushort> count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m128i _mm_srl_epi16 (__m128i a, __m128i count) PSRLW xmm, xmm/m128
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vsrlr(Vector128<int> src, Vector128<int> count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m128i _mm_srl_epi32 (__m128i a, __m128i count) PSRLD xmm, xmm/m128
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vsrlr(Vector128<uint> src, Vector128<uint> count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m128i _mm_srl_epi64 (__m128i a, __m128i count) PSRLQ xmm, xmm/m128
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vsrlr(Vector128<long> src, Vector128<long> count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m128i _mm_srl_epi64 (__m128i a, __m128i count) PSRLQ xmm, xmm/m128
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vsrlr(Vector128<ulong> src, Vector128<ulong> count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vsrlr(Vector256<sbyte> src, Vector128<sbyte> count)
        {
            var y = v16i(count);
            var lo = vsrlr(cpu.vinflate16i(vlo(src),w256), y);
            var hi = vsrlr(cpu.vinflate16i(cpu.vhi(src), w256),y);
            return cpu.vcompact8i(lo, hi, w256);
        }

        /// <summary>
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vsrlr(Vector256<byte> src, Vector128<byte> count)
        {
            var y = v16u(count);
            var lo = vsrlr(cpu.vinflate16u(vlo(src), w256),y);
            var hi = vsrlr(cpu.vinflate16u(cpu.vhi(src), w256),y);
            return cpu.vcompact8u(lo, hi, w256);
        }

        /// <summary>
        /// __m256i _mm256_srl_epi16 (__m256i a, __m128i count)VPSRLW ymm, ymm, xmm/m128
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vsrlr(Vector256<short> src, Vector128<short> count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m256i _mm256_srl_epi16 (__m256i a, __m128i count)VPSRLW ymm, ymm, xmm/m128
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vsrlr(Vector256<ushort> src, Vector128<ushort> count)
            => ShiftRightLogical(src, count);

        /// <summary>
        ///  __m256i _mm256_srl_epi32 (__m256i a, __m128i count) VPSRLD ymm, ymm, xmm/m128
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vsrlr(Vector256<int> src, Vector128<int> count)
            => ShiftRightLogical(src, count);

        /// <summary>
        ///  __m256i _mm256_srl_epi32 (__m256i a, __m128i count) VPSRLD ymm, ymm, xmm/m128
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vsrlr(Vector256<uint> src, Vector128<uint> count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m256i _mm256_srl_epi64 (__m256i a, __m128i count) VPSRLQ ymm, ymm, xmm/m128
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vsrlr(Vector256<long> src, Vector128<long> count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// __m256i _mm256_srl_epi64 (__m256i a, __m128i count) VPSRLQ ymm, ymm, xmm/m128
        /// Shifts each source vector component rightwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vsrlr(Vector256<ulong> src, Vector128<ulong> count)
            => ShiftRightLogical(src, count);

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vsrlr(Vector128<sbyte> src, sbyte count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vsrlr(Vector128<byte> src, byte count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vsrlr(Vector128<short> src, short count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vsrlr(Vector128<ushort> src, ushort count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vsrlr(Vector128<int> src, int count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vsrlr(Vector128<uint> src, uint count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vsrlr(Vector128<long> src, long count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vsrlr(Vector128<ulong> src, ulong count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vsrlr(Vector256<sbyte> src, sbyte count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vsrlr(Vector256<byte> src, byte count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vsrlr(Vector256<short> src, short count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vsrlr(Vector256<ushort> src, ushort count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vsrlr(Vector256<int> src, int count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vsrlr(Vector256<uint> src, uint count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vsrlr(Vector256<long> src, long count)
            => vsrlr(src, cpu.vscalar(w128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vsrlr(Vector256<ulong> src, ulong count)
            => vsrlr(src, cpu.vscalar(w128,count));
    }
}