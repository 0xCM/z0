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
    using static Typed;

    partial struct BitRender
    {
        [MethodImpl(Inline), Op]
        public static uint render(N16 n, ushort src, uint maxbits, uint j, Span<char> dst)
        {
            var count = 16;
            for(byte i=0; i<count; i++, j++)
            {
                if(j>=maxbits)
                    break;

                seek(dst, (uint)j) = bit.test(src, i).ToChar();
            }
            return j;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N16 n, ReadOnlySpan<ushort> src, int count, uint maxbits, Span<char> dst)
        {
            var k=0u;
            for(var i=0u; i<count; i++)
            {
                k += render(n, skip(src,i), maxbits, k, dst);
                if(k >= maxbits)
                    break;
            }
            return k;
        }

        [MethodImpl(Inline), Op]
        public static uint render(N16 n, ReadOnlySpan<ushort> src, uint maxbits, Span<char> dst)
            => render(n16, src, src.Length, maxbits, dst);
    }
}