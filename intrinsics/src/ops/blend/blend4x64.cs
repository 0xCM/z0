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
        /// __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vblend(Vector256<sbyte> x, Vector256<sbyte> y, Blend4x64 spec)        
            => v8i(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vblend(Vector256<byte> x, Vector256<byte> y, Blend4x64 spec)        
            => v8u(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vblend(Vector256<short> x, Vector256<short> y, Blend4x64 spec)        
            => v16i(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vblend(Vector256<ushort> x, Vector256<ushort> y, Blend4x64 spec)        
            => v16u(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vblend(Vector256<int> x, Vector256<int> y, Blend4x64 spec)        
            => v32i(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m256d _mm256_blend_pd (__m256d a, __m256d b, const int imm8) VBLENDPD ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vblend(Vector256<uint> x, Vector256<uint> y, Blend4x64 spec)        
            => v32u(Blend(v64f(x), v64f(y), (byte)spec));

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