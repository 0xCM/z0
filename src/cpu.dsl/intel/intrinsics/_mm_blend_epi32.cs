//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vdsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;
    using static Xed;

    partial struct Intel
    {
        /// <summary>
        /// __m128i _mm_blend_epi32(__m128i a, __m128i b, const int imm8)
        /// </summary>
        [MethodImpl(Inline), AsmOp(IForm.VPBLENDD_XMMdq_XMMdq_XMMdq_IMMb)]
        public static __m128i<uint> _mm_blend_epi32(__m128i<uint> a, __m128i<uint> b, [Imm] byte imm8)
            => cpu.vblend4x32(a,b, imm8);

        partial struct Algs
        {
            [AsmAlg(IForm.VPBLENDD_XMMdq_XMMdq_XMMdq_IMMb)]
            public static __m128i<uint> _mm_blend_epi32(__m128i<uint> a, __m128i<uint> b, Imm8 imm8)
            {
                var dst = default(__m128i<uint>);
                var i=0;
                for(var j=0; j<4; j++)
                {
                    i = j*16;
                    if(imm8[i])
                        dst[i] = b[i];
                    else
                        dst[i] = a[i];
                }

                return dst;
            }
        }
    }
}