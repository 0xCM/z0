//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct BitRender
    {
        [MethodImpl(Inline), Op]
        public static uint render(N8 n, N3 w, byte src, uint offset, Span<char> dst)
        {
            var i= offset;
            seek(dst, i++) = bitchar(src, 7);
            seek(dst, i++) = bitchar(src, 6);
            seek(dst, i++) = bitchar(src, 5);
            separate(i++, dst);
            seek(dst, i++) = bitchar(src, 4);
            seek(dst, i++) = bitchar(src, 3);
            seek(dst, i++) = bitchar(src, 2);
            separate(i++, dst);
            seek(dst, i++) = bitchar(src, 1);
            seek(dst, i++) = bitchar(src, 0);
            separate(i++, dst);
            return n + 3u;
        }


        [MethodImpl(Inline), Op]
        public static uint render(N8 n, N3 w, byte src, uint offset, Span<AsciCode> dst)
        {
            var i= offset;
            seek(dst, i++) = code(src, 7);
            seek(dst, i++) = code(src, 6);
            seek(dst, i++) = code(src, 5);
            separate(i++, dst);
            seek(dst, i++) = code(src, 4);
            seek(dst, i++) = code(src, 3);
            seek(dst, i++) = code(src, 2);
            separate(i++, dst);
            seek(dst, i++) = code(src, 1);
            seek(dst, i++) = code(src, 0);
            separate(i++, dst);
            return n + 3u;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N8 n, N3 w, byte src, uint offset, Span<BitChar> dst)
        {
            var i= offset;
            seek(dst, i++) = bit.test(src, 7);
            seek(dst, i++) = bit.test(src, 6);
            seek(dst, i++) = bit.test(src, 5);
            seek(dst, i++) = BitChars.SegSep;
            seek(dst, i++) = bit.test(src, 4);
            seek(dst, i++) = bit.test(src, 3);
            seek(dst, i++) = bit.test(src, 2);
            seek(dst, i++) = BitChars.SegSep;
            seek(dst, i++) = bit.test(src, 1);
            seek(dst, i++) = bit.test(src, 0);
            seek(dst, i++) = BitChars.SegSep;
            return n + 3u;
        }
    }
}