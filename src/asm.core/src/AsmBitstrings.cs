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
            var count = AsmBitstrings.render(src,n, 0,buffer);
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
                j += render(skip(input, i), j, dst);
            return j - 1;
        }

        [MethodImpl(Inline), Op]
        public static uint Render(ReadOnlySpan<byte> src, Span<char> dst)
        {
            var size = src.Length;
            var j = 0u;
            for(var i=0; i<size; i++)
                j += render(skip(src, i), j, dst);
            return j - 1;
        }

        [Op]
        public static uint render(Hex32 src, N8 n, uint j, Span<char> dst)
        {
            var x = Hex8.Zero;

            x = src.Hi.Hi;
            j += render(x, n8, j, dst);
            j += separate(j, dst);

            x = src.Hi.Lo;
            j += render(x, n8, j, dst);
            j += separate(j, dst);

            x = src.Lo.Hi;
            j += render(x, n8, j, dst);
            j += separate(j, dst);

            x = src.Lo.Lo;
            j += render(x, n8, j, dst);

            return j;
        }

        [MethodImpl(Inline), Op]
        static uint separate(uint j, Span<char> dst)
        {
            seek(dst,j) = Chars.Space;
            return 1;
        }

        [MethodImpl(Inline), Op]
        static uint render(Hex8 cell, N8 n8, uint j, Span<char> dst)
        {
            seek(dst, j++) = bit.bitchar(cell, 7);
            seek(dst, j++) = bit.bitchar(cell, 6);
            seek(dst, j++) = bit.bitchar(cell, 5);
            seek(dst, j++) = bit.bitchar(cell, 4);
            seek(dst, j++) = bit.bitchar(cell, 3);
            seek(dst, j++) = bit.bitchar(cell, 2);
            seek(dst, j++) = bit.bitchar(cell, 1);
            seek(dst, j++) = bit.bitchar(cell, 0);
            return 8;
        }

        [MethodImpl(Inline), Op]
        static uint render(byte cell, uint j, Span<char> dst)
        {
            seek(dst, j++) = bit.bitchar(cell, 7);
            seek(dst, j++) = bit.bitchar(cell, 6);
            seek(dst, j++) = bit.bitchar(cell, 5);
            seek(dst, j++) = bit.bitchar(cell, 4);
            seek(dst, j++) = Chars.Space;
            seek(dst, j++) = bit.bitchar(cell, 3);
            seek(dst, j++) = bit.bitchar(cell, 2);
            seek(dst, j++) = bit.bitchar(cell, 1);
            seek(dst, j++) = bit.bitchar(cell, 0);
            seek(dst, j++) = Chars.Space;
            return 10;
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