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
        public static __m128i<byte> calc(in _mm_packus_epi16 io)
            => Specs._mm_packus_epi16(io.A, io.B);

        public struct _mm_packus_epi16
        {
            public __m128i<short> A;

            public __m128i<short> B;

            [MethodImpl(Inline)]
            public _mm_packus_epi16(in __m128i<short> a, in __m128i<short> b)
            {
                A = a;
                B = b;
            }

            public IntrinsicKind Kind
                => IntrinsicKind._mm_packus_epi16;
        }

        partial struct Specs
        {
            [MethodImpl(Inline)]
            public static byte SaturateU8(short src)
                => src < 0 ? z8 : (byte)(src < 0xFF ? src : 0xFF);

            [MethodImpl(Inline)]
            public static __m128i<byte> _mm_packus_epi16(in __m128i<short> a, in __m128i<short> b)
            {
                var dst = m128i<byte>();
                dst[7,0] = SaturateU8(a[15,0]);
                dst[15,8] = SaturateU8(a[31,16]);
                dst[23,16] = SaturateU8(a[47,32]);
                dst[31,24] = SaturateU8(a[63,48]);
                dst[39,32] = SaturateU8(a[79,64]);
                dst[47,40] = SaturateU8(a[95,80]);
                dst[55,48] = SaturateU8(a[111,96]);
                dst[63,56] = SaturateU8(a[127,112]);
                dst[71,64] = SaturateU8(b[15,0]);
                dst[79,72] = SaturateU8(b[31,16]);
                dst[87,80] = SaturateU8(b[47,32]);
                dst[95,88] = SaturateU8(b[63,48]);
                dst[103,96] = SaturateU8(b[79,64]);
                dst[111,104] = SaturateU8(b[95,80]);
                dst[119,112] = SaturateU8(b[111,96]);
                dst[127,120] = SaturateU8(b[127,112]);
                return dst;
            }
        }
    }
}