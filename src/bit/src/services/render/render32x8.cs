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
        public static uint render32x8(uint src, uint offset, Span<char> dst)
        {
            var counter = 0u;
            var x = z8;

            var cells = bytes(src);
            x = skip(cells,0);
            counter += render8(x, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = skip(cells,1);
            counter += render8(x, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = skip(cells,2);
            counter += render8(x, counter + offset, dst);
            counter += separate(counter + offset, dst);

            x = skip(cells,3);
            counter += render8(x, counter + offset, dst);

            return counter;
        }

        [MethodImpl(Inline), Op]
        public static uint render32x8(uint src, Span<char> dst)
            => render32x8(src,0,dst);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render32x8(uint src)
        {
            var buffer = CharBlock64.Null.Data;
            var count = render32x8(src, 0, buffer);
            return slice(buffer,0,count);
        }
    }
}