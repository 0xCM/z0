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
        public static uint render(AsmHexCode src, Span<char> dst)
            => render(src, 0u, dst);

        public static string literal(Cell256 src, byte max = byte.MaxValue)
            => text.format(render(src, max));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(Cell256 src, byte max)
        {
            if(src.IsEmpty)
                return default;

            CharBlocks.alloc(n256, out var block);
            var dst = block.Data;
            var count = literal(src, max, dst);
            if(count == 0)
                return EmptyString;

            return slice(dst, 0, count);
        }

        [MethodImpl(Inline), Op]
        public static uint literal(Cell256 src, byte count, Span<char> dst)
            => literal(src, 0u, count, dst);

        [MethodImpl(Inline), Op]
        public static uint literal(Cell256 src, uint offset, byte count, Span<char> dst)
        {
            var counter = 0u;
            var input = src.Bytes;
            var size = (int)src.Size;
            for(var i=0; i<count; i++)
            {
                ref readonly var b = ref skip(input,i);
                if(b == 0)
                    break;

                seek(dst, counter++) = (char)b;
            }

            return counter;
        }

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

        [MethodImpl(Inline), Op]
        public static byte store(ReadOnlySpan<char> src, out Cell256 dst)
        {
            dst = default;
            var counter = 0u;
            var storage = dst.Bytes;
            var count = min(src.Length, storage.Length);
            for(var i=0; i<count; i++)
            {
                ref readonly var c = ref skip(src,i);
                if(c==0)
                    break;

                seek(storage, counter++) = (byte)c;
            }

            return (byte)counter;
        }

        [MethodImpl(Inline), Op]
        public static uint render(AsmHexCode src, uint offset, Span<char> dst)
        {
            var input = src.Bytes;
            var size = (int)src.Size;
            var length = min(size, dst.Length);
            for(var i=0; i<length; i++)
                offset += render(skip(input, i), offset, dst);
            return offset - 1;
        }

        [MethodImpl(Inline), Op]
        static uint render(byte src, uint offset, Span<char> dst)
            => BitRender.render(n8, n4, src, offset, dst);
        // {
        //     seek(dst, offset++) = BitRender.bitchar(src, 7);
        //     seek(dst, offset++) = BitRender.bitchar(src, 6);
        //     seek(dst, offset++) = BitRender.bitchar(src, 5);
        //     seek(dst, offset++) = BitRender.bitchar(src, 4);
        //     offset += separate(offset, dst);
        //     seek(dst, offset++) = BitRender.bitchar(src, 3);
        //     seek(dst, offset++) = BitRender.bitchar(src, 2);
        //     seek(dst, offset++) = BitRender.bitchar(src, 1);
        //     seek(dst, offset++) = BitRender.bitchar(src, 0);
        //     offset += separate(offset, dst);
        //     return 10;
        // }

        [MethodImpl(Inline), Op]
        static uint separate(uint offset, Span<char> dst)
        {
            seek(dst,offset) = Chars.Space;
            return 1;
        }
    }
}