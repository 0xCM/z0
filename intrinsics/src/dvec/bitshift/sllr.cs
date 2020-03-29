//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
    
    using static Core;    
    using static vgeneric;
    
    partial class dvec
    {           
        /// <summary>
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vsllr(Vector128<byte> src, Vector128<byte> count)
        {
            var y = v16u(count);
            var dst = vsllr(vinflate(src,n256,z16),y);
            return vcompact(dst, n128, z8);
        }

        /// <summary>
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vsllr(Vector128<sbyte> src, Vector128<sbyte> count)
        {
            var y = v16i(count);
            var dst = vsllr(vinflate(src,n256,z16i),y);
            return vcompact(dst, n128, z8i);
        }

        /// <summary>
        ///  __m128i _mm_sll_epi16 (__m128i a, __m128i count) PSRLW xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vsllr(Vector128<short> src, Vector128<short> count)
            => ShiftLeftLogical(src, count);

        /// <summary>
        /// __m128i _mm_sll_epi16 (__m128i a, __m128i count) PSRLW xmm, xmm/m128
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vsllr(Vector128<ushort> src, Vector128<ushort> count)
            => ShiftLeftLogical(src, count);

        /// <summary>
        /// __m128i _mm_sll_epi16 (__m128i a, __m128i count) PSRLW xmm, xmm/m128
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vsllr(Vector128<int> src, Vector128<int> count)
            => ShiftLeftLogical(src, count);

        /// <summary>
        /// __m128i _mm_sll_epi32 (__m128i a, __m128i count) PSRLD xmm, xmm/m128
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vsllr(Vector128<uint> src, Vector128<uint> count)
            => ShiftLeftLogical(src, count);

        /// <summary>
        /// __m128i _mm_sll_epi64 (__m128i a, __m128i count) PSRLQ xmm, xmm/m128
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vsllr(Vector128<long> src, Vector128<long> count)
            => ShiftLeftLogical(src, count);

        /// <summary>
        /// __m128i _mm_sll_epi64 (__m128i a, __m128i count) PSRLQ xmm, xmm/m128
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vsllr(Vector128<ulong> src, Vector128<ulong> count)
            => ShiftLeftLogical(src, count);

        /// <summary>
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vsllr(Vector256<sbyte> src, Vector128<sbyte> count)
        {
            var y = v16i(count);
            var lo = vsllr(vinflate(vlo(src),n256,z16i),y);
            var hi = vsllr(vinflate(vhi(src),n256,z16i),y);
            return vcompact(lo,hi, n256, z8i);
        }

        /// <summary>
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vsllr(Vector256<byte> src, Vector128<byte> count)
        {
            var y = v16u(count);
            var lo = vsllr(vinflate(vlo(src),n256,z16),y);
            var hi = vsllr(vinflate(vhi(src),n256,z16),y);
            return vcompact(lo,hi, n256, z8);
        }

        /// <summary>
        /// __m256i _mm256_sll_epi16 (__m256i a, __m128i count)VPSRLW ymm, ymm, xmm/m128
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vsllr(Vector256<short> src, Vector128<short> count)
            => ShiftLeftLogical(src, count);

        /// <summary>
        /// __m256i _mm256_sll_epi16 (__m256i a, __m128i count)VPSRLW ymm, ymm, xmm/m128
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vsllr(Vector256<ushort> src, Vector128<ushort> count)
            => ShiftLeftLogical(src, count);

        /// <summary>
        ///  __m256i _mm256_sll_epi32 (__m256i a, __m128i count) VPSRLD ymm, ymm, xmm/m128
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vsllr(Vector256<int> src, Vector128<int> count)
            => ShiftLeftLogical(src, count);

        /// <summary>
        ///  __m256i _mm256_sll_epi32 (__m256i a, __m128i count) VPSRLD ymm, ymm, xmm/m128
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vsllr(Vector256<uint> src, Vector128<uint> count)
            => ShiftLeftLogical(src, count);

        /// <summary>
        /// __m256i _mm256_sll_epi64 (__m256i a, __m128i count) VPSRLQ ymm, ymm, xmm/m128
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vsllr(Vector256<long> src, Vector128<long> count)
            => ShiftLeftLogical(src, count);

        /// <summary>
        /// __m256i _mm256_sll_epi64 (__m256i a, __m128i count) VPSRLQ ymm, ymm, xmm/m128
        /// Shifts each source vector component leftwards by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vsllr(Vector256<ulong> src, Vector128<ulong> count)
            => ShiftLeftLogical(src, count);

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vsllr(Vector128<sbyte> src, sbyte count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vsllr(Vector128<byte> src, byte count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vsllr(Vector128<short> src, short count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vsllr(Vector128<ushort> src, ushort count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vsllr(Vector128<int> src, int count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vsllr(Vector128<uint> src, uint count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vsllr(Vector128<long> src, long count)
            => vsllr(src, vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vsllr(Vector128<ulong> src, ulong count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vsllr(Vector256<sbyte> src, sbyte count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vsllr(Vector256<byte> src, byte count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vsllr(Vector256<short> src, short count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vsllr(Vector256<ushort> src, ushort count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vsllr(Vector256<int> src, int count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vsllr(Vector256<uint> src, uint count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vsllr(Vector256<long> src, long count)
            => vsllr(src, vdirect.vscalar(n128,count));

        /// <summary>
        /// Promotes the offset scalar to a vector and applies the register-based right shift operator
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vsllr(Vector256<ulong> src, ulong count)
            => vsllr(src, vdirect.vscalar(n128,count));
    }
}