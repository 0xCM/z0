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

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static zfunc;
    using static As;

    partial class dinx
    {         
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsrl(Vector256<sbyte> src, Vector128<sbyte> shift)
            => vsrl(src, (byte)shift.Item(0));

        [MethodImpl(Inline)]
        public static Vector256<byte> vsrl(Vector256<byte> src, Vector128<byte> shift)
            => vsrl(src, shift.Item(0));

        /// <summary>
        /// __m256i _mm256_srl_epi16 (__m256i a, __m128i count) VPSRLW ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<short> vsrl(Vector256<short> src, Vector128<short> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srl_epi16 (__m256i a, __m128i count) VPSRLW ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsrl(Vector256<ushort> src, Vector128<ushort> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srl_epi32 (__m256i a, __m128i count) VPSRLD ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<int> vsrl(Vector256<int> src, Vector128<int> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srl_epi32 (__m256i a, __m128i count)VPSRLD ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsrl(Vector256<uint> src, Vector128<uint> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srl_epi64 (__m256i a, __m128i count) VPSRLQ ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<long> vsrl(Vector256<long> src, Vector128<long> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// __m256i _mm256_srl_epi64 (__m256i a, __m128i count) VPSRLQ ymm, ymm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="shift"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsrl(Vector256<ulong> src, Vector128<ulong> shift)
            => ShiftRightLogical(src, shift);

        /// <summary>
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vsrl(Vector128<byte> src, int shift)
        {
            var x = vconvert(src, out Vector256<ushort> _);
            var mask =  ginx.vpclearalt<byte>(n256);
            var a = vshuf16x8(v8u(dinx.vsrl(x, shift)), mask);
            var perm = ginx.vplanemerge<byte>();
            return vlo(vshuf32x8(a, perm));
        }

        /// <summary>
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vsrl(Vector128<sbyte> src, int shift)
            => vsrl(src.AsByte(), shift).AsSByte();

        /// <summary>
        /// __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vsrl(Vector128<short> src, int shift)
            => ShiftRightLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_srli_epi16 (__m128i a, int immediate) PSRLW xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vsrl(Vector128<ushort> src, int shift)
            => ShiftRightLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsrl(Vector128<int> src, int shift)
            => ShiftRightLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_srli_epi32 (__m128i a, int immediate) PSRLD xmm, imm8
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsrl(Vector128<uint> src, int shift)
            => ShiftRightLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsrl(Vector128<long> src, int shift)
            => ShiftRightLogical(src, (byte)shift);

        /// <summary>
        /// __m128i _mm_srli_epi64 (__m128i a, int immediate) PSRLQ xmm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsrl(Vector128<ulong> src, int shift)
            => ShiftRightLogical(src, (byte)shift);

        /// <summary>
        /// Shifts each componet in the source vector leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vsrl(Vector256<sbyte> src, int shift)
            => vsrl(src.AsByte(), shift).AsSByte();

        /// <summary>
        /// Shifts each component of the source vector rightwards by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vsrl(Vector256<byte> src, int shift)
        {
            //Fan the hi/lo parts of the u8 source vector across 2 u16 vectors
            var x = vconvert(vlo(src), out Vector256<ushort> _);
            var y = vconvert(vhi(src), out Vector256<ushort> _);
            
            // Shift each part with a concrete intrinsic anc convert back to bytes and truncate overflows 
            // to set up the component pattern [X 0 X 0 ... X 0] in each vector
            var mask = ginx.vpclearalt<byte>(n256);
            var a = vshuf16x8(v8u(dinx.vsrl(x, shift)), mask);
            var b = vshuf16x8(v8u(dinx.vsrl(y, shift)), mask);
                        
            // Each vector contains 16 values that need to be merged
            // back into a single vector. The strategey is to condense
            // each vector via the "lane merge" pattern and construct
            // the result vector via insertion of these condensed vectors
            var perm = ginx.vplanemerge<byte>();
            return vconcat(
                vlo(vshuf32x8(a, perm)), 
                vlo(vshuf32x8(b, perm)));            
        } 

        /// <summary>
        /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vsrl(Vector256<short> src, int shift)
            => ShiftRightLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_srli_epi16 (__m256i a, int imm8) VPSRLW ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vsrl(Vector256<ushort> src, int shift)
            => ShiftRightLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsrl(Vector256<int> src, int shift)
            => ShiftRightLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_srli_epi32 (__m256i a, int imm8) VPSRLD ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsrl(Vector256<uint> src, int shift)
            => ShiftRightLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsrl(Vector256<long> src, int shift)
            => ShiftRightLogical(src, (byte)shift);

        /// <summary>
        /// __m256i _mm256_srli_epi64 (__m256i a, int imm8) VPSRLQ ymm, ymm, imm8
        /// Shifts each component of the source vector right by a common number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsrl(Vector256<ulong> src, int shift)
            => ShiftRightLogical(src, (byte)shift); 
    }

}