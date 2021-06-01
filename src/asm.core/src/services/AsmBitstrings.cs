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
                j += render(skip(input, i), j, dst);

            return j - 1;
        }

        public string Format(AsmHexCode src)
            => format(src);

        [Op]
        public static string format(AsmHexCode src)
            => src.IsEmpty ? EmptyString : text.format(chars(src));

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<char> chars(AsmHexCode src)
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

        [MethodImpl(Inline), Op]
        static uint render(byte src, uint offset, Span<char> dst)
        {
            seek(dst, offset++) = bit.bitchar(src, 7);
            seek(dst, offset++) = bit.bitchar(src, 6);
            seek(dst, offset++) = bit.bitchar(src, 5);
            seek(dst, offset++) = bit.bitchar(src, 4);
            offset += separate(offset, dst);
            seek(dst, offset++) = bit.bitchar(src, 3);
            seek(dst, offset++) = bit.bitchar(src, 2);
            seek(dst, offset++) = bit.bitchar(src, 1);
            seek(dst, offset++) = bit.bitchar(src, 0);
            offset += separate(offset, dst);
            return 10;
        }

        [MethodImpl(Inline), Op]
        static uint separate(uint offset, Span<char> dst)
        {
            seek(dst,offset) = Chars.Space;
            return 1;
        }
    }
}