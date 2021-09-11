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
        public static uint render8(byte src, ref uint i, Span<char> dst)
        {
            var i0  = i;
            seek(dst, i++) = bitchar(src, 7);
            seek(dst, i++) = bitchar(src, 6);
            seek(dst, i++) = bitchar(src, 5);
            seek(dst, i++) = bitchar(src, 4);
            seek(dst, i++) = bitchar(src, 3);
            seek(dst, i++) = bitchar(src, 2);
            seek(dst, i++) = bitchar(src, 1);
            seek(dst, i++) = bitchar(src, 0);
            return i - i0;
        }

        [MethodImpl(Inline), Op]
        public static uint render8(byte src, uint offset, Span<char> dst)
        {
            seek(dst, offset++) = bitchar(src, 7);
            seek(dst, offset++) = bitchar(src, 6);
            seek(dst, offset++) = bitchar(src, 5);
            seek(dst, offset++) = bitchar(src, 4);
            seek(dst, offset++) = bitchar(src, 3);
            seek(dst, offset++) = bitchar(src, 2);
            seek(dst, offset++) = bitchar(src, 1);
            seek(dst, offset++) = bitchar(src, 0);
            return 8;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render8(byte src)
        {
            var buffer = CharBlock8.Null.Data;
            var i=0u;
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static uint render8(byte src, uint maxbits, uint j, Span<char> dst)
        {
            for(byte i=0; i<8; i++, j++)
            {
                if(j>=maxbits)
                    break;

                seek(dst, (uint)j) = bit.test(src, i).ToChar();
            }
            return j;
        }
    }
}