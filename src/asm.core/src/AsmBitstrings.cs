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

    public static partial class XTend
    {
        public static string FormatBitstring(this Hex32 src, N8 n)
        {
            Span<char> buffer = stackalloc char[64];
            var count = BitRender.render(src, n, 0,buffer);
            return new string(slice(buffer,0,count));
        }
    }

    [ApiHost]
    public readonly struct AsmBitstrings
    {
        public static AsmBitstrings service()
            => new AsmBitstrings();

        [MethodImpl(Inline), Op]
        public static uint render(AsmHexCode src, Span<char> dst)
        {
            var input = src.Bytes;
            var size = (int)src.Size;
            var length = min(size, dst.Length);
            var j = 0u;

            for(var i=0; i<length; i++)
                j += BitRender.render(skip(input, i), n4, j, dst);

            return j - 1;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(AsmHexCode src)
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

        public static string format(AsmHexCode src)
            => src.IsEmpty ? EmptyString : text.format(chars(src));

        public string Format(AsmHexCode src)
            => format(src);
    }
}