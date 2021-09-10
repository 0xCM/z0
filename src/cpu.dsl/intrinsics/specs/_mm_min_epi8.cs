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
        public static void calc(ref _mm_min_epi8 io)
            => io.Dst = Specs._mm_min_epi8(io.A, io.B);

        public struct _mm_min_epi8
        {
            public __m128i<sbyte> A;

            public __m128i<sbyte> B;

            public __m128i<sbyte> Dst;

            [MethodImpl(Inline)]
            public _mm_min_epi8(__m128i<sbyte> a, __m128i<sbyte> b)
            {
                A = a;
                B = b;
                Dst = default;
            }

            public string Op => nameof(_mm_min_epi8);
        }

        partial struct Specs
        {
            [MethodImpl(Inline)]
            public static __m128i<sbyte> _mm_min_epi8(__m128i<sbyte> a, __m128i<sbyte> b)
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
