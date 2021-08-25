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
        public static uint render32x8(uint src, uint offset, Span<char> dst, char sep = Chars.Space)
        {
            var counter = 0u;
            var x = z8;

            var cells = bytes(src);
            x = skip(cells,0);
            counter += render8(x, counter + offset, dst);
            counter += separate(counter + offset, sep, dst);

            x = skip(cells,1);
            counter += render8(x, counter + offset, dst);
            counter += separate(counter + offset, sep, dst);

            x = skip(cells,2);
            counter += render8(x, counter + offset, dst);
            counter += separate(counter + offset, sep, dst);

            x = skip(cells,3);
            counter += render8(x, counter + offset, dst);

            return counter;
        }

        [MethodImpl(Inline), Op]
        public static uint render32x8(uint src, Span<char> dst, char sep = Chars.Space)
            => render32x8(src,0, dst, sep);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render32x8(uint src, char sep = Chars.Space)
        {
            var buffer = CharBlock64.Null.Data;
            var count = render32x8(src, 0, buffer, sep);
            return slice(buffer,0,count);
        }
    }
}