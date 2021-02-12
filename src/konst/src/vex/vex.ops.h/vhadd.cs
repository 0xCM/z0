//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Ssse3;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static Part;

    partial struct cpu
    {
        /// <summary>
        /// Computes the horizontal sum of the source vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector128<sbyte> vhadd(Vector128<sbyte> x, Vector128<sbyte> y)
        {
            var a = vinflate256x16i(x, w256);
            var b = vinflate256x16i(y, w256);
            return vpack128x8i(vhadd(a,b));
        }

        /// <summary>
        /// Computes the horizontal sum of the source vectors
        /// </summary>
        /// <param name="a">The left vector</param>
        /// <param name="b">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector128<byte> vhadd(Vector128<byte> a, Vector128<byte> b)
        {
            var c = vinflate256x16i(a);
            var d = vinflate256x16i(b);
            return vpack128x8u(vhadd(c,d));
        }

        /// <summary>
        /// __m128i _mm_hadd_epi16 (__m128i a, __m128i b) PHADDW xmm, xmm/m128
        /// </summary>
        /// <param name="a">The left vector</param>
        /// <param name="b">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector128<short> vhadd(Vector128<short> a, Vector128<short> b)
            => HorizontalAdd(a, b);

        /// <summary>
        /// __m128i _mm_hadd_epi32 (__m128i a, __m128i b) PHADDD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector128<int> vhadd(Vector128<int> x, Vector128<int> y)
            => HorizontalAdd(x, y);

        /// <summary>
        /// Computes the horizontal sum of the source vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector256<sbyte> vhadd(Vector256<sbyte> x, Vector256<sbyte> y)
        {
            (var x0, var x1) = vinflate512x16i(x);
            (var y0, var y1) = vinflate512x16i(x);
            return vpack256x8i(vhadd(x0,y0), vhadd(x1,y1));
        }

        /// <summary>
        /// __m256i _mm256_hadd_epi16 (__m256i a, __m256i b) VPHADDW ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector256<short> vhadd(Vector256<short> x, Vector256<short> y)
            => HorizontalAdd(x, y);

        /// <summary>
        /// m256i _mm256_hadd_epi32 (__m256i a, __m256i b) VPHADDD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), AddH]
        public static Vector256<int> vhadd(Vector256<int> x, Vector256<int> y)
            => HorizontalAdd(x, y);

        /// <summary>
        /// __m128 _mm_hadd_ps (__m128 a, __m128 b) HADDPS xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vhadd(Vector128<float> x, Vector128<float> y)
            => HorizontalAdd(x, y);

        /// <summary>
        ///  __m128d _mm_hadd_pd (__m128d a, __m128d b) HADDPD xmm, xmm/m128
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vhadd(Vector128<double> x, Vector128<double> y)
            => HorizontalAdd(x, y);

        /// <summary>
        /// __m256 _mm256_hadd_ps (__m256 a, __m256 b) VHADDPS ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vhadd(Vector256<float> x, Vector256<float> y)
            => HorizontalAdd(x, y);

        /// <summary>
        /// __m256d _mm256_hadd_pd (__m256d a, __m256d b) VHADDPD ymm, ymm, ymm/m256
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vhadd(Vector256<double> x, Vector256<double> y)
            => HorizontalAdd(x, y);
   }
}