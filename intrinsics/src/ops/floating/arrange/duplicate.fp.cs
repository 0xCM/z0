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
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;    

    partial class dinxfp
    {
        /// <summary>
        /// __m256 _mm256_moveldup_ps (__m256 a) VMOVSLDUP ymm, ymm/m256
        /// </summary>
        /// <param name="even"></param>
        /// <param name="src"></param>
        /// <returns></returns>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vdup32(N0 even, Vector256<float> src)
            => DuplicateEvenIndexed(src);

        /// <summary>
        /// __m256 _mm256_movehdup_ps (__m256 a) VMOVSHDUP ymm, ymm/m256
        /// </summary>
        /// <param name="odd"></param>
        /// <param name="src"></param>
        /// <returns></returns>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vdup32(N1 odd, Vector256<float> src)
            => DuplicateOddIndexed(src);

        /// <summary>
        /// __m256d _mm256_movedup_pd (__m256d a) VMOVDDUP ymm, ymm/m256
        /// </summary>
        /// <param name="even"></param>
        /// <param name="src"></param>
        /// <returns></returns>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vdup64(N0 even, Vector256<double> src)
            => DuplicateEvenIndexed(src);

        [MethodImpl(Inline), Op]
        public static Vector256<double> vdup64(N1 odd, Vector256<double> src)
            => DuplicateEvenIndexed(ShiftRightLogical(src.AsUInt64(),64).AsDouble());
    }

}










/*
        //
        // Summary:
        //     __m256d _mm256_movedup_pd (__m256d a)VMOVDDUP ymm, ymm/m256
        //
        // Parameters:
        //   value:
        public static Vector256<double> DuplicateEvenIndexed(Vector256<double> value);
        //
        // Summary:
        //     __m256 _mm256_moveldup_ps (__m256 a)VMOVSLDUP ymm, ymm/m256
        //
        // Parameters:
        //   value:
        public static Vector256<float> DuplicateEvenIndexed(Vector256<float> value);
        //
        // Summary:
        //     __m256 _mm256_movehdup_ps (__m256 a)VMOVSHDUP ymm, ymm/m256
        //
        // Parameters:
        //   value:
        public static Vector256<float> DuplicateOddIndexed(Vector256<float> value);
*/
