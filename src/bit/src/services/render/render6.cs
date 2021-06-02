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
    }
}