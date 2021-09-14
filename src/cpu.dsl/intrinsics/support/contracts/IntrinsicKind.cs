//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vdsl
{
    public enum IntrinsicKind : ushort
    {
        None,

        [Symbol("__m128i _mm_min_epi8(__m128i a, __m128i b)")]
        _mm_min_epi8,

        [Symbol("__m128i _mm_ternarylogic_epi32(__m128i a, __m128i b, __m128i c, int imm8)")]
        _mm_ternarylogic_epi32,

        [Symbol("__m128i _mm_avg_epu8(__m128i a, __m128i b)")]
        _mm_avg_epu8,

        _mm_blend_epi32,

        _mm_packus_epi16,

        _mm256_min_epu8,

        _mm256_cvtepi16_epi8,
    }
}