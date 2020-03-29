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
    
    using static Core;    

    /// <summary>
    /// Direct floating-point scalar intrinsics
    /// </summary>
    [ApiHost(ApiHostKind.Direct)]
    public static class dinxsfp
    {
        /// <summary>
        ///  __m128 _mm_load_ss (float const* mem_address) MOVSS xmm, m32
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<float> load(float x)
            => LoadScalarVector128(constptr(x));

        /// <summary>
        ///  __m128d _mm_load_sd (double const* mem_address) MOVSD xmm, m64
        /// </summary>
        /// <param name="x">The source value</param>
        [MethodImpl(Inline), Op]
        public static unsafe Vector128<double> load(double x)
            => LoadScalarVector128(constptr(x));

        /// <summary>
        /// void _mm_store_ss (float* mem_addr, __m128 a) MOVSS m32, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe float store(Vector128<float> src)
        {
            var dst = default(float);
            StoreScalar(&dst,src);
            return dst;
        }

        /// <summary>
        /// void _mm_store_sd (double* mem_addr, __m128d a)MOVSD m64, xmm
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static unsafe double store(Vector128<double> src)
        {
            var dst = default(double);
            StoreScalar(&dst,src);
            return dst;
        }

        /// <summary>
        ///  __m128d _mm_cvtsi32_sd (__m128d a, int b)CVTSI2SD xmm, reg/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline), Op]
        public static ref Vector128<double> convert(int x, out Vector128<double> dst)
        {
            dst = ConvertScalarToVector128Double(default, x);
            return ref dst;
        }

        /// <summary>
        ///  __m128 _mm_cvtsi32_ss (__m128 a, int b)CVTSI2SS xmm, reg/m32
        /// </summary>
        /// <param name="src"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline), Op]
        public static ref Vector128<float> convert(int src, out Vector128<float> dst)
        {
            dst = ConvertScalarToVector128Single(default, src);
            return ref dst;
        }

        /// <summary>
        ///  __m128 _mm_cvtsi64_ss (__m128 a, __int64 b)CVTSI2SS xmm, reg/m64
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline), Op]
        public static ref Vector128<float> convert(long src, out Vector128<float> dst)
        {
            dst = ConvertScalarToVector128Single(default, src);
            return ref dst;
        }

        /// <summary>
        /// int _mm_cvtss_si32 (__m128 a) CVTSS2SI r32, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        [MethodImpl(Inline), Op]
        public static unsafe int to32i(float x)
            => ConvertToInt32(LoadScalarVector128(ptr(ref x)));

        /// <summary>
        /// int _mm_cvtsd_si32 (__m128d a) CVTSD2SI r32, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        [MethodImpl(Inline), Op]
        public static unsafe int to32i(double x)
            => ConvertToInt32(LoadScalarVector128(ptr(ref x)));

        /// <summary>
        /// __int64 _mm_cvtss_si64 (__m128 a) CVTSS2SI r64, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        [MethodImpl(Inline), Op]
        public static unsafe long to64i(float x)
            => ConvertToInt64(LoadScalarVector128(ptr(ref x)));

        /// <summary>
        /// __int64 _mm_cvtsd_si64 (__m128d a) CVTSD2SI r64, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        [MethodImpl(Inline), Op]
        public static unsafe long to64i(double x)
            => ConvertToInt64(LoadScalarVector128(ptr(ref x)));

        /// <summary>
        /// __m128 _mm_add_ss (__m128 a, __m128 b)ADDSS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> add(Vector128<float> x, Vector128<float> y)
            => AddScalar(x, y);

        /// <summary>
        /// __m128d _mm_add_sd (__m128d a, __m128d b)ADDSD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> add(Vector128<double> x, Vector128<double> y)
            => AddScalar(x, y);

        /// <summary>
        ///  __m128 _mm_mul_ss (__m128 a, __m128 b) MULPS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> mul(Vector128<float> x, Vector128<float> y)
            =>  MultiplyScalar(x, y);

        /// <summary>
        ///  __m128d _mm_mul_sd (__m128d a, __m128d b) MULSD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> mul(Vector128<double> x, Vector128<double> y)
            =>  MultiplyScalar(x, y);

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
            => CompareScalarNotGreaterThan(x, y).IsNaN(0);

        /// <summary>
        /// __m128d _mm_cmpngt_sd (__m128d a, __m128d b)CMPSD xmm, xmm/m64, imm8(2)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline), Op]
        public static bool ngt(Vector128<double> x, Vector128<double> y)
            => CompareScalarNotGreaterThan(x, y).IsNaN(0);

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