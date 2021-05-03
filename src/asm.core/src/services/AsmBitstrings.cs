//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct AsmBitstrings
    {
        public static AsmBitstrings service()
            => new AsmBitstrings();

        [Op]
        public static uint render(AsmHexCode src, Span<char> dst)
        {
            var input = src.Bytes;
            var size = (int)src.Size;
            var j = 0u;
            for(var i=0; i<size; i++)
                j+= render(skip(input, i), j, dst);
            return j - 1;
        }

        [Op]
        public static uint Render(ReadOnlySpan<byte> src, Span<char> dst)
        {
            var size = src.Length;
            var j = 0u;
            for(var i=0; i<size; i++)
                j+= render(skip(src, i), j, dst);
            return j - 1;
        }

        [MethodImpl(Inline)]
        static uint render(byte cell, uint j, Span<char> dst)
        {
            seek(dst,j++) = bit.bitchar(cell,7);
            seek(dst,j++) = bit.bitchar(cell,6);
            seek(dst,j++) = bit.bitchar(cell,5);
            seek(dst,j++) = bit.bitchar(cell,4);
            seek(dst,j++) = Chars.Space;
            seek(dst,j++) = bit.bitchar(cell,3);
            seek(dst,j++) = bit.bitchar(cell,2);
            seek(dst,j++) = bit.bitchar(cell,1);
            seek(dst,j++) = bit.bitchar(cell,0);
            seek(dst,j++) = Chars.Space;
            return 10;
        }


        public string Format(AsmHexCode src)
        {
            CharBlocks.alloc(n128, out var block);
            var count = render(src, block.Data);
            var chars = slice(block.Data,0,count);
            return text.format(chars);
        }
    }
}