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
        [MethodImpl(Inline), Op]
        public static __m256i<byte> calc(in _mm256_min_epu8 src)
            => Specs._mm256_min_epu8(src.A, src.B);

        public readonly struct _mm256_min_epu8 : IIntrinsicInput<_mm256_min_epu8>
        {
            public readonly __m256i<byte> A;

            public readonly __m256i<byte> B;

            [MethodImpl(Inline)]
            public _mm256_min_epu8(in __m256i<byte> a, in __m256i<byte> b)
            {
                A = a;
                B = b;
            }

            public IntrinsicKind Kind
                => IntrinsicKind._mm256_min_epu8;
        }

        partial struct Specs
        {
            [MethodImpl(Inline)]
            public static __m256i<byte> _mm256_min_epu8(in __m256i<byte> a, in __m256i<byte> b)
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