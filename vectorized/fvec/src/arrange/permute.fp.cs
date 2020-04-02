//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static Core;

    partial class dinxfp
    {
        /// <summary>
        /// __m256d _mm256_permute4x64_pd (__m256d a, const int imm8) VPERMPD ymm, ymm/m256, imm8
        /// Permutes components in the source vector across lanes as specified by the control byte
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The control byte</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vperm4x64(Vector256<double> x, [Imm] byte spec)
            => Permute4x64(x,spec); 

        /// <summary>
        /// __m256d _mm256_permute4x64_pd (__m256d a, const int imm8)VPERMPD ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vperm4x64(Vector256<double> x, [Imm] Perm4L spec)
            => vperm4x64(x,(byte)spec);


        /// <summary>
        /// Permutes components in the source vector across lanes as specified by the control vector
        /// __m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx)VPERMPS ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The control vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vperm8x32(Vector256<float> src, Vector256<int> spec)
            => PermuteVar8x32(src, spec);

        /// <summary>
        /// __m256 _mm256_permutevar8x32_ps (__m256 a, __m256i idx)VPERMPS ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vperm8x32(Vector256<float> src, Vector256<uint> spec)
            => PermuteVar8x32(src, spec.AsInt32());

        /// <summary>
        /// __m256 _mm256_permute2f128_ps (__m256 a, __m256 b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vperm2x128(Vector256<float> x, Vector256<float> y, [Imm] byte spec)
            => Permute2x128(x, y, spec);

        /// <summary>
        /// __m256d _mm256_permute2f128_pd (__m256d a, __m256d b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vperm2x128(Vector256<double> x, Vector256<double> y, byte spec)
            => Permute2x128(x, y, spec);

        /// <summary>
        /// __m256 _mm256_permute2f128_ps (__m256 a, __m256 b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vperm2x128(Vector256<float> x, Vector256<float> y, Perm2x4 spec)
            => vperm2x128(x, y, (byte)spec);

        /// <summary>
        /// __m256d _mm256_permute2f128_pd (__m256d a, __m256d b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vperm2x128(Vector256<double> x, Vector256<double> y, Perm2x4 spec)
            => vperm2x128(x, y, (byte)spec);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<float> vswaphl(Vector256<float> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<double> vswaphl(Vector256<double> x)
            => vperm2x128(x,x, Perm2x4.DA);

        [MethodImpl(Inline), Op]
        public static Vector256<float> vreverse(Vector256<float> src)
            => dinxfp.vperm8x32(src,MRev256f32);    

        static Vector256<int> MRev256f32 
            => VCore.vpartsi(n256, 7, 6, 5, 4, 3, 2, 1, 0);    
    }
}