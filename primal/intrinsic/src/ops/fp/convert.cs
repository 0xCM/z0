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
    using static System.Runtime.Intrinsics.X86.Sse2;
     
    using static As;
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// __m128i _mm_cvttps_epi32 (__m128 a)CVTTPS2DQ xmm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ref Vec128<int> convert(in Vec128<float> src, out Vec128<int> dst)
        {
            dst = ConvertToVector128Int32WithTruncation(src.xmm);
            return ref dst;
        }

        /// <summary>
        /// __m128 _mm_cvtepi32_ps (__m128i a)CVTDQ2PS xmm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static ref Vec128<float> convert(in Vec128<int> src, out Vec128<float> dst)
        {
            dst = ConvertToVector128Single(src.xmm);
            return ref dst;
        }

        /// <summary>
        /// __m128 _mm_cvtpd_ps (__m128d a)CVTPD2PS xmm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        [MethodImpl(Inline)]
        public static ref Vec128<float> convert(in Vec128<double> src, out Vec128<float> dst)
        {
            dst = ConvertToVector128Single(src.xmm);
            return ref dst;
        }

        /// <summary>
        ///  __m128i _mm_cvttpd_epi32 (__m128d a)CVTTPD2DQ xmm, xmm/m128
        /// </summary>
        /// <param name="src"></param>
        /// <param name="dst"></param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static ref Vec128<int> convert(in Vec128<double> src, out Vec128<int> dst)
        {
            dst = ConvertToVector128Int32WithTruncation(src.xmm);
            return ref dst;
        }

    }

}