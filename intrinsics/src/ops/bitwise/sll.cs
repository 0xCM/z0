//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
    
    using static zfunc;
    
    partial class dinx
    {   
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsll(Vector256<sbyte> src, Vector128<sbyte> shift)
            => vsll(src, (byte)shift.Item(0));

        [MethodImpl(Inline)]
        public static Vector256<byte> vsll(Vector256<byte> src, Vector128<byte> shift)
            => vsll(src, shift.Item(0));

        /// <summary>
        /// __m256i _mm256_sll_epi16 (__m256i a, __m128i count)VPSLLW ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<short> vsll(Vector256<short> src, Vector128<short> shift)
            => ShiftLeftLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_sll_epi16 (__m256i a, __m128i count) VPSLLW ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsll(Vector256<ushort> src, Vector128<ushort> shift)
            => ShiftLeftLogical(src, shift);

        /// <summary>
        ///  __m256i _mm256_sll_epi32 (__m256i a, __m128i count) VPSLLD ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<int> vsll(Vector256<int> src, Vector128<int> shift)
            => ShiftLeftLogical(src, shift);

        /// <summary>
        ///  __m256i _mm256_sll_epi32 (__m256i a, __m128i count) VPSLLD ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsll(Vector256<uint> src, Vector128<uint> shift)
            => ShiftLeftLogical(src, shift);

        /// <summary>
        /// _m256i _mm256_sll_epi64 (__m256i a, __m128i count)VPSLLQ ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<long> vsll(Vector256<long> src, Vector128<long> shift)
            => ShiftLeftLogical(src, shift);

        /// <summary>
        /// _m256i _mm256_sll_epi64 (__m256i a, __m128i count)VPSLLQ ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsll(Vector256<ulong> src, Vector128<ulong> shift)
            => ShiftLeftLogical(src, shift);

        /// <summary>
        /// Shifts each componet in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vsll(Vector128<byte> src, int shift)
        {
            // Lift the source vector into a space where the SLL operation exists and perform it there
            var x = vconvert(src, out Vector256<ushort> _);

            // Truncate overflows to set up the component pattern [X 0 X 0 ... X 0]
            var mask =  ginx.vpclearalt<byte>(n256);
            var a = vshuf16x8(v8u(dinx.vsll(x, shift)), mask);

            // Transform the result back the source space
            var perm = ginx.vplanemerge<byte>();
            return vlo(vshuf32x8(a, perm));
        }


        /// <summary>
        /// Shifts each componet in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vsll(Vector128<sbyte> src, int shift)
            => vsll(src.AsByte(), shift).AsSByte();

        /// <summary>
        /// Shifts each componet in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsll(Vector256<sbyte> src, int shift)
            => vsll(src.AsByte(), shift).AsSByte();

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsll(Vector128<ushort> src, int shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsll(Vector128<int> src, int shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_slli_epi32 (__m128i a, int immediate) PSLLD xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsll(Vector128<uint> src, int shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsll(Vector128<long> src, int shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_slli_epi64 (__m128i a, int immediate) PSLLQ xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsll(Vector128<ulong> src, int shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// Shifts each componet in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vsll(Vector256<byte> src, int shift)
        {
            //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
            var x = vconvert(vlo(src), out Vector256<ushort> _);
            var y = vconvert(vhi(src), out Vector256<ushort> _);

            // Shift each part with a concrete intrinsic anc convert back to bytes and truncate overflows 
            // to set up the component pattern [X 0 X 0 ... X 0] in each vector
            var mask =  ginx.vpclearalt<byte>(n256);
            var a = vshuf16x8(v8u(dinx.vsll(x, shift)), mask);
            var b = vshuf16x8(v8u(dinx.vsll(y, shift)), mask);

            // Each vector contains 16 values that need to be merged
            // back into a single vector. The strategey is to condense
            // each vector via the "lane merge" pattern and construct
            // the result vector via insertion of these condensed vectors
            var permSpec = ginx.vplanemerge<byte>();
            return dinx.vconcat(
                vlo(vshuf32x8(a, permSpec)), 
                vlo(vshuf32x8(b, permSpec)));            
        }

        /// <summary>
        /// __m128i _mm_slli_epi16 (__m128i a, int immediate) PSLLW xmm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vsll(Vector128<short> src, int shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vsll(Vector256<short> src, int shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_slli_epi16 (__m256i a, int imm8) VPSLLW ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsll(Vector256<ushort> src, int shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsll(Vector256<int> src, int shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_slli_epi32 (__m256i a, int imm8) VPSLLD ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsll(Vector256<uint> src, int shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsll(Vector256<long> src, int shift)
            => ShiftLeftLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_slli_epi64 (__m256i a, int imm8) VPSLLQ ymm, ymm, imm8
        /// Shifts each component of the source vector leftwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsll(Vector256<ulong> src, int shift)
            => ShiftLeftLogical(src, (byte)shift); 
    }
}