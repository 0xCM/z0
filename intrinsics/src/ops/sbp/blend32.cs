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
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vblend(Vector128<byte> x, Vector128<byte> y, Blend4x32 spec)        
            => v8u(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vblend(Vector128<sbyte> x, Vector128<sbyte> y, Blend4x32 spec)        
            => v8i(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vblend(Vector128<short> x, Vector128<short> y, Blend4x32 spec)        
            => v16i(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vblend(Vector128<ushort> x, Vector128<ushort> y, Blend4x32 spec)        
            => v16u(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vblend(Vector128<int> x, Vector128<int> y, Blend4x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vblend(Vector128<uint> x, Vector128<uint> y, Blend4x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vblend(Vector128<ulong> x, Vector128<ulong> y, Blend4x32 spec)        
            => v64u(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        /// __m128i _mm_blend_epi32 (__m128i a, __m128i b, const int imm8) VPBLENDD xmm, xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vblend(Vector128<long> x, Vector128<long> y, Blend4x32 spec)        
            => v64i(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        /// __m256 _mm256_blend_ps (__m256 a, __m256 b, const int imm8)VBLENDPS ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<float> vblend(Vector128<float> x, Vector128<float> y, Blend8x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vblend(Vector256<sbyte> x, Vector256<sbyte> y, Blend8x32 spec)        
            => v8i(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vblend(Vector256<byte> x, Vector256<byte> y, Blend8x32 spec)        
            => v8u(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vblend(Vector256<short> x, Vector256<short> y, Blend8x32 spec)        
            => v16i(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vblend(Vector256<ushort> x, Vector256<ushort> y, Blend8x32 spec)        
            => v16u(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vblend(Vector256<int> x, Vector256<int> y, Blend8x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm, ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vblend(Vector256<uint> x, Vector256<uint> y, Blend8x32 spec)        
            => Blend(x, y, (byte)spec);

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vblend(Vector256<long> x, Vector256<long> y, Blend8x32 spec)        
            => v64i(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8)VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vblend(Vector256<ulong> x, Vector256<ulong> y, Blend8x32 spec)        
            => v64u(Blend(v32u(x), v32u(y), (byte)spec));

        /// <summary>
        /// __m256 _mm256_blend_ps (__m256 a, __m256 b, const int imm8)VBLENDPS ymm, ymm, ymm/m256, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<float> vblend(Vector256<float> x, Vector256<float> y, Blend8x32 spec)        
            => Blend(x, y, (byte)spec);

 
    }
}