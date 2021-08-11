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
        public static uint render64x8(ulong src, Span<char> dst)
            => render64x8(src,0,dst);

        [MethodImpl(Inline), Op]
        public static uint render64x8(ulong src, uint offset, Span<char> dst)
        {
            var a = (uint)(src >> 32);
            var b = (uint)src;
            offset += render32x8(a,offset,dst);
            offset += render32x8(b,offset,dst);
            return offset;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render64x8(ulong src)
        {
            var buffer = CharBlock128.Null.Data;
            var count = render64x8(src, 0, buffer);
            return slice(buffer,0,count);
        }
    }
}