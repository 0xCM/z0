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
        [MethodImpl(Inline), Op]
        public static __m128i<uint> calc(in _mm_blend_epi32 src)
            => Specs._mm_blend_epi32(src.A, src.B, src.Imm8);

        public readonly struct _mm_blend_epi32 : IIntrinsicInput<_mm_blend_epi32>
        {
            public readonly __m128i<uint> A;

            public readonly __m128i<uint> B;

            public readonly Imm8 Imm8;

            [MethodImpl(Inline)]
            public _mm_blend_epi32(in __m128i<uint> a, in __m128i<uint> b, Imm8 imm8)
            {
                A = a;
                B = b;
                Imm8 = imm8;
            }

            public IntrinsicKind Kind
                => IntrinsicKind._mm_blend_epi32;
        }

        partial struct Specs
        {
            [MethodImpl(Inline)]
            public static __m128i<uint> _mm_blend_epi32(in __m128i<uint> a, in __m128i<uint> b, Imm8 imm8)
            {
                var dst = m128i<uint>();
                var i=0;
                for(var j=0; j<=3; j++)
                {
                    i = j*32;
                    if(imm8[i])
                        dst[i+31,i] = b[i+31,i];
                    else
                        dst[i+31,i] = a[i+31,i];
                }

                return dst;
            }
        }
    }
}