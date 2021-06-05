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
        public static uint render(N3 n, byte src, uint offset, Span<char> dst)
        {
            seek(dst, offset++) = bitchar(src, 2);
            seek(dst, offset++) = bitchar(src, 1);
            seek(dst, offset++) = bitchar(src, 0);
            return n;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N3 n, byte src, uint offset, Span<BitChar> dst)
        {
            var i=offset;
            seek(dst, i++) = bit.test(src, 2);
            seek(dst, i++) = bit.test(src, 1);
            seek(dst, i++) = bit.test(src, 0);
            return n;
        }
    }
}