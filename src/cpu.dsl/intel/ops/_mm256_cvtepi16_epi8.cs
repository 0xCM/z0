//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vdsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Intrinsics
    {
        [MethodImpl(Inline)]
        public static byte Truncate8(ushort src)
            => (byte)src;

        /*
        # Intrinsic: __m128i _mm256_cvtepi16_epi8(__m256i a)
        # Classification: AVX-512, AVX512VL,AVX512BW, Convert
        # Instruction: VPMOVWB xmm, ymm
        # Iform: VPMOVWB_XMMu8_MASKmskw_YMMu16_AVX512
        # Description: Convert packed 16-bit integers in "a" to packed 8-bit integers with truncation, and store the results in "dst".
        __m128i _mm256_cvtepi16_epi8(__m256i a)
        {
            FOR j := 0 to 15
                i := 16*j
                l := 8*j
                dst[l+7:l] := Truncate8(a[i+15:i])
            ENDFOR
            dst[MAX:128] := 0
        }
        */
        public __m128i<byte> _mm256_cvtepi16_epi8(__m256i<ushort> a)
        {
            var dst = m128i<byte>();
            for(var j=0; j<=15; j++)
            {
                var i=16*j;
                var l=8*j;
                dst[l] = Truncate8(a[i]);
            }

            return default;
        }
    }
}