//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vdsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct Intel
    {
        /// <summary>
        /// __m128i _mm_blend_epi32(__m128i a, __m128i b, const int imm8)
        /// </summary>
        [MethodImpl(Inline)]
        public static __m128i<byte> _mm_avg_epu8(__m128i<byte> a, __m128i<byte> b)
            => cpu.vavg(a,b);

        partial struct Algs
        {
            [MethodImpl(Inline)]
            public static __m128i<byte> _mm_avg_epu8(__m128i<byte> a, __m128i<byte> b)
            {
                var dst = z128<byte>();
                var i = 0;
                for(var j=0; j<=15; j++)
                {
                    i = j*8;
                    dst[i + 7] = a[i+7] + b[i+7] + 1;
                }

                return dst;
            }
        }
    }
}