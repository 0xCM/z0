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
    using static System.Runtime.Intrinsics.X86.Sse41;
    
    using static zfunc;    

    partial class dinxfp
    {
        /// <summary>
        /// __m128 _mm_blend_ps (__m128 a, __m128 b, const int imm8) BLENDPS xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<float> vblend(Vector128<float> x, Vector128<float> y, byte control)        
            => Blend(x, y, control);

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<double> vblend(Vector128<double> x, Vector128<double> y, byte control)        
            => Blend(x, y, control);

        /// <summary>
        /// __m256 _mm256_blend_ps (__m256 a, __m256 b, const int imm8) VBLENDPS ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vblend(Vector256<float> x, Vector256<float> y, byte control)        
            => Blend(x, y, control);

        /// <summary>
        /// __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8
        /// Produces a new vector by assembling components from two source vectors as specified by a control mask
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vblend(Vector256<double> x, Vector256<double> y, byte control)        
            => Blend(x, y, control);

        /// <summary>
        ///  __m256 _mm256_blendv_ps (__m256 a, __m256 b, __m256 mask) VBLENDVPS ymm, ymm,ymm/m256, ymm
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vblendv(Vector256<float> x, Vector256<float> y, Vector256<float> control)        
            => BlendVariable(x, y, control);

        /// <summary>
        /// _mm256_blendv_ps
        /// Produces a new vector by assembling components from two source vectors as specified by a control vector
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="control">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vblendv(Vector256<double> x, Vector256<double> y, Vector256<double> control)        
            => BlendVariable(x, y, control);
 
        /// <summary>
        /// __m128 _mm_blendv_ps (__m128 a, __m128 b, __m128 mask) BLENDVPS xmm, xmm/m128,xmm0
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<float> vblend4x32(Vector128<float> x, Vector128<float> y, Vector128<float> spec)        
            =>  BlendVariable(x, y, spec);

        /// <summary>
        /// __m128d _mm_blendv_pd (__m128d a, __m128d b, __m128d mask) BLENDVPD xmm, xmm/m128,xmm0
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<double> vblend2x64(Vector128<double> x, Vector128<double> y, Vector128<double> spec)        
            =>  BlendVariable(x, y, spec);

        /// <summary>
        /// __m256 _mm256_blendv_ps (__m256 a, __m256 b, __m256 mask) VBLENDVPS ymm, ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vblend8x32(Vector256<float> x, Vector256<float> y, Vector256<float> spec)        
            => BlendVariable(x, y, spec);

        /// <summary>
        /// __m256 _mm256_blendv_ps (__m256 a, __m256 b, __m256 mask) VBLENDVPS ymm, ymm, ymm/m256, ymm
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vblend4x64(Vector256<double> x, Vector256<double> y, Vector256<double> spec)        
            => BlendVariable(x, y, spec);

 
    }
}