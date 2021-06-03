//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;

    [ApiHost]
    public readonly struct AsmBitstrings
    {
        [Op]
        public static string format(AsmHexCode src)
            => src.IsEmpty ? EmptyString : text.format(render(src));

        [MethodImpl(Inline), Op]
        public static uint render(AsmHexCode src, uint offset, Span<char> dst)
        {
            var input = src.Bytes;
            var size = (int)src.Size;
            var length = min(size, dst.Length);
            for(var i=0; i<length; i++)
                offset += BitRender.render(n8, n4, skip(input, i), offset, dst);
            return offset - 1;
        }

        [MethodImpl(Inline), Op]
        public static uint render(AsmHexCode src, Span<char> dst)
            => render(src, 0u, dst);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(AsmHexCode src)
        {
            if(src.IsEmpty)
                return default;

            CharBlocks.alloc(n256, out var block);
            var dst = block.Data;
            var count = render(src, dst);
            if(count == 0)
                return EmptyString;

            return slice(dst, 0, count);
        }
    }
}