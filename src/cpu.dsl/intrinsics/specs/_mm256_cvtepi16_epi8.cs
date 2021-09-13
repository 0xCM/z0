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
    using static BitFlow;

    partial struct Intrinsics
    {
        [MethodImpl(Inline), Op]
        public static __m128i<byte> calc(in _mm256_cvtepi16_epi8 src)
            => Specs._mm256_cvtepi16_epi8(src.A);

        public readonly struct _mm256_cvtepi16_epi8 : IIntrinsicInput<_mm256_cvtepi16_epi8>
        {
            public readonly __m256i<ushort> A;

            [MethodImpl(Inline)]
            public _mm256_cvtepi16_epi8(in __m256i<ushort> a)
            {
                A = a;
            }

            public IntrinsicKind Kind
                => IntrinsicKind._mm256_cvtepi16_epi8;
        }

        partial struct Specs
        {
            [MethodImpl(Inline)]
            public static __m128i<byte> _mm256_cvtepi16_epi8(__m256i<ushort> a)
            {
                var dst = m128i<byte>();
                for(var j=0; j<=15; j++)
                {
                    var i=16*j;
                    var l=8*j;
                    dst[l+7,l] = Truncate8(a[i+15,i]);
                }

                return dst;
            }
        }

        [MethodImpl(Inline)]
        public static byte Truncate8(ushort src)
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static uint _mm256_cvtepi16_epi8_loop(Span<v3<int>> dst)
        {
            var counter = 0u;
            for(var j=0; j<=15; j++)
            {
                var i=16*j;
                var l=8*j;
                seek(dst,j) = v(j, i, l);
                counter++;
            }
            return counter;
        }

        [MethodImpl(Inline), Op]
        public static uint _mm256_cvtepi16_epi8_seq(ReadOnlySpan<__m256i<ushort>> src, Span<__m128i<byte>> dst)
        {
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
                seek(dst,i) = Specs._mm256_cvtepi16_epi8(skip(src,i));
            return count;
        }
    }
}