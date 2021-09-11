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
        public static Span<char> render8x8(ReadOnlySpan<byte> src)
        {
            var dst = span<char>(src.Length*8);
            var input = span(src);
            render8x8(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static uint render8x8(ReadOnlySpan<byte> src, Span<char> dst)
            => render8x8(src, (uint)dst.Length, dst);

        [MethodImpl(Inline), Op]
        public static uint render8x8(ReadOnlySpan<byte> src, uint maxbits, Span<char> dst)
            => render8x8(src, src.Length, maxbits, dst);

        public static uint render8x8<N>(ReadOnlySpan<byte> src, uint offset, Span<char> dst)
            where N : unmanaged, ITypeNat
        {
            var counter = 0u;
            var count = (int)value<N>();
            seek(dst, counter + offset) = Chars.Lt;
            counter++;
            for(var i=0; i<count; i++)
            {
                ref readonly var cell = ref src[i];
                if(i != 0)
                    counter += separate(counter + offset, dst);

                counter += render8(cell, counter + offset, dst);
            }
            seek(dst, counter + offset) = Chars.Gt;
            counter++;
            return counter;
        }

        [MethodImpl(Inline), Op]
        public static uint render8x8(ReadOnlySpan<byte> src, int count, uint maxbits, Span<char> dst)
        {
            var k=0u;
            for(var i=0u; i<count; i++)
            {
                k += render8(skip(src,i), maxbits, k, dst);
                if(k >= maxbits)
                    break;
            }
            return k;
        }
    }
}