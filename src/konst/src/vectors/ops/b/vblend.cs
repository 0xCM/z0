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
    using static System.Runtime.Intrinsics.X86.Sse41;

    using static Konst;

    partial struct z
    {
        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8)PBLENDW xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vblend(Vector128<short> x, Vector128<short> y, [Imm] Blend8x16 spec)
            => vblend8x16(x, y, (byte)spec);

        /// <summary>
        /// __m128i _mm_blend_epi16 (__m128i a, __m128i b, const int imm8) PBLENDW xmm, xmm/m128, imm8
        /// Combines components from left/right vectors per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vblend(Vector128<ushort> x, Vector128<ushort> y, [Imm] Blend8x16 spec)
            => vblend8x16(x, y, (byte)spec);

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Combines components from left/right vectors within 128-bit lanes per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vblend(Vector256<short> x, Vector256<short> y, [Imm] Blend8x16 spec)
            => vblend8x16(x, y, (byte)spec);

        /// <summary>
        /// __m256i _mm256_blend_epi16 (__m256i a, __m256i b, const int imm8) VPBLENDW ymm, ymm, ymm/m256, imm8
        /// Combines components from left/right vectors within 128-bit lanes per the blend spec
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vblend(Vector256<ushort> x, Vector256<ushort> y, [Imm] Blend8x16 spec)
            => vblend8x16(x, y, (byte)spec);

        /// <summary>
        ///  __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm,ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vblend(Vector256<int> x, Vector256<int> y, [Imm] Blend8x32 spec)
            => Blend(x, y, (byte)spec);

        /// <summary>
        /// __m256i _mm256_blend_epi32 (__m256i a, __m256i b, const int imm8) VPBLENDD ymm, ymm, ymm/m256, imm8
        /// Forms a vector z[i] := testbit(spec,i) ? x[i] : y[i], i = 0,...7
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vblend(Vector256<uint> x, Vector256<uint> y, [Imm] Blend8x32 spec)
            => Blend(x, y, (byte)spec);


        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vblend2x64(Vector128<sbyte> x, Vector128<sbyte> y, [Imm] byte spec)
            => v8i(Blend(v64f(x), v64f(y), spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vblend2x64(Vector128<byte> x, Vector128<byte> y, [Imm] byte spec)
            => v8u(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vblend2x64(Vector128<ulong> x, Vector128<ulong> y, [Imm] byte spec)
            => v64u(Blend(v64f(x), v64f(y), spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vblend2x64(Vector128<short> x, Vector128<short> y, [Imm] byte spec)
            => v16i(Blend(v64f(x), v64f(y), (byte)spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vblend2x64(Vector128<ushort> x, Vector128<ushort> y, [Imm] byte spec)
            => v16u(Blend(v64f(x), v64f(y), spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vblend2x64(Vector128<int> x, Vector128<int> y, [Imm] byte spec)
            => v32i(Blend(v64f(x), v64f(y), spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vblend2x64(Vector128<uint> x, Vector128<uint> y, [Imm] byte spec)
            => v32u(Blend(v64f(x), v64f(y), spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vblend2x64(Vector128<long> x, Vector128<long> y, [Imm] byte spec)
            => v64i(Blend(v64f(x), v64f(y), spec));

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vblend(Vector128<sbyte> x, Vector128<sbyte> y, [Imm] Blend2x64 spec)
            => vblend2x64(x,y,(byte)spec);

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vblend(Vector128<byte> x, Vector128<byte> y, [Imm] Blend2x64 spec)
            => vblend2x64(x,y, (byte)spec);

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8)BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vblend(Vector128<short> x, Vector128<short> y, [Imm] Blend2x64 spec)
            => vblend2x64(x,y,(byte)spec);

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vblend(Vector128<ushort> x, Vector128<ushort> y, [Imm] Blend2x64 spec)
            => vblend2x64(x,y,(byte)spec);

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vblend(Vector128<int> x, Vector128<int> y, [Imm] Blend2x64 spec)
            => vblend2x64(x,y,(byte)spec);

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vblend(Vector128<uint> x, Vector128<uint> y, [Imm] Blend2x64 spec)
            => vblend2x64(x,y,(byte)spec);

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vblend(Vector128<long> x, Vector128<long> y, [Imm] Blend2x64 spec)
            => vblend2x64(x,y,(byte)spec);

        /// <summary>
        /// __m128d _mm_blend_pd (__m128d a, __m128d b, const int imm8) BLENDPD xmm, xmm/m128, imm8
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vblend(Vector128<ulong> x, Vector128<ulong> y, [Imm] Blend2x64 spec)
            => vblend2x64(x,y,(byte)spec);
    }
}