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

    using static System.Runtime.Intrinsics.X86.Avx2;

    using static zfunc;
    using static As;

    partial class dinx
    {         
        /// <summary>
        ///  __m128i _mm_srlv_epi32 (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The control vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vsrlv(Vector128<int> src, Vector128<uint> offset)
            => ShiftRightLogicalVariable(src, offset);

        /// <summary>
        /// __m128i _mm_srlv_epi32 (__m128i a, __m128i count) VPSRLVD xmm, xmm, xmm/m128
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vsrlv(Vector128<uint> src, Vector128<uint> offset)
            => ShiftRightLogicalVariable(src, offset);

        /// <summary>
        /// __m128i _mm_srlv_epi64 (__m128i a, __m128i count) VPSRLVQ xmm, xmm, xmm/m128
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vsrlv(Vector128<long> src, Vector128<ulong> offset)
            => ShiftRightLogicalVariable(src, offset);

        /// <summary>
        /// __m128i _mm_srlv_epi64 (__m128i a, __m128i count) VPSRLVQ xmm, xmm, xmm/m128
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vsrlv(Vector128<ulong> src, Vector128<ulong> offset)
            => ShiftRightLogicalVariable(src, offset);       
 
        /// <summary>
        /// __m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vsrlv(Vector256<int> src, Vector256<uint> offset)
            => ShiftRightLogicalVariable(src, offset);


        /// <summary>
        /// __m256i _mm256_srlv_epi32 (__m256i a, __m256i count) VPSRLVD ymm, ymm, ymm/m256
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vsrlv(Vector256<uint> src, Vector256<uint> offset)
            => ShiftRightLogicalVariable(src, offset);

        /// <summary>
        /// __m256i _mm256_srlv_epi64 (__m256i a, __m256i count) VPSRLVQ ymm, ymm, ymm/m256
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vsrlv(Vector256<long> src, Vector256<ulong> offset)
            => ShiftRightLogicalVariable(src, offset);

        /// <summary>
        ///  __m256i _mm256_srlv_epi64 (__m256i a, __m256i count) VPSRLVQ ymm, ymm, ymm/m256
        /// Applies a rightward logical shift to each source vector component as 
        /// specified by the amount the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The shift offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vsrlv(Vector256<ulong> src, Vector256<ulong> offset)
            => ShiftRightLogicalVariable(src, offset); 
    
    }
}