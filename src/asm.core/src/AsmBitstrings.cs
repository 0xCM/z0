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
            var count = HexVector.bitrender(src,n, 0,buffer);
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
            var j = 0u;
            for(var i=0; i<size; i++)
                j += HexVector.bitrender(skip(input, i), n4, j, dst);
            return j - 1;
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(AsmHexCode src)
        {
            CharBlocks.alloc(n128, out var block);
            var count = render(src, block.Data);
            return slice(block.Data, 0, count);
        }

        public string Format(AsmHexCode src)
            => text.format(chars(src));
    }
}