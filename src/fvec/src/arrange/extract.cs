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
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static Konst;

    partial class dinxfp
    {
        /// <summary>
        /// int _mm_extract_ps (__m128 a, const int imm8)EXTRACTPS xmm, xmm/m32, imm8
        /// Extracts the value of an identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline), Op]
        public static float vextract(Vector128<float> src, Hex2Seq pos)
            => Extract(src, (byte)pos);

        /// <summary>
        /// __m128 _mm256_extractf128_ps (__m256 a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<float> vextract(Vector256<float> src, byte pos)
            => ExtractVector128(src, pos);

        /// <summary>
        /// __m128d _mm256_extractf128_pd (__m256d a, const int imm8) VEXTRACTF128 xmm/m128, ymm, imm8
        /// Extracts either the lo (pos = 0) or hi (pos = 1) 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The index of the lane to extract</param>
        [MethodImpl(Inline), Op]
        public static Vector128<double> vextract(Vector256<double> src, byte pos)
            => ExtractVector128(src, pos);

        /// <summary>
        /// Extracts the value of an identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline), Op]
        public static float vxscalar(Vector128<float> src, byte pos)
            => Extract(src,pos);

        /// <summary>
        /// Extracts the value of an identified source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="pos">The zero-based index of the source component to extract</param>
        [MethodImpl(Inline), Op]
        public static double vxscalar(Vector128<double> src, byte pos)
            => src.GetElement(pos);
    }
}