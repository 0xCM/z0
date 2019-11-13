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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse.X64;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    
    using static As;
    using static zfunc;    

    partial class dfp
    {
        /// <summary>
        /// Transposes a 4x4 matrix of floats, adapted from MSVC intrinsic headers
        /// </summary>
        /// <param name="row0">The first row</param>
        /// <param name="row1">The second row</param>
        /// <param name="row2">The third row</param>
        /// <param name="row3">The fourth row</param>
        [MethodImpl(Inline)]
        public static void vtranspose(ref Vector128<float> row0, ref Vector128<float> row1, ref Vector128<float> row2, ref Vector128<float> row3)
        {
            var tmp0 = Shuffle(row0,row1, 0x44);
            var tmp2 = Shuffle(row0, row1, 0xEE);
            var tmp1 = Shuffle(row2, row3, 0x44);
            var tmp3 = Shuffle(row2,row3, 0xEE);
            row0 = Shuffle(tmp0,tmp1, 0x88);
            row1 = Shuffle(tmp0,tmp1, 0xDD);
            row2 = Shuffle(tmp2,tmp3, 0x88);
            row3 = Shuffle(tmp2, tmp3, 0xDD);
        }    

        /// <summary>
        /// __m128 _mm_shuffle_ps (__m128 a, __m128 b, unsigned int control) SHUFPS xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control"></param>
        [MethodImpl(Inline)]
        public static Vector128<float> vshuffle(Vector128<float> x, Vector128<float> y, byte control)
            => Shuffle(x, y, control);

        /// <summary>
        /// __m128d _mm_shuffle_pd (__m128d a, __m128d b, int immediate) SHUFPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control"></param>
        [MethodImpl(Inline)]
        public static Vector128<double> vshuffle(Vector128<double> x, Vector128<double> y, byte control)
            => Shuffle(x, y, control);
 
        /// <summary>
        /// __m128 _mm_move_ss (__m128 a, __m128 b) MOVSS xmm, xmm
        /// Moves the lower single-precision (32-bit) floating-point element from b to the lower element of dst, and copy 
        /// the upper 3 elements from a to the upper elements of dst.
        /// </summary>
        [MethodImpl(Inline)]
        public static Vec128<float> vmovescalar(Vector128<float> x, Vector128<float> y)
            => MoveScalar(y,x);

        /// <summary>
        /// __m128d _mm_move_sd (__m128d a, __m128d b) MOVSD xmm, xmm
        /// Moves the lower double-precision (64-bit) floating-point element from "b" to the lower element of "dst", and copy 
        /// the upper element from "a" to the upper element of "dst"
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        [MethodImpl(Inline)]
        public static Vec128<double> vmovescalar(Vector128<double> x, Vector128<double> y)
            => MoveScalar(y,x);

        /// <summary>
        /// _mm256_insertf128_ps: Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vinsert(Vector128<float> src, in Vector256<float> dst, byte index)        
            => InsertVector128(dst, src, index);

        /// <summary>
        /// _mm256_insertf128_pd: Overwrites a 128-bit lane in the target with the content of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        /// <param name="index">Identifies the lane in the target to overwrite, either 0 or 1 respectively 
        /// identifing low or hi</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vinsert(Vector128<double> src, in Vector256<double> dst, byte index)        
            => InsertVector128(dst, src, index);

        /// <summary>
        /// __m256 _mm256_blendv_ps (__m256 a, __m256 b, __m256 mask) VBLENDVPS ymm, ymm, ymm/m256, ymm
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component, z[i] = testbit(spec[i],31) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vblend8x32(Vector256<float> x, Vector256<float> y, Vector256<float> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// __m256d _mm256_blendv_pd (__m256d a, __m256d b, __m256d mask)VBLENDVPD ymm, ymm, ymm/m256, ymm
        /// Creates a target vector z from components chosen from two source vectors x and y 
        /// as determined by the hi bit of each corresponding specifier component, z[i] = testbit(spec[i],63) ? x[i] : y[i]
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vblend4x64(Vector256<double> x, Vector256<double> y, Vector256<double> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// __m256 _mm256_permute2f128_ps (__m256 a, __m256 b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vperm2x128(Vector256<float> x, Vector256<float> y, Perm2x4 spec)
            => Permute2x128(x, y, (byte)spec);

        /// <summary>
        /// __m256d _mm256_permute2f128_pd (__m256d a, __m256d b, int imm8) VPERM2F128 ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The permutation spec</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vperm2x128(Vector256<double> x, Vector256<double> y, Perm2x4 spec)
            => Permute2x128(x, y, (byte)spec);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vswaphl(Vector256<float> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vswaphl(Vector256<double> x)
            => vperm2x128(x,x, Perm2x4.DA);

        [MethodImpl(Inline)]
        public static Vector256<float> vreverse(Vector256<float> src)
            => dfp.vperm8x32(src,MRev256f32);    

        static Vector256<int> MRev256f32 
            => dinx.vparts(n256, 7, 6, 5, 4, 3, 2, 1, 0);    
    }
}