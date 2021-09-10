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
            public static __m256i<byte> _mm256_min_epu8(__m256i<byte> a, __m256i<byte> b)
            {
                var dst = m256i<byte>();
                for(var j=0; j<=31; j++)
                {
                    var i = j*8;
                    dst[i+7,i] = min(a[i+7,i], b[i+7,i]);
                }
                return dst;
            }
        }
    }
}