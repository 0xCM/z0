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
    
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> vhi(in Vec256<sbyte> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vhi(in Vec256<byte> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<short> vhi(in Vec256<short> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vhi(in Vec256<ushort> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vhi(in Vec256<int> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vhi(in Vec256<uint> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vhi(in Vec256<long> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vhi(in Vec256<ulong> src)
            => ExtractVector128(src, 1);
    }
}