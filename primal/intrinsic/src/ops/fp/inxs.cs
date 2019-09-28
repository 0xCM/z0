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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;    
    
    using static As;
    using static zfunc;    


    public static class inxs
    {

        /// <summary>
        ///  __m128 _mm_load_ss (float const* mem_address) MOVSS xmm, m32
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static unsafe Scalar128<float> scalar(in float src)
            => LoadScalarVector128(refptr(ref asRef(in src)));

        /// <summary>
        ///  __m128d _mm_load_sd (double const* mem_address) MOVSD xmm, m64
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static unsafe Scalar128<double> scalar(in double src)
            => LoadScalarVector128(refptr(ref asRef(in src)));

        [MethodImpl(Inline)]
        public static Vector128<float> add(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => AddScalar(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static Vector128<double> add(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => AddScalar(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static Scalar128<float> div(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => DivideScalar(lhs.data, rhs.data);
            
        [MethodImpl(Inline)]
        public static Scalar128<double> div(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => DivideScalar(lhs.data, rhs.data);

        /// <summary>
        ///  __m128 _mm_mul_ss (__m128 a, __m128 b) MULPS xmm, xmm/m32
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Scalar128<float> mul(in Scalar128<float> lhs, in Scalar128<float> rhs)
            =>  MultiplyScalar(lhs.data, rhs.data);

        /// <summary>
        ///  __m128d _mm_mul_sd (__m128d a, __m128d b) MULSD xmm, xmm/m64
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Scalar128<double> mul(in Scalar128<double> lhs, in Scalar128<double> rhs)
            =>  MultiplyScalar(lhs.data, rhs.data);


        /// <summary>
        /// __m128 _mm_sub_ss (__m128 a, __m128 b) SUBSS xmm, xmm/m32
        /// </summary>
        /// <param name="lhs">The left vectorized scalar</param>
        /// <param name="rhs">The right vectorized scalar</param>
        [MethodImpl(Inline)]
        public static Scalar128<float> sub(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => SubtractScalar(lhs.data, rhs.data);
            
        /// <summary>
        /// __m128d _mm_sub_sd (__m128d a, __m128d b) SUBSD xmm, xmm/m64
        /// </summary>
        /// <param name="lhs">The left vectorized scalar</param>
        /// <param name="rhs">The right vectorized scalar</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Scalar128<double> sub(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => SubtractScalar(lhs.data, rhs.data);


        /// <summary>
        /// __m128 _mm_max_ss (__m128 a, __m128 b) MAXSS xmm, xmm/m32
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Scalar128<float> max(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => MaxScalar(lhs.data, rhs.data);            

        /// <summary>
        /// __m128d _mm_max_sd (__m128d a, __m128d b) MAXSD xmm, xmm/m64
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns></returns>        
        [MethodImpl(Inline)]
        public static Scalar128<double> max(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => MaxScalar(lhs.data, rhs.data);

        /// <summary>
        ///  __m128 _mm_min_ss (__m128 a, __m128 b) MINSS xmm, xmm/m32
        /// </summary>
        /// <param name="lhs">The left vectorized scalar</param>
        /// <param name="rhs">The right vectorized scalar</param>
        [MethodImpl(Inline)]
        public static Scalar128<float> min(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => MinScalar(lhs.data, rhs.data);

        /// <summary>
        /// __m128d _mm_min_sd (__m128d a, __m128d b) MINSD xmm, xmm/m64
        /// </summary>
        /// <param name="lhs">The left vectorized scalar</param>
        /// <param name="rhs">The right vectorized scalar</param>
        [MethodImpl(Inline)]
        public static Scalar128<double> min(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => MinScalar(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static bool eq(in Scalar128<float> lhs,in Scalar128<float> rhs)
            => CompareScalarUnorderedEqual(lhs.data, rhs.data);
        
        [MethodImpl(Inline)]
        public static bool eq(in Scalar128<double> lhs,in Scalar128<double> rhs)
            => CompareScalarUnorderedEqual(lhs.data, rhs.data);

        /// <summary>
        /// __m128 _mm_cmp_ss (__m128 a, __m128 b, const int imm8) VCMPSD xmm, xmm, xmm/m64, imm8
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Scalar128<float> cmp(in Scalar128<float> lhs, in Scalar128<float> rhs, FpCmpMode mode)
            => CompareScalar(lhs.data,rhs.data, fpmode(mode));
   
        /// <summary>
        /// __m128d _mm_cmp_sd (__m128d a, __m128d b, const int imm8) VCMPSS xmm, xmm, xmm/m32, imm8
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="mode"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Scalar128<double> cmp(in Scalar128<double> lhs, in Scalar128<double> rhs, FpCmpMode mode)
            => CompareScalar(lhs.data,rhs.data, fpmode(mode));
    
        [MethodImpl(Inline)]
        public static bool gt(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => CompareScalarOrderedGreaterThan(lhs.data, rhs.data);
        
        [MethodImpl(Inline)]
        public static bool gt(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => CompareScalarOrderedGreaterThan(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static bool lteq(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => CompareScalarUnorderedLessThanOrEqual(lhs.data,rhs.data);
        
        [MethodImpl(Inline)]
        public static bool lteq(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => CompareScalarUnorderedLessThanOrEqual(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static bool lt(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => CompareScalarOrderedLessThan(lhs.data, rhs.data);                

        [MethodImpl(Inline)]
        public static bool lt(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => CompareScalarOrderedLessThan(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static bool cmpneq(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => CompareScalarOrderedNotEqual(lhs.data, rhs.data);
        
        [MethodImpl(Inline)]
        public static bool cmpneq(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => CompareScalarOrderedNotEqual(lhs.data, rhs.data);

        [MethodImpl(Inline)]
        public static bool ngt(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => CompareScalarNotGreaterThan(lhs.data, rhs.data).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool ngt(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => CompareScalarNotGreaterThan(lhs.data, rhs.data).IsNaN(0);

        [MethodImpl(Inline)]
        public static bool nlt(in Scalar128<float> lhs, in Scalar128<float> rhs)
            => CompareScalarNotLessThan(lhs, rhs).IsNaN(0);
        
        [MethodImpl(Inline)]
        public static bool nlt(in Scalar128<double> lhs, in Scalar128<double> rhs)
            => CompareScalarNotLessThan(lhs.data, rhs.data).IsNaN(0);

        [MethodImpl(Inline)]
        public static Scalar128<float> ceil(in Scalar128<float> src)
            => CeilingScalar(src.data);
        
        [MethodImpl(Inline)]
        public static Scalar128<double> ceil(in Scalar128<double> src)
            => CeilingScalar(src.data);

        [MethodImpl(Inline)]
        public static Scalar128<float> floor(in Scalar128<float> src)
            => CeilingScalar(src.data);
        
        [MethodImpl(Inline)]
        public static Scalar128<double> floor(in Scalar128<double> src)
            => CeilingScalar(src.data);

        /// <summary>
        /// __m128 _mm_rcp_ss (__m128 a) RCPSS xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>

        [MethodImpl(Inline)]
        public static Scalar128<float> rcp(in Scalar128<float> src)
            => ReciprocalScalar(src.data);

        /// <summary>
        /// __m128 _mm_sqrt_ss (__m128 a) SQRTSS xmm, xmm/m32
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static Scalar128<float> sqrt(in Scalar128<float> src)
            => SqrtScalar(src.data);

        /// <summary>
        /// _m128d _mm_sqrt_sd (__m128d a) SQRTSD xmm, xmm/64 
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static Scalar128<double> sqrt(in Scalar128<double> src)
            => SqrtScalar(src.data);

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        static bool IsNaN(this Vector128<float> src, int index)
                => src.GetElement(index).IsNaN();

        /// <summary>
        /// Determines whether the first component is NaN
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        static bool IsNaN(this Vector128<double> src, int index)
            => src.GetElement(index).IsNaN();   

        [MethodImpl(Inline)]
        static FloatComparisonMode fpmode(FpCmpMode m)
            => (FloatComparisonMode)m;
    }
}