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
    using static As;

    partial class dinx
    {         
        /// <summary>
        ///  __m128i _mm_srlv_epi32 (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        /// Computes z[i] := x[i] >> s[i] for i = 0...3
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="s">The control vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsrlv(Vector128<int> x, Vector128<uint> s)
            => ShiftRightLogicalVariable(x, s);

        /// <summary>
        /// __m128i _mm_srlv_epi32 (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        /// Computes z[i] := x[i] >> s[i] for i = 0...3
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="s">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsrlv(Vector128<uint> x, Vector128<uint> s)
            => ShiftRightLogicalVariable(x, s);

        /// <summary>
        /// __m128i _mm_srlv_epi64 (__m128i a, __m128i count) VPSRLVQ xmm, xmm, xmm/m128
        /// Computes z[i] := x[i] >> s[i] for i = 0,1
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="s">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsrlv(Vector128<long> x, Vector128<ulong> s)
            => ShiftRightLogicalVariable(x, s);

        /// <summary>
        /// __m128i _mm_srlv_epi64 (__m128i a, __m128i count) VPSRLVQ xmm, xmm, xmm/m128
        /// Computes z[i] := x[i] >> s[i] for i = 0,1
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="s">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsrlv(Vector128<ulong> x, Vector128<ulong> s)
            => ShiftRightLogicalVariable(x, s);       
 
        /// <summary>
        /// __m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] >> s[i] for i = 0...7
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="s">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsrlv(Vector256<int> x, Vector256<uint> s)
            => ShiftRightLogicalVariable(x, s);

        /// <summary>
        /// __m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] >> s[i] for i = 0...7
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="s">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsrlv(Vector256<uint> x, Vector256<uint> s)
            => ShiftRightLogicalVariable(x, s);

        /// <summary>
        /// __m256i _mm256_srlv_epi64 (__m256i a, __m256i count) VPSRLVQ ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] >> s[i] for i = 0...3
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="s">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsrlv(Vector256<long> x, Vector256<ulong> s)
            => ShiftRightLogicalVariable(x, s);

        /// <summary>
        ///  __m256i _mm256_srlv_epi64 (__m256i a, __m256i count) VPSRLVQ ymm, ymm, ymm/m256
        /// Computes z[i] := x[i] >> s[i] for i = 0...3
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="s">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsrlv(Vector256<ulong> x, Vector256<ulong> s)
            => ShiftRightLogicalVariable(x, s); 
    
    }
}