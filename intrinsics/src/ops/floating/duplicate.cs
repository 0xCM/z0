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
    
    using static As;
    using static zfunc;    

    partial class dfp
    {
        [MethodImpl(Inline)]
        public static Vector256<float> vduplicate(N0 even, Vector256<float> src)
            => DuplicateEvenIndexed(src);

        [MethodImpl(Inline)]
        public static Vector256<float> vduplicate(N1 odd, Vector256<float> src)
            => DuplicateOddIndexed(src);


        [MethodImpl(Inline)]
        public static Vector256<double> duplicate(N0 even, Vector256<double> src)
            => DuplicateEvenIndexed(src);

        [MethodImpl(Inline)]
        public static Vector256<float> dupeven(Vector256<float> src)
            => DuplicateEvenIndexed(src);

        [MethodImpl(Inline)]
        public static Vector256<float> dupodd(Vector256<float> src)
            => DuplicateOddIndexed(src);


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
