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
 
   using static System.Runtime.Intrinsics.X86.Avx;
   using static System.Runtime.Intrinsics.X86.Avx2;

   using static Konst;

    partial struct z
    {                            
        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vhi(Vector256<sbyte> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vhi(Vector256<uint> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vhi(Vector256<ulong> src)
            => ExtractVector128(src, 1);
  
        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vhi(Vector256<byte> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vhi(Vector256<short> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vhi(Vector256<ushort> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vhi(Vector256<int> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// __m128i _mm256_extracti128_si256 (__m256i a, const int imm8) VEXTRACTI128 xmm,  ymm, imm8
        /// Extracts the hi 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vhi(Vector256<long> src)
            => ExtractVector128(src, 1);

        [MethodImpl(Inline), Op]
        public static Vector128<float> vhi(Vector256<float> src)
            => ExtractVector128(src, 1);

        [MethodImpl(Inline), Op]
        public static Vector128<double> vhi(Vector256<double> src)
            => ExtractVector128(src, 1);

        /// <summary>
        /// Extracts the upper 128-bit lane from the source vector to scalar targets
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">Receiver for the lo part of the exracted lane</param>
        /// <param name="x1">Receiver for the hi part of the exracted lane</param>
        [MethodImpl(Inline), Op]
        public static void vhi(Vector256<ulong> src, out ulong x0, out ulong x1)
        {
            var x = z.vhi(src);
            x0 = x.GetElement(0);
            x1 = x.GetElement(1);
        }

        /// <summary>
        /// Extracts the upper 128-bit lane from the source vector to scalar targets
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">Receiver for the lo part of the exracted lane</param>
        /// <param name="x1">Receiver for the hi part of the exracted lane</param>
        [MethodImpl(Inline), Op]
        public static void vhi(Vector256<byte> src, out ulong x0, out ulong x1)
        {
            var x = z.vhi(src);
            x0 = x.GetElement(0);
            x1 = x.GetElement(1);
        }

        /// <summary>
        /// Extracts the upper 128-bit lane from the source vector to a pair
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="x0">Receiver for the lo part of the exracted lane</param>
        /// <param name="x1">Receiver for the hi part of the exracted lane</param>
        [MethodImpl(Inline)]
        public static ref Pair<ulong> vhi(Vector256<ulong> src, ref Pair<ulong> dst)
        {
            var x = z.vhi(src);
            dst.Left = x.GetElement(0);
            dst.Right = x.GetElement(1);
            return ref dst;
        }
    }
}