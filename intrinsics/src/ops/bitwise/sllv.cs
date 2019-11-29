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
    
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_sllv_epi32 (__m128i a, __m128i count) VPSLLVD xmm, ymm, xmm/m128
        /// Computes z[i] := x[i] << s[i] for i = 0..3
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsllv(Vector128<int> src, Vector128<uint> shift)
            => ShiftLeftLogicalVariable(src, shift);

        /// <summary>
        /// __m128i _mm_sllv_epi32 (__m128i a, __m128i count) VPSLLVD xmm, ymm, xmm/m128
        /// Computes z[i] := x[i] << s[i] for i = 0..3
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsllv(Vector128<uint> src, Vector128<uint> shift)
            => ShiftLeftLogicalVariable(src, shift);

        /// <summary>
        ///  __m128i _mm_sllv_epi64 (__m128i a, __m128i count) VPSLLVQ xmm, ymm, xmm/m128
        /// Computes z[i] := x[i] << s[i] for i = 0,1
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsllv(Vector128<long> src, Vector128<ulong> shift)
            => ShiftLeftLogicalVariable(src, shift);

        /// <summary>
        /// __m128i _mm_sllv_epi64 (__m128i a, __m128i count) VPSLLVQ xmm, ymm, xmm/m128
        /// Computes z[i] := x[i] << s[i] for i = 0,1
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsllv(Vector128<ulong> src, Vector128<ulong> shift)
            => ShiftLeftLogicalVariable(src, shift);           

        /// <summary>
        /// __m256i _mm256_sllv_epi32 (__m256i a, __m256i count) VPSLLVD ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] << s[i] for i = 0...7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsllv(Vector256<int> src, Vector256<uint> shift)
            => ShiftLeftLogicalVariable(src, shift);

        /// <summary>
        ///  __m256i _mm256_sllv_epi32 (__m256i a, __m256i count) VPSLLVD ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] << s[i] for i = 0...7
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsllv(Vector256<uint> src, Vector256<uint> shift)
            => ShiftLeftLogicalVariable(src, shift);

        /// <summary>
        ///  __m256i _mm256_sllv_epi64 (__m256i a, __m256i count) VPSLLVQ ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] << s[i] for i = 0...3
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsllv(Vector256<long> src, Vector256<ulong> shift)
            => ShiftLeftLogicalVariable(src, shift);

        /// <summary>
        /// __m256i _mm256_sllv_epi64 (__m256i a, __m256i count) VPSLLVQ ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] << s[i] for i = 0...3
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsllv(Vector256<ulong> src, Vector256<ulong> shift)
            => ShiftLeftLogicalVariable(src, shift);  

    }
}