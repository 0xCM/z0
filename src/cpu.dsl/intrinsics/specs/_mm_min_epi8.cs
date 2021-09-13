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
        public static __m128i<sbyte> calc(in _mm_min_epi8 src)
            => Specs._mm_min_epi8(src.A, src.B);

        public readonly struct _mm_min_epi8 : IIntrinsicInput<_mm_min_epi8>
        {
            public readonly __m128i<sbyte> A;

            public readonly __m128i<sbyte> B;

            [MethodImpl(Inline)]
            public _mm_min_epi8(in __m128i<sbyte> a, in __m128i<sbyte> b)
            {
                A = a;
                B = b;
            }

            public IntrinsicKind Kind
                => IntrinsicKind._mm_min_epi8;
        }

        partial struct Specs
        {
            [MethodImpl(Inline)]
            public static __m128i<sbyte> _mm_min_epi8(in __m128i<sbyte> a, in __m128i<sbyte> b)
            {
                var dst = m128i<sbyte>();
                for(var j=0; j<=15; j++)
                {
                    var i = j*8;
                    dst[i+7,i] = min(a[i+7,i], b[i+7,i]);
                }
                return dst;
            }
        }
    }
}
