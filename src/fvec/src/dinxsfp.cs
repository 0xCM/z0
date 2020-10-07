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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse2.X64;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Fma;
    using static System.Runtime.Intrinsics.X86.Sse.X64;

    using static Konst;
    using static z;

    /// <summary>
    /// Direct floating-point scalar intrinsics
    /// </summary>
    [ApiHost]
    public static class dinxsfp
    {

        /// <summary>
        /// __m128 _mm_fmadd_ss (__m128 a, __m128 b, __m128 c) VFMADDSS xmm, xmm, xmm/m32
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> fmadd(Vector128<float> x, Vector128<float> y, Vector128<float> z)
            => MultiplyAddScalar(x, y, z);

        /// <summary>
        /// __m128d _mm_fmadd_sd (__m128d a, __m128d b, __m128d c) VFMADDSS xmm, xmm, xmm/m64
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> fmadd(Vector128<double> x, Vector128<double> y, Vector128<double> z)
            => MultiplyAddScalar(x, y, z);

        /// <summary>
        /// __m128 _mm_fmsub_ss (__m128 a, __m128 b, __m128 c)VFMSUBSS xmm, xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> fmsub(Vector128<float> x, Vector128<float> y, Vector128<float> z)
            => MultiplySubtractScalar(x,y,z);

        /// <summary>
        /// __m128d _mm_fmsub_sd (__m128d a, __m128d b, __m128d c)VFMSUBSD xmm, xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> fmsub(Vector128<double> x, Vector128<double> y, Vector128<double> z)
            => MultiplySubtractScalar(x,y,z);

        /// <summary>
        /// __m128 _mm_fnmadd_ss (__m128 a, __m128 b, __m128 c) VFNMADDSS xmm, xmm, xmm/m32
        /// dst = -(x*y + z)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> fnmadd(Vector128<float> x, Vector128<float> y, Vector128<float> z)
            => MultiplyAddNegatedScalar(x,y,z);

        /// <summary>
        /// __m128d _mm_fnmadd_sd (__m128d a, __m128d b, __m128d c) VFNMADDSD xmm, xmm, xmm/m64
        /// dst = -(x*y + z)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> fnmadd(Vector128<double> x, Vector128<double> y, Vector128<double> z)
            => MultiplyAddNegatedScalar(x,y,z);

        /// <summary>
        /// __m128 _mm_div_ss (__m128 a, __m128 b)DIVSS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [MethodImpl(Inline), Op]
        public static Vector128<float> div(Vector128<float> x, Vector128<float> y)
            => DivideScalar(x, y);

        /// <summary>
        ///  __m128d _mm_div_sd (__m128d a, __m128d b)DIVSD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> div(Vector128<double> x, Vector128<double> y)
            => DivideScalar(x, y);

        /// <summary>
        /// __m128 _mm_sub_ss (__m128 a, __m128 b) SUBSS xmm, xmm/m32
        /// </summary>
        /// <param name="x">The left vectorized scalar</param>
        /// <param name="y">The right vectorized scalar</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> sub(Vector128<float> x, Vector128<float> y)
            => SubtractScalar(x, y);

        /// <summary>
        /// __m128d _mm_sub_sd (__m128d a, __m128d b) SUBSD xmm, xmm/m64
        /// </summary>
        /// <param name="x">The left vectorized scalar</param>
        /// <param name="y">The right vectorized scalar</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> sub(Vector128<double> x, Vector128<double> y)
            => SubtractScalar(x, y);

        /// <summary>
        /// __m128 _mm_max_ss (__m128 a, __m128 b) MAXSS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> max(Vector128<float> x, Vector128<float> y)
            => MaxScalar(x, y);

        /// <summary>
        /// __m128d _mm_max_sd (__m128d a, __m128d b) MAXSD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> max(Vector128<double> x, Vector128<double> y)
            => MaxScalar(x, y);

        /// <summary>
        ///  __m128 _mm_min_ss (__m128 a, __m128 b) MINSS xmm, xmm/m32
        /// </summary>
        /// <param name="x">The left vectorized scalar</param>
        /// <param name="y">The right vectorized scalar</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> min(Vector128<float> x, Vector128<float> y)
            => MinScalar(x, y);

        /// <summary>
        /// __m128d _mm_min_sd (__m128d a, __m128d b) MINSD xmm, xmm/m64
        /// </summary>
        /// <param name="x">The left vectorized scalar</param>
        /// <param name="y">The right vectorized scalar</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> min(Vector128<double> x, Vector128<double> y)
            => MinScalar(x, y);

        /// <summary>
        ///  int _mm_ucomieq_ss (__m128 a, __m128 b)UCOMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool eq(Vector128<float> x,Vector128<float> y)
            => CompareScalarUnorderedEqual(x, y);

        /// <summary>
        /// int _mm_ucomieq_sd (__m128d a, __m128d b)UCOMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool eq(Vector128<double> x,Vector128<double> y)
            => CompareScalarUnorderedEqual(x, y);

        /// <summary>
        /// int _mm_comineq_ss (__m128 a, __m128 b)COMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool neq(Vector128<float> x, Vector128<float> y)
            => CompareScalarOrderedNotEqual(x, y);

        /// <summary>
        ///  int _mm_comineq_sd (__m128d a, __m128d b)COMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool neq(Vector128<double> x, Vector128<double> y)
            => CompareScalarOrderedNotEqual(x, y);

        /// <summary>
        /// int _mm_comigt_ss (__m128 a, __m128 b)COMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool gt(Vector128<float> x, Vector128<float> y)
            => CompareScalarOrderedGreaterThan(x, y);

        /// <summary>
        /// int _mm_comigt_sd (__m128d a, __m128d b)COMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool gt(Vector128<double> x, Vector128<double> y)
            => CompareScalarOrderedGreaterThan(x, y);


        /// <summary>
        /// int _mm_comilt_sd (__m128d a, __m128d b) COMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool lt(Vector128<double> x, Vector128<double> y)
            => CompareScalarOrderedLessThan(x, y);

        /// <summary>
        ///  __m128 _mm_cmpnlt_ss (__m128 a, __m128 b)CMPSS xmm, xmm/m32, imm8(5)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool nlt(Vector128<float> x, Vector128<float> y)
            => CompareScalarNotLessThan(x, y).IsNaN(0);

        /// <summary>
        /// __m128d _mm_cmpnlt_sd (__m128d a, __m128d b)CMPSD xmm, xmm/m64, imm8(5)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool nlt(Vector128<double> x, Vector128<double> y)
            => CompareScalarNotLessThan(x, y).IsNaN(0);

        /// <summary>
        ///  int _mm_ucomile_ss (__m128 a, __m128 b)UCOMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool lteq(Vector128<float> x, Vector128<float> y)
            => CompareScalarUnorderedLessThanOrEqual(x,y);

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        static bool IsNaN(this Vector128<float> x, int index)
            => x.GetElement(index).IsNaN();

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        static bool IsNaN(this Vector128<double> x, int index)
            => x.GetElement(index).IsNaN();

        [MethodImpl(Inline), Op]
        static FloatComparisonMode fpmode(FpCmpMode m)
            => (FloatComparisonMode)m;
    }
}