//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Root;
    using static core;
    using static Typed;

    partial struct BitRender
    {
        public static Span<char> render(ReadOnlySpan<byte> src)
        {
            var dst = span<char>(src.Length*8);
            var input = span(src);
            render(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<byte> src, Span<char> dst)
            => render(src, (uint)dst.Length, dst);

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<byte> src, uint maxbits, Span<char> dst)
            => render(n8, n8, src, src.Length, maxbits, dst);

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<bit> src, Span<char> dst, uint offset)
        {
            var j = 0u;
            var k = min(src.Length + offset, dst.Length);
            for(uint i=offset; i<k; i++, j++)
                seek(dst,i) = skip(src,j).ToChar();
            return j;
        }
    }
}