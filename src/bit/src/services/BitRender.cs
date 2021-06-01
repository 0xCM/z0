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

    [ApiHost]
    public readonly partial struct BitRender
    {
        [MethodImpl(Inline), Op]
        public static uint render(N2 n, byte src, uint offset, Span<char> dst)
        {
            seek(dst, offset++) = bitchar(src, 1);
            seek(dst, offset++) = bitchar(src, 0);
            return n;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N6 n, byte src, uint offset, Span<char> dst)
        {
            seek(dst, offset++) = bitchar(src, 5);
            seek(dst, offset++) = bitchar(src, 4);
            seek(dst, offset++) = bitchar(src, 3);
            seek(dst, offset++) = bitchar(src, 2);
            seek(dst, offset++) = bitchar(src, 1);
            seek(dst, offset++) = bitchar(src, 0);
            return n;
        }

        [Op]
        public static string format(N32 n, N8 w, uint src)
        {
            var buffer = CharBlock64.Null.Data;
            var count = render(n, w, src, 0, buffer);
            return new string(slice(buffer,0,count));
        }

        [MethodImpl(Inline), Op]
        static uint separate(uint offset, Span<char> dst)
        {
            seek(dst,offset) = Chars.Space;
            return 1;
        }
    }
}