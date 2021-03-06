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
    using static bit;

    partial struct BitRender
    {
        public static ReadOnlySpan<char> render(N8 n, N4 w, byte src)
        {
            var dst = CharBlock16.Null.Data;
            var i = 0u;
            seek(dst, i++) = bitchar(src, 7);
            seek(dst, i++) = bitchar(src, 6);
            seek(dst, i++) = bitchar(src, 5);
            seek(dst, i++) = bitchar(src, 4);
            i += separate(i, dst);
            seek(dst, i++) = bitchar(src, 3);
            seek(dst, i++) = bitchar(src, 2);
            seek(dst, i++) = bitchar(src, 1);
            seek(dst, i++) = bitchar(src, 0);
            return slice(dst, 0, i);
        }

        [MethodImpl(Inline), Op]
        public static uint render(N8 n, N4 w, byte src, uint offset, Span<char> dst)
        {
            var i=offset;
            seek(dst, i++) = bitchar(src, 7);
            seek(dst, i++) = bitchar(src, 6);
            seek(dst, i++) = bitchar(src, 5);
            seek(dst, i++) = bitchar(src, 4);
            i += separate(i, dst);
            seek(dst, i++) = bitchar(src, 3);
            seek(dst, i++) = bitchar(src, 2);
            seek(dst, i++) = bitchar(src, 1);
            seek(dst, i++) = bitchar(src, 0);
            i += separate(i, dst);
            return n + 2u;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N8 n, N4 w, byte src, uint offset, Span<AsciCode> dst)
        {
            var i=offset;
            seek(dst, i++) = code(src, 7);
            seek(dst, i++) = code(src, 6);
            seek(dst, i++) = code(src, 5);
            seek(dst, i++) = code(src, 4);
            i += separate(i, dst);
            seek(dst, i++) = code(src, 3);
            seek(dst, i++) = code(src, 2);
            seek(dst, i++) = code(src, 1);
            seek(dst, i++) = code(src, 0);
            i += separate(i, dst);
            return n + 2u;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N8 n, N4 w, byte src, uint offset, Span<BitChar> dst)
        {
            var i=offset;
            seek(dst, i++) = bit.test(src, 7);
            seek(dst, i++) = bit.test(src, 6);
            seek(dst, i++) = bit.test(src, 5);
            seek(dst, i++) = bit.test(src, 4);
            seek(dst, i++) = BitChars.SegSep;
            seek(dst, i++) = bit.test(src, 3);
            seek(dst, i++) = bit.test(src, 2);
            seek(dst, i++) = bit.test(src, 1);
            seek(dst, i++) = bit.test(src, 0);
            seek(dst, i++) = BitChars.SegSep;
            return n + 2u;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N4 w, ReadOnlySpan<byte> src, Span<char> dst)
        {
            var size = src.Length;
            var j = 0u;

            for(var i=size-1; i >= 0; i--)
            {
                ref readonly var input = ref skip(src,i);
                render(w, hi(input), ref j, dst);
                j+= separate(j, dst);
                render(w, lo(input), ref j, dst);
                if(i != 0)
                    j += separate(j, dst);
            }
            return j - 1;
        }
    }
}