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

    partial class dinx
    {
        /// <summary>
        /// __m128i _mm_sllv_epi32 (__m128i a, __m128i count) VPSLLVD xmm, ymm, xmm/m128
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> vsllv(in Vec128<int> src, in Vec128<uint> offset)
            => ShiftLeftLogicalVariable(src.xmm, offset.xmm);

        /// <summary>
        /// __m128i _mm_sllv_epi32 (__m128i a, __m128i count) VPSLLVD xmm, ymm, xmm/m128
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vsllv(in Vec128<uint> src, in Vec128<uint> offset)
            => ShiftLeftLogicalVariable(src.xmm, offset.xmm);

        /// <summary>
        ///  __m128i _mm_sllv_epi64 (__m128i a, __m128i count) VPSLLVQ xmm, ymm, xmm/m128
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec128<long> vsllv(in Vec128<long> src, in Vec128<ulong> offset)
            => ShiftLeftLogicalVariable(src.xmm, offset.xmm);

        /// <summary>
        /// __m128i _mm_sllv_epi64 (__m128i a, __m128i count) VPSLLVQ xmm, ymm, xmm/m128
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vsllv(in Vec128<ulong> src, in Vec128<ulong> offset)
            => ShiftLeftLogicalVariable(src.xmm, offset.xmm);           

        /// <summary>
        /// __m256i _mm256_sllv_epi32 (__m256i a, __m256i count) VPSLLVD ymm, ymm, ymm/m256
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<int> vsllv(in Vec256<int> src, in Vec256<uint> offset)
            => ShiftLeftLogicalVariable(src.ymm, offset.ymm);

        /// <summary>
        ///  __m256i _mm256_sllv_epi32 (__m256i a, __m256i count) VPSLLVD ymm, ymm, ymm/m256
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vsllv(in Vec256<uint> src, in Vec256<uint> offset)
            => ShiftLeftLogicalVariable(src.ymm, offset.ymm);

        /// <summary>
        ///  __m256i _mm256_sllv_epi64 (__m256i a, __m256i count) VPSLLVQ ymm, ymm, ymm/m256
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding control vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<long> vsllv(in Vec256<long> src, in Vec256<ulong> offset)
            => ShiftLeftLogicalVariable(src.ymm, offset.ymm);

        /// <summary>
        /// __m256i _mm256_sllv_epi64 (__m256i a, __m256i count) VPSLLVQ ymm, ymm, ymm/m256
        /// Applies a leftward logical shift to each source vector component as 
        /// specified by the amount in the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vsllv(in Vec256<ulong> src, in Vec256<ulong> offset)
            => ShiftLeftLogicalVariable(src.ymm, offset.ymm);  

    }
}