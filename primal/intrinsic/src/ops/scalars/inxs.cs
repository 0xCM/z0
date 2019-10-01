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
    using static System.Runtime.Intrinsics.X86.Fma;        
    using static System.Runtime.Intrinsics.X86.Sse.X64;
    
    using static As;
    using static zfunc;    

    public static class inxs
    {
        [MethodImpl(Inline)]
        public static float add(in float x, in float y)        
            => add(load(in x), load(in y));
        
        [MethodImpl(Inline)]
        public static double add(in double x, in double y)        
            => add(load(in x), load(in y));

        [MethodImpl(Inline)]
        public static float sub(float x, float y)        
            => sub(load(x), load(y));
        
        [MethodImpl(Inline)]
        public static double sub(double x, double y)        
            => sub(load(x), load(y));

        [MethodImpl(Inline)]
        public static float mul(float x, float y)        
            => mul(load(x), load(y));
        
        [MethodImpl(Inline)]
        public static double mul(double x, double y)        
            => mul(load(x), load(y));

        [MethodImpl(Inline)]
        public static float div(float x, float y)        
            => div(load(x), load(y));
        
        [MethodImpl(Inline)]
        public static double div(double x, double y)        
            => div(load(x), load(y));

        [MethodImpl(Inline)]
        public static float max(float x, float y)        
            => max(load(x), load(y));
        
        [MethodImpl(Inline)]
        public static double max(double x, double y)        
            => max(load(x), load(y));

        [MethodImpl(Inline)]
        public static float min(float x, float y)        
            => min(load(x), load(y));
        
        [MethodImpl(Inline)]
        public static double min(double x, double y)        
            => min(load(x), load(y));

        [MethodImpl(Inline)]
        public static float ceil(float x)        
            => ceil(load(x));
        
        [MethodImpl(Inline)]
        public static double ceil(double x)        
            => ceil(load(x));

        [MethodImpl(Inline)]
        public static float floor(float x)        
            => floor(load(x));
        
        [MethodImpl(Inline)]
        public static double floor(double x)        
            => floor(load(x));

        [MethodImpl(Inline)]
        public static float sqrt(float x)        
            => sqrt(load(x));
        
        [MethodImpl(Inline)]
        public static double sqrt(double x)        
            => sqrt(load(x));

        [MethodImpl(Inline)]
        public static bool eq(float x, float y)        
            => eq(load(x), load(y));
        
        [MethodImpl(Inline)]
        public static bool eq(double x, double y)        
            => eq(load(x), load(y));

        [MethodImpl(Inline)]
        public static bool neq(float x, float y)        
            => neq(load(x), load(y));
        
        [MethodImpl(Inline)]
        public static bool neq(double x, double y)        
            => neq(load(x), load(y));

        [MethodImpl(Inline)]
        public static bool lt(float x, float y)        
            => lt(load(x), load(y));
        
        [MethodImpl(Inline)]
        public static bool lt(double x, double y)        
            => lt(load(x), load(y));

        [MethodImpl(Inline)]
        public static bool lteq(float x, float y)        
            => lteq(load(x), load(y));
        
        [MethodImpl(Inline)]
        public static bool lteq(double x, double y)        
            => lteq(load(x), load(y));

        [MethodImpl(Inline)]
        public static bool gt(float x, float y)        
            => gt(load(x), load(y));
        
        [MethodImpl(Inline)]
        public static bool gt(double x, double y)        
            => gt(load(x), load(y));

        [MethodImpl(Inline)]
        public static bool gteq(float x, float y)        
            => gteq(load(x), load(y));
        
        [MethodImpl(Inline)]
        public static bool gteq(double x, double y)        
            => gteq(load(x), load(y));

        [MethodImpl(Inline)]
        public static float fmadd(float x, float y, float z)        
            => fmadd(load(x), load(y), load(z));
        
        [MethodImpl(Inline)]
        public static double fmadd(double x, double y, double z)        
            => fmadd(load(x), load(y), load(z));

        [MethodImpl(Inline)]
        public static float fmsub(float x, float y, float z)        
            => fmsub(load(x), load(y), load(z));
        
        [MethodImpl(Inline)]
        public static double fmsub(double x, double y, double z)        
            => fmsub(load(x), load(y), load(z));

        /// <summary>
        ///  __m128i _mm_cvtsi32_si128 (int a)MOVD xmm, reg/m32
        /// Copies a 32-bit source value to the least vector component, and zero-out the remaining vector components
        /// </summary>
        /// <param name="src">THe source value</param>
        [MethodImpl(Inline)]
        public static Scalar128<int> load(int src)
            => ConvertScalarToVector128Int32(src);
            
        /// <summary>
        /// __m128i _mm_cvtsi32_si128 (int a)MOVD xmm, reg/m32
        /// Copies a 32-bit source value to the least vector component, and zero-out the remaining vector components
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static Scalar128<uint> load(uint src)
            => ConvertScalarToVector128UInt32(src);

        /// <summary>
        ///  __m128 _mm_load_ss (float const* mem_address) MOVSS xmm, m32
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static unsafe Scalar128<float> load(in float src)
            => LoadScalarVector128(constptr(in src));

        /// <summary>
        ///  __m128d _mm_load_sd (double const* mem_address) MOVSD xmm, m64
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static unsafe Scalar128<double> load(in double src)
            => LoadScalarVector128(constptr(in src));

        /// <summary>
        ///  __m128d _mm_cvtsi32_sd (__m128d a, int b)CVTSI2SD xmm, reg/m32
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static ref Scalar128<double> load(int src, out Scalar128<double> dst)
        {
            dst = ConvertScalarToVector128Double(default, src);
            return ref dst;
        }

        /// <summary>
        ///  __m128 _mm_cvtsi32_ss (__m128 a, int b)CVTSI2SS xmm, reg/m32
        /// </summary>
        /// <param name="src"></param>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static ref Scalar128<float> load(int src, out Scalar128<float> dst)
        {
            dst = ConvertScalarToVector128Single(default, src);
            return ref dst;
        }

        /// <summary>
        ///  __m128 _mm_cvtsi64_ss (__m128 a, __int64 b)CVTSI2SS xmm, reg/m64
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static ref Scalar128<float> load(long src, out Scalar128<float> dst)
        {
            dst = ConvertScalarToVector128Single(default, src);
            return ref dst;
        }

        /// <summary>
        /// __int64 _mm_cvttss_si64 (__m128 a)CVTTSS2SI r64, xmm/m32
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static long convert(in Scalar128<float> src, out long dst)
        {
            dst = ConvertToInt64WithTruncation(src.mm);
            return dst;
        }

        /// <summary>
        /// int _mm_cvttss_si32 (__m128 a)CVTTSS2SI r32, xmm/m32
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static long convert(in Scalar128<float> src, out int dst)
        {
            dst = ConvertToInt32WithTruncation(src.mm);
            return dst;
        }

        /// <summary>
        /// int _mm_cvttsd_si32 (__m128d a)CVTTSD2SI reg, xmm/m64
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static int convert(in Scalar128<double> src, out int dst)
        {
            dst = ConvertToInt32WithTruncation(src.mm);
            return dst;
        }

        [MethodImpl(Inline)]
        public static float to32f(int src)        
            => ConvertScalarToVector128Single(default, src).GetElement(0);

        [MethodImpl(Inline)]
        public static unsafe int to32i(float src)
            => ConvertToInt32WithTruncation(LoadScalarVector128(refptr(ref src)));

        [MethodImpl(Inline)]
        public static unsafe int to32i(double src)
            => ConvertToInt32WithTruncation(LoadScalarVector128(refptr(ref src)));

        [MethodImpl(Inline)]
        public static float to32f(long src)        
            => ConvertScalarToVector128Single(default, src).GetElement(0);

        [MethodImpl(Inline)]
        public static unsafe long to64i(float src)
            => ConvertToInt64WithTruncation(LoadScalarVector128(refptr(ref src)));

        /// <summary>
        /// __m128 _mm_add_ss (__m128 a, __m128 b)ADDSS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Scalar128<float> add(in Scalar128<float> x, in Scalar128<float> y)
            => AddScalar(x.mm, y.mm);

        /// <summary>
        /// __m128d _mm_add_sd (__m128d a, __m128d b)ADDSD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Scalar128<double> add(in Scalar128<double> x, in Scalar128<double> y)
            => AddScalar(x.mm, y.mm);

        /// <summary>
        ///  __m128 _mm_mul_ss (__m128 a, __m128 b) MULPS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Scalar128<float> mul(in Scalar128<float> x, in Scalar128<float> y)
            =>  MultiplyScalar(x.mm, y.mm);

        /// <summary>
        ///  __m128d _mm_mul_sd (__m128d a, __m128d b) MULSD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Scalar128<double> mul(in Scalar128<double> x, in Scalar128<double> y)
            =>  MultiplyScalar(x.mm, y.mm);

        /// <summary>
        /// __m128 _mm_fmadd_ss (__m128 a, __m128 b, __m128 c) VFMADDSS xmm, xmm, xmm/m32
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Scalar128<float> fmadd(in Scalar128<float> x, in Scalar128<float> y, in Scalar128<float> z)
            => MultiplyAddScalar(x.mm, y.mm, z.mm);

        /// <summary>
        /// __m128d _mm_fmadd_sd (__m128d a, __m128d b, __m128d c) VFMADDSS xmm, xmm, xmm/m64
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Scalar128<double> fmadd(in Scalar128<double> x, in Scalar128<double> y, in Scalar128<double> z)
            => MultiplyAddScalar(x.mm, y.mm, z.mm);

        /// <summary>
        /// __m128 _mm_fmsub_ss (__m128 a, __m128 b, __m128 c)VFMSUBSS xmm, xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        [MethodImpl(Inline)]
        public static Scalar128<float> fmsub(in Scalar128<float> x, in Scalar128<float> y, in Scalar128<float> z)
            => MultiplySubtractScalar(x.mm,y.mm,z.mm);

        /// <summary>
        /// __m128d _mm_fmsub_sd (__m128d a, __m128d b, __m128d c)VFMSUBSD xmm, xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        [MethodImpl(Inline)]
        public static Scalar128<double> fmsub(in Scalar128<double> x, in Scalar128<double> y, in Scalar128<double> z)
            => MultiplySubtractScalar(x.mm,y.mm,z.mm);

        /// <summary>
        /// __m128 _mm_fnmadd_ss (__m128 a, __m128 b, __m128 c) VFNMADDSS xmm, xmm, xmm/m32
        /// dst = -(x*y + z)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Scalar128<float> fnmadd(in Scalar128<float> x, in Scalar128<float> y, in Scalar128<float> z)
            => MultiplyAddNegatedScalar(x.mm,y.mm,z.mm);

        /// <summary>
        /// __m128d _mm_fnmadd_sd (__m128d a, __m128d b, __m128d c) VFNMADDSD xmm, xmm, xmm/m64
        /// dst = -(x*y + z)
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <param name="z">The third operand</param>
        [MethodImpl(Inline)]
        public static Scalar128<double> fnmadd(in Scalar128<double> x, in Scalar128<double> y, in Scalar128<double> z)
            => MultiplyAddNegatedScalar(x.mm,y.mm,z.mm);

        /// <summary>
        /// __m128 _mm_div_ss (__m128 a, __m128 b)DIVSS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static Scalar128<float> div(in Scalar128<float> x, in Scalar128<float> y)
            => DivideScalar(x.mm, y.mm);
            
        /// <summary>
        ///  __m128d _mm_div_sd (__m128d a, __m128d b)DIVSD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Scalar128<double> div(in Scalar128<double> x, in Scalar128<double> y)
            => DivideScalar(x.mm, y.mm);

        /// <summary>
        /// __m128 _mm_sub_ss (__m128 a, __m128 b) SUBSS xmm, xmm/m32
        /// </summary>
        /// <param name="x">The left vectorized scalar</param>
        /// <param name="y">The right vectorized scalar</param>
        [MethodImpl(Inline)]
        public static Scalar128<float> sub(in Scalar128<float> x, in Scalar128<float> y)
            => SubtractScalar(x.mm, y.mm);
            
        /// <summary>
        /// __m128d _mm_sub_sd (__m128d a, __m128d b) SUBSD xmm, xmm/m64
        /// </summary>
        /// <param name="x">The left vectorized scalar</param>
        /// <param name="y">The right vectorized scalar</param>
        [MethodImpl(Inline)]
        public static Scalar128<double> sub(in Scalar128<double> x, in Scalar128<double> y)
            => SubtractScalar(x.mm, y.mm);

        /// <summary>
        /// __m128 _mm_max_ss (__m128 a, __m128 b) MAXSS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Scalar128<float> max(in Scalar128<float> x, in Scalar128<float> y)
            => MaxScalar(x.mm, y.mm);            

        /// <summary>
        /// __m128d _mm_max_sd (__m128d a, __m128d b) MAXSD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static Scalar128<double> max(in Scalar128<double> x, in Scalar128<double> y)
            => MaxScalar(x.mm, y.mm);

        /// <summary>
        ///  __m128 _mm_min_ss (__m128 a, __m128 b) MINSS xmm, xmm/m32
        /// </summary>
        /// <param name="x">The left vectorized scalar</param>
        /// <param name="y">The right vectorized scalar</param>
        [MethodImpl(Inline)]
        public static Scalar128<float> min(in Scalar128<float> x, in Scalar128<float> y)
            => MinScalar(x.mm, y.mm);

        /// <summary>
        /// __m128d _mm_min_sd (__m128d a, __m128d b) MINSD xmm, xmm/m64
        /// </summary>
        /// <param name="x">The left vectorized scalar</param>
        /// <param name="y">The right vectorized scalar</param>
        [MethodImpl(Inline)]
        public static Scalar128<double> min(in Scalar128<double> x, in Scalar128<double> y)
            => MinScalar(x.mm, y.mm);

        /// <summary>
        ///  int _mm_ucomieq_ss (__m128 a, __m128 b)UCOMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool eq(in Scalar128<float> x,in Scalar128<float> y)
            => CompareScalarUnorderedEqual(x.mm, y.mm);
        
        /// <summary>
        /// int _mm_ucomieq_sd (__m128d a, __m128d b)UCOMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool eq(in Scalar128<double> x,in Scalar128<double> y)
            => CompareScalarUnorderedEqual(x.mm, y.mm);

        /// <summary>
        /// int _mm_comineq_ss (__m128 a, __m128 b)COMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool neq(in Scalar128<float> x, in Scalar128<float> y)
            => CompareScalarOrderedNotEqual(x.mm, y.mm);
        
        /// <summary>
        ///  int _mm_comineq_sd (__m128d a, __m128d b)COMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool neq(in Scalar128<double> x, in Scalar128<double> y)
            => CompareScalarOrderedNotEqual(x.mm, y.mm);

        /// <summary>
        /// int _mm_comigt_ss (__m128 a, __m128 b)COMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool gt(in Scalar128<float> x, in Scalar128<float> y)
            => CompareScalarOrderedGreaterThan(x.mm, y.mm);
        
        /// <summary>
        /// int _mm_comigt_sd (__m128d a, __m128d b)COMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool gt(in Scalar128<double> x, in Scalar128<double> y)
            => CompareScalarOrderedGreaterThan(x.mm, y.mm);

        /// <summary>
        /// int _mm_comige_ss (__m128 a, __m128 b)COMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool gteq(in Scalar128<float> x, in Scalar128<float> y)
            => CompareScalarOrderedGreaterThanOrEqual(x.mm, y.mm);
        
        /// <summary>
        /// int _mm_comige_sd (__m128d a, __m128d b)COMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool gteq(in Scalar128<double> x, in Scalar128<double> y)
            => CompareScalarOrderedGreaterThanOrEqual(x.mm, y.mm);

        /// <summary>
        /// __m128 _mm_cmpngt_ss (__m128 a, __m128 b)CMPSS xmm, xmm/m32, imm8(2)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool ngt(in Scalar128<float> x, in Scalar128<float> y)
            => CompareScalarNotGreaterThan(x.mm, y.mm).IsNaN(0);

        /// <summary>
        /// __m128d _mm_cmpngt_sd (__m128d a, __m128d b)CMPSD xmm, xmm/m64, imm8(2)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool ngt(in Scalar128<double> x, in Scalar128<double> y)
            => CompareScalarNotGreaterThan(x.mm, y.mm).IsNaN(0);

        /// <summary>
        /// int _mm_comilt_ss (__m128 a, __m128 b)COMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool lt(in Scalar128<float> x, in Scalar128<float> y)
            => CompareScalarOrderedLessThan(x.mm, y.mm);                

        /// <summary>
        /// int _mm_comilt_sd (__m128d a, __m128d b)COMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool lt(in Scalar128<double> x, in Scalar128<double> y)
            => CompareScalarOrderedLessThan(x.mm, y.mm);

        /// <summary>
        ///  __m128 _mm_cmpnlt_ss (__m128 a, __m128 b)CMPSS xmm, xmm/m32, imm8(5)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool nlt(in Scalar128<float> x, in Scalar128<float> y)
            => CompareScalarNotLessThan(x, y).IsNaN(0);
        
        /// <summary>
        /// __m128d _mm_cmpnlt_sd (__m128d a, __m128d b)CMPSD xmm, xmm/m64, imm8(5)
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool nlt(in Scalar128<double> x, in Scalar128<double> y)
            => CompareScalarNotLessThan(x.mm, y.mm).IsNaN(0);

        /// <summary>
        ///  int _mm_ucomile_ss (__m128 a, __m128 b)UCOMISS xmm, xmm/m32
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool lteq(in Scalar128<float> x, in Scalar128<float> y)
            => CompareScalarUnorderedLessThanOrEqual(x.mm,y.mm);
        
        /// <summary>
        /// int _mm_ucomile_sd (__m128d a, __m128d b)UCOMISD xmm, xmm/m64
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        [MethodImpl(Inline)]
        public static bool lteq(in Scalar128<double> x, in Scalar128<double> y)
            => CompareScalarUnorderedLessThanOrEqual(x.mm, y.mm);

        /// <summary>
        /// __m128 _mm_cmp_ss (__m128 a, __m128 b, const int imm8) VCMPSD xmm, xmm, xmm/m64, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="mode"></param>
        [MethodImpl(Inline)]
        public static Scalar128<float> cmp(in Scalar128<float> x, in Scalar128<float> y, FpCmpMode mode)
            => CompareScalar(x.mm,y.mm, fpmode(mode));
   
        /// <summary>
        /// __m128d _mm_cmp_sd (__m128d a, __m128d b, const int imm8) VCMPSS xmm, xmm, xmm/m32, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="mode"></param>
        [MethodImpl(Inline)]
        public static Scalar128<double> cmp(in Scalar128<double> x, in Scalar128<double> y, FpCmpMode mode)
            => CompareScalar(x.mm,y.mm, fpmode(mode));

        /// <summary>
        /// __m128 _mm_ceil_ss (__m128 a)ROUNDSD xmm, xmm/m128, imm8(10)
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static Scalar128<float> ceil(in Scalar128<float> src)
            => CeilingScalar(src.mm);

        /// <summary>
        /// __m128d _mm_ceil_sd (__m128d a)ROUNDSD xmm, xmm/m128, imm8(10)
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static Scalar128<double> ceil(in Scalar128<double> src)
            => CeilingScalar(src.mm);

        /// <summary>
        ///  __m128 _mm_ceil_ss (__m128 a)ROUNDSD xmm, xmm/m128, imm8(10)
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static Scalar128<float> floor(in Scalar128<float> src)
            => CeilingScalar(src.mm);
        
        /// <summary>
        /// __m128d _mm_ceil_sd (__m128d a)ROUNDSD xmm, xmm/m128, imm8(10)
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static Scalar128<double> floor(in Scalar128<double> src)
            => CeilingScalar(src.mm);

        /// <summary>
        /// __m128 _mm_rcp_ss (__m128 a) RCPSS xmm, xmm/m32
        /// </summary>
        /// <param name="src">The source vector</param>

        [MethodImpl(Inline)]
        public static Scalar128<float> rcp(in Scalar128<float> src)
            => ReciprocalScalar(src.mm);

        /// <summary>
        /// __m128 _mm_sqrt_ss (__m128 a) SQRTSS xmm, xmm/m32
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static Scalar128<float> sqrt(in Scalar128<float> src)
            => SqrtScalar(src.mm);

        /// <summary>
        /// _m128d _mm_sqrt_sd (__m128d a) SQRTSD xmm, xmm/64 
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static Scalar128<double> sqrt(in Scalar128<double> src)
            => SqrtScalar(src.mm);

        /// <summary>
        /// __m128 _mm_rsqrt_ss (__m128 a) RSQRTSS xmm, xmm/m32
        /// </summary>
        /// <param name="src"></param>
        [MethodImpl(Inline)]
        public static ref Scalar128<float> rsqrt(ref Scalar128<float> src)
        {
            src = ReciprocalSqrtScalar(src.mm);
            return ref src;
        }
 
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