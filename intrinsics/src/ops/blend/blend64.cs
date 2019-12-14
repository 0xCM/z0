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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
        
    using static zfunc;

    partial class dinx
    {
        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<double> vblend(Vector128<double> x, Vector128<double> y, Blend2x64 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vblend(Vector128<long> x, Vector128<long> y, Blend2x64 spec)        
            => v64i(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vblend(Vector128<ulong> x, Vector128<ulong> y, Blend2x64 spec)        
            => v64u(Blend(v64f(x), v64f(y), (byte)spec));

        [MethodImpl(Inline)]
        public static Vector128<ulong> vblend(Vector128<ulong> x, Vector128<ulong> y, byte spec)        
            => v64u(Blend(v64f(x), v64f(y), spec));

        /// <summary>
        /// __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vblend(Vector256<long> x, Vector256<long> y, Blend4x64 spec)        
            => v64i(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vblend(Vector256<ulong> x, Vector256<ulong> y, Blend4x64 spec)        
            => v64u(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<double> vblend(Vector256<double> x, Vector256<double> y, Blend4x64 spec)        
            => Blend(x, y, (byte)spec);

    }

}