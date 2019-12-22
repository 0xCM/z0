//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse2;
     
    using static As;
    using static zfunc;    

    partial class fpinx
    {
        /// <summary>
        /// __m128i _mm_cvttps_epi32 (__m128 a) CVTTPS2DQ xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector128<int> convert(Vector128<float> src, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32WithTruncation(src);
            return ref dst;
        }

        /// <summary>
        /// __m128 _mm_cvtepi32_ps (__m128i a) CVTDQ2PS xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector128<float> convert(Vector128<int> src, out Vector128<float> dst)
        {
            dst = ConvertToVector128Single(src);
            return ref dst;
        }

        /// <summary>
        /// __m256d _mm256_cvtepi32_pd (__m128i a) VCVTDQ2PD ymm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector256<double> convert(Vector128<int> src, out Vector256<double> dst)
        {
            dst = ConvertToVector256Double(src);
            return ref dst;
        }

        /// <summary>
        /// __m128 _mm_cvtpd_ps (__m128d a) CVTPD2PS xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector128<float> convert(Vector128<double> src, out Vector128<float> dst)
        {
            dst = ConvertToVector128Single(src);
            return ref dst;
        }

        /// <summary>
        /// __m256 _mm256_cvtepi32_ps (__m256i a) VCVTDQ2PS ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector256<float> convert(Vector256<int> src, out Vector256<float> dst)
        {
            dst = ConvertToVector256Single(src);
            return ref dst;
        }

        /// <summary>
        ///  __m128i _mm_cvttpd_epi32 (__m128d a) CVTTPD2DQ xmm, xmm/m128
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector128<int> convert(Vector128<double> src, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32WithTruncation(src);
            return ref dst;
        }

        /// <summary>
        /// __m256i _mm256_cvttps_epi32 (__m256 a) VCVTTPS2DQ ymm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector256<int> convert(Vector256<float> src, out Vector256<int> dst)
        {
            dst = ConvertToVector256Int32WithTruncation(src);
            return ref dst;
        }

        /// <summary>
        /// __m128i _mm256_cvttpd_epi32 (__m256d a) VCVTTPD2DQ xmm, ymm/m256
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public static ref Vector128<int> convert(Vector256<double> src, out Vector128<int> dst)
        {
            dst = ConvertToVector128Int32WithTruncation(src);
            return ref dst;
        }
    }

}