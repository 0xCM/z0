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
    
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec128<float> src) 
            => ! TestZ(src.xmm, src.xmm);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec128<double> src) 
            => ! TestZ(src.xmm, src.xmm);        
 
         /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec256<float> src) 
            => ! TestZ(src,src);        

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline)]
        public static bool nonz(in Vec256<double> src) 
            => ! TestZ(src,src);          

        /// <summary>
        /// __m128 _mm_cmple_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(2)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> lteq(in Vec128<float> x, in Vec128<float> y)
            => CompareLessThanOrEqual(x.xmm, y.xmm);
        
        /// <summary>
        /// __m128d _mm_cmple_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(2)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> lteq(in Vec128<double> x, in Vec128<double> y)
            => CompareLessThanOrEqual(x.xmm, y.xmm);

        /// <summary>
        /// __m128 _mm_cmpge_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(5)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> gteq(Vec128<float> x, Vec128<float> y)
            => CompareGreaterThanOrEqual(x.xmm, y.xmm);
        
        /// <summary>
        /// __m128d _mm_cmpge_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(5)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> gteq(Vec128<double> x, Vec128<double> y)
            => CompareGreaterThanOrEqual(x.xmm, y.xmm);

        /// <summary>
        ///  __m128d _mm_cmpnlt_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(5)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<double> nlt(in Vec128<double> x, in Vec128<double> y)
            => Vec128Cmp.Define<double>(CompareNotLessThan(x.xmm, y.xmm));

        /// <summary>
        /// __m128 _mm_cmpnlt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(5)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128Cmp<float> nlt(in Vec128<float> x, in Vec128<float> y)
            => Vec128Cmp.Define<float>(CompareNotLessThan(x.xmm, y.xmm));

        /// <summary>
        /// __m128 _mm_cmpnge_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(1)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> ngteq(in Vec128<float> x, in Vec128<float> y)
            => CompareNotGreaterThanOrEqual(x.xmm, y.xmm);

        /// <summary>
        /// __m128d _mm_cmpnge_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(1)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> ngteq(in Vec128<double> x, in Vec128<double> y)
            => CompareNotGreaterThanOrEqual(x.xmm, y.xmm);

        /// <summary>
        /// __m128 _mm_cmpnlt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(5)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> nlt(Vec128<float> x, Vec128<float> y)
            => CompareNotLessThan(x.xmm, y.xmm);
        
        /// <summary>
        /// __m128d _mm_cmpnlt_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(5)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> nlt(Vec128<double> x, Vec128<double> y)
            => CompareNotLessThan(x.xmm, y.xmm);

        /// <summary>
        /// __m128 _mm_cmpngt_ps (__m128 a, __m128 b) CMPPS xmm, xmm/m128, imm8(2)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<float> ngt(in Vec128<float> x, in Vec128<float> y)
            => CompareNotGreaterThan(x.xmm, y.xmm);
        
        /// <summary>
        /// __m128d _mm_cmpngt_pd (__m128d a, __m128d b) CMPPD xmm, xmm/m128, imm8(2)
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> ngt(in Vec128<double> x, in Vec128<double> y)
            => CompareNotGreaterThan(x.xmm, y.xmm);
 
        /// <summary>
        /// __m128d _mm_cmp_pd (__m128d a, __m128d b, const int imm8)VCMPPD xmm, xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="mode"></param>
        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec128<double> x,in Vec128<double> y, FpCmpMode mode)
            => Compare(x.xmm, y.xmm, fpmode(mode)).TestNaN();

        /// <summary>
        /// Determines whether the componenents are assigned the NaN value and
        /// returns the result as an array of bools
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        static bool[] TestNaN(this Vector128<double> src)
            => array(src.GetElement(0).IsNaN(), src.GetElement(1).IsNaN());

        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec256<float> x,in Vec256<float> y, FpCmpMode mode)
        {
            Span<float> vresult = stackalloc float[8];
            Compare(x,y,fpmode(mode)).StoreTo(ref head(vresult));
            var bits = new bool[8];
            bits[0] = double.IsNaN(vresult[0]);
            bits[1] = double.IsNaN(vresult[1]);
            bits[2] = double.IsNaN(vresult[2]);
            bits[3] = double.IsNaN(vresult[3]);
            bits[4] = double.IsNaN(vresult[4]);
            bits[5] = double.IsNaN(vresult[5]);
            bits[6] = double.IsNaN(vresult[6]);
            bits[7] = double.IsNaN(vresult[7]);
            return bits;

        }

        [MethodImpl(Inline)]
        public static bool[] cmpf(in Vec256<double> x,in Vec256<double> y, FpCmpMode mode)
        {
            Span<double> vresult = stackalloc double[4];
            Compare(x,y,fpmode(mode)).StoreTo(ref head(vresult));
            var bits = new bool[4];
            bits[0] = double.IsNaN(vresult[0]);
            bits[1] = double.IsNaN(vresult[1]);
            bits[2] = double.IsNaN(vresult[2]);
            bits[3] = double.IsNaN(vresult[3]);
            return bits;

        }

    }

}