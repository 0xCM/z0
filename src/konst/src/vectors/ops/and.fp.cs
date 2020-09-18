//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// __m128 _mm_and_ps (__m128 a, __m128 b)ANDPS xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vand(Vector128<float> x, Vector128<float> y)
            => And(x, y);

        /// <summary>
        /// __m128d _mm_and_pd (__m128d a, __m128d b)ANDPD xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vand(Vector128<double> x, Vector128<double> y)
            => And(x, y);

        /// <summary>
        /// __m128 _mm_and_ps (__m128 a, __m128 b)ANDPS xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vand(Vector256<float> x, Vector256<float> y)
            => And(x, y);

        /// <summary>
        /// __m128d _mm_and_pd (__m128d a, __m128d b) ANDPD xmm, xmm/m128
        /// Computes the logical and of the operands
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vand(Vector256<double> x, Vector256<double> y)
            => And(x, y);
    }
}