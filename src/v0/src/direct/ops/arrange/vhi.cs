//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
        
    using static Konst;

    partial struct V0d
    {
        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vhi(Vector128<sbyte> src)
            => z.vhi(src);

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vhi(Vector128<byte> src)
            => z.vhi(src);

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vhi(Vector128<short> src)
            => z.vhi(src);

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vhi(Vector128<ushort> src)
            => z.vhi(src);

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vhi(Vector128<int> src)
            => z.vhi(src);

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vhi(Vector128<uint> src)
            => z.vhi(src);

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vhi(Vector128<long> src)
            => z.vhi(src);

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vhi(Vector128<ulong> src)
            => z.vhi(src);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vhi(Vector256<sbyte> src)
            => z.vhi(src);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vhi(Vector256<uint> src)
            => z.vhi(src);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vhi(Vector256<ulong> src)
            => z.vhi(src);
  
        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vhi(Vector256<byte> src)
            => z.vhi(src);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vhi(Vector256<short> src)
            => z.vhi(src);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vhi(Vector256<ushort> src)
            => z.vhi(src);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vhi(Vector256<int> src)
            => z.vhi(src);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vhi(Vector256<long> src)
            => z.vhi(src);
    }
}