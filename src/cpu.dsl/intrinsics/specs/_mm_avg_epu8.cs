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

    partial struct Intrinsics
    {
        partial struct Specs
        {
            [MethodImpl(Inline)]
            public static __m128i<byte> _mm_avg_epu8(__m128i<byte> a, __m128i<byte> b)
            {
                var dst = m128i<byte>();
                var i = 0;
                for(var j=0; j<=15; j++)
                {
                    i = j*8;
                    dst[i + 7,i] = (byte)((a[i+7,i] + b[i+7,i]) >> 1);
                }

                return dst;
            }
        }
    }
}