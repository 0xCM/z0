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
        partial struct Specs
        {
            [MethodImpl(Inline)]
            public static __m128i<uint> _mm_blend_epi32(__m128i<uint> a, __m128i<uint> b, Imm8 imm8)
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