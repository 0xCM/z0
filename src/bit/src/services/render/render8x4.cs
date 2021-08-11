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
        public static ReadOnlySpan<char> render8x4(byte src)
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
        public static uint render8x4(byte src, uint offset, Span<char> dst)
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
            return 8 + 2u;
        }

        [MethodImpl(Inline), Op]
        public static uint render8x4(byte src, uint offset, Span<AsciCode> dst)
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
            return 8 + 2u;
        }

        [MethodImpl(Inline), Op]
        public static uint render8x4(byte src, uint offset, Span<BitChar> dst)
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
            return 8 + 2u;
        }

        [MethodImpl(Inline), Op]
        public static uint render4x4(ReadOnlySpan<byte> src, Span<char> dst)
        {
            var size = src.Length;
            var j = 0u;
            var w = w4;
            for(var i=size-1; i >= 0; i--)
            {
                ref readonly var input = ref skip(src,i);
                render4(hi(input), ref j, dst);
                j+= separate(j, dst);
                render4(lo(input), ref j, dst);
                if(i != 0)
                    j += separate(j, dst);
            }
            return j - 1;
        }
    }
}