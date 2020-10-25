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
    partial struct z
    {
        [MethodImpl(Inline)]
        public static unsafe Vector128<float> vloads(float x)
            => VexSFp.vloads(x);

        [MethodImpl(Inline)]
        public static unsafe Vector128<double> vloads(double x)
            => VexSFp.vloads(x);

        [MethodImpl(Inline)]
        public static unsafe float vstores(Vector128<float> src)
            => VexSFp.vstores(src);

        [MethodImpl(Inline)]
        public static unsafe double vstores(Vector128<double> src)
            => VexSFp.vstores(src);

        [MethodImpl(Inline)]
        public static ref Vector128<double> convert(int src, out Vector128<double> dst)
            => ref VexSFp.convert(src, out dst);

        [MethodImpl(Inline)]
        public static ref Vector128<float> convert(int src, out Vector128<float> dst)
            => ref VexSFp.convert(src, out dst);

        [MethodImpl(Inline)]
        public static ref Vector128<float> convert(long src, out Vector128<float> dst)
            => ref VexSFp.convert(src, out dst);

        [MethodImpl(Inline)]
        public static unsafe int to32i(in float src)
            => VexSFp.to32i(src);

        [MethodImpl(Inline)]
        public static unsafe int to32i(in double src)
            => VexSFp.to32i(src);

        [MethodImpl(Inline)]
        public static unsafe long to64i(in float src)
            => VexSFp.to64i(src);

        [MethodImpl(Inline)]
        public static unsafe long to64i(in double src)
            => VexSFp.to64i(src);

        [MethodImpl(Inline)]
        public static Vector128<float> vadds(Vector128<float> x, Vector128<float> y)
            => VexSFp.vadds(x, y);

        [MethodImpl(Inline)]
        public static Vector128<double> vadds(Vector128<double> x, Vector128<double> y)
            => VexSFp.vadds(x, y);

        [MethodImpl(Inline)]
        public static Vector128<float> vmuls(Vector128<float> x, Vector128<float> y)
            => VexSFp.vmuls(x, y);

        [MethodImpl(Inline)]
        public static Vector128<double> vmuls(Vector128<double> x, Vector128<double> y)
            => VexSFp.vmuls(x, y);

        [MethodImpl(Inline)]
        public static Vector128<float> vfmadds(Vector128<float> x, Vector128<float> y, Vector128<float> z)
            => VexSFp.vfmadds(x, y, z);

        [MethodImpl(Inline)]
        public static Vector128<double> vfmadds(Vector128<double> x, Vector128<double> y, Vector128<double> z)
            => VexSFp.vfmadds(x, y, z);

        /// <summary>
        /// __m128 _mm_fmsub_ss (__m128 a, __m128 b, __m128 c) VFMSUBSS xmm, xmm, xmm/m32
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
        /// __m128 _mm_div_ss (__m128 a, __m128 b) DIVSS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> div(Vector128<float> x, Vector128<float> y)
            => DivideScalar(x, y);

        /// <summary>
        ///  __m128d _mm_div_sd (__m128d a, __m128d b) DIVSD xmm, xmm/m64
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
        /// int _mm_comige_ss (__m128 a, __m128 b)COMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool gteq(Vector128<float> x, Vector128<float> y)
            => CompareScalarOrderedGreaterThanOrEqual(x, y);

        /// <summary>
        /// int _mm_comige_sd (__m128d a, __m128d b)COMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool gteq(Vector128<double> x, Vector128<double> y)
            => CompareScalarOrderedGreaterThanOrEqual(x, y);

        /// <summary>
        /// __m128 _mm_cmpngt_ss (__m128 a, __m128 b)CMPSS xmm, xmm/m32, imm8(2)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool ngt(Vector128<float> x, Vector128<float> y)
            => IsNaN(CompareScalarNotGreaterThan(x, y),0);

        /// <summary>
        /// __m128d _mm_cmpngt_sd (__m128d a, __m128d b)CMPSD xmm, xmm/m64, imm8(2)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool ngt(Vector128<double> x, Vector128<double> y)
            => IsNaN(CompareScalarNotGreaterThan(x, y),0);

        /// <summary>
        /// int _mm_comilt_ss (__m128 a, __m128 b)COMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool lt(Vector128<float> x, Vector128<float> y)
            => CompareScalarOrderedLessThan(x, y);

        /// <summary>
        /// int _mm_comilt_sd (__m128d a, __m128d b)COMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool lt(Vector128<double> x, Vector128<double> y)
            => CompareScalarOrderedLessThan(x, y);

        /// <summary>
        ///  __m128 _mm_cmpnlt_ss (__m128 a, __m128 b) CMPSS xmm, xmm/m32, imm8(5)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool nlt(Vector128<float> x, Vector128<float> y)
            => IsNaN(CompareScalarNotLessThan(x, y),0);

        /// <summary>
        /// __m128d _mm_cmpnlt_sd (__m128d a, __m128d b) CMPSD xmm, xmm/m64, imm8(5)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool nlt(Vector128<double> x, Vector128<double> y)
            => IsNaN(CompareScalarNotLessThan(x, y),0);

        /// <summary>
        ///  int _mm_ucomile_ss (__m128 a, __m128 b) UCOMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool lteq(Vector128<float> x, Vector128<float> y)
            => CompareScalarUnorderedLessThanOrEqual(x,y);

        /// <summary>
        /// int _mm_ucomile_sd (__m128d a, __m128d b)UCOMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool lteq(Vector128<double> x, Vector128<double> y)
            => CompareScalarUnorderedLessThanOrEqual(x, y);

        /// <summary>
        /// __m128 _mm_cmp_ss (__m128 a, __m128 b, const int imm8) VCMPSD xmm, xmm, xmm/m64, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="mode"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> cmp(Vector128<float> x, Vector128<float> y, FpCmpMode mode)
            => CompareScalar(x,y, fpmode(mode));

        /// <summary>
        /// __m128d _mm_cmp_sd (__m128d a, __m128d b, const int imm8) VCMPSS xmm, xmm, xmm/m32, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="mode"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> cmp(Vector128<double> x, Vector128<double> y, FpCmpMode mode)
            => CompareScalar(x,y, fpmode(mode));

        /// <summary>
        /// __m128 _mm_ceil_ss (__m128 a)ROUNDSD xmm, xmm/m128, imm8(10)
        /// </summary>
        /// <param name="x"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> ceil(Vector128<float> x)
            => CeilingScalar(x);

        /// <summary>
        /// __m128d _mm_ceil_sd (__m128d a)ROUNDSD xmm, xmm/m128, imm8(10)
        /// </summary>
        /// <param name="x"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> ceil(Vector128<double> x)
            => CeilingScalar(x);

        /// <summary>
        ///  __m128 _mm_ceil_ss (__m128 a)ROUNDSD xmm, xmm/m128, imm8(10)
        /// </summary>
        /// <param name="x"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> floor(Vector128<float> x)
            => CeilingScalar(x);

        /// <summary>
        /// __m128d _mm_ceil_sd (__m128d a)ROUNDSD xmm, xmm/m128, imm8(10)
        /// </summary>
        /// <param name="x"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> floor(Vector128<double> x)
            => CeilingScalar(x);

        /// <summary>
        /// __m128 _mm_rcp_ss (__m128 a) RCPSS xmm, xmm/m32
        /// </summary>
        /// <param name="x">The source vector</param>

        [MethodImpl(Inline), Op]
        public static Vector128<float> rcp(Vector128<float> x)
            => ReciprocalScalar(x);

        /// <summary>
        /// __m128 _mm_sqrt_ss (__m128 a) SQRTSS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> sqrt(Vector128<float> x)
            => SqrtScalar(x);

        /// <summary>
        /// _m128d _mm_sqrt_sd (__m128d a) SQRTSD xmm, xmm/64
        /// </summary>
        /// <param name="x"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> sqrt(Vector128<double> x)
            => SqrtScalar(x);

        /// <summary>
        /// __m128 _mm_rsqrt_ss (__m128 a) RSQRTSS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        [MethodImpl(Inline), Op]
        public static ref Vector128<float> rsqrt(ref Vector128<float> x)
        {
            x = ReciprocalSqrtScalar(x);
            return ref x;
        }

        /// <summary>
        /// Returns true if a value is the NaN representative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool IsNaN(float src)
            => float.IsNaN(src);

        /// <summary>
        /// Returns true if a value is the NaN representative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static bool IsNaN(double src)
            => double.IsNaN(src);

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        static bool IsNaN(Vector128<float> x, byte index)
            => IsNaN(x.GetElement(index));

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        static bool IsNaN(Vector128<double> x, byte index)
            => IsNaN(x.GetElement(index));

        [MethodImpl(Inline), Op]
        static FloatComparisonMode fpmode(FpCmpMode m)
            => (FloatComparisonMode)m;
    }
}