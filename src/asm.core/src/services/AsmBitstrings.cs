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

        [Op]
        public static AsmBitstring bitstring(AsmHexCode src)
            => new AsmBitstring(format(src));

        [Op]
        public static string format(AsmHexCode src, Span<char> buffer)
        {
            if(src.IsEmpty)
                return EmptyString;
            else
            {
                var count = render(src,buffer);
                var chars = slice(buffer,0,count);
                return text.format(chars);
            }
        }

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
        public static uint encode(N3 n, AsmHexCode src, uint offset, Span<BitChar> dst)
        {
            var input = src.Bytes;
            var size = (int)src.Size;
            var length = min(size, dst.Length);
            for(var i=0; i<length; i++)
                offset += BitRender.render(n8, n3, skip(input, i), offset, dst);
            return offset - 1;
        }

        [MethodImpl(Inline), Op]
        public static uint modrm(byte src, ref uint i, Span<BitChar> dst)
        {
            var i0 = i;
            seek(dst, i++) = bit.test(src, 7);
            seek(dst, i++) = bit.test(src, 6);
            seek(dst, i++) = BitChars.SegSep;
            seek(dst, i++) = bit.test(src, 5);
            seek(dst, i++) = bit.test(src, 4);
            seek(dst, i++) = bit.test(src, 3);
            seek(dst, i++) = BitChars.SegSep;
            seek(dst, i++) = bit.test(src, 2);
            seek(dst, i++) = bit.test(src, 1);
            seek(dst, i++) = bit.test(src, 0);
            seek(dst, i++) = BitChars.SegSep;
            return i - i0;
        }

        [MethodImpl(Inline), Op]
        public static uint encode(N3 n, AsmHexCode src, Span<BitChar> dst)
            => encode(n, src, 0u, dst);

        [MethodImpl(Inline), Op]
        public static uint encode(AsmHexCode src, uint offset, Span<BitChar> dst)
        {
            var input = src.Bytes;
            var size = (int)src.Size;
            var length = min(size, dst.Length);
            for(var i=0; i<length; i++)
                offset += BitRender.render(n8, w4, skip(input, i), offset, dst);
            return offset - 1;
        }

        [MethodImpl(Inline), Op]
        public static uint encode(AsmHexCode src, Span<BitChar> dst)
            => encode(src, 0u, dst);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<BitChar> bitchars(AsmHexCode src)
        {
            var dst = recover<BitChar>(ByteBlock128.Empty.Bytes);
            var size = encode(src, dst);
            return slice(dst,0,size);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<BitChar> bitchars(N3 n, AsmHexCode src)
        {
            var dst = recover<BitChar>(ByteBlock128.Empty.Bytes);
            var size = encode(n, src, dst);
            return slice(dst, 0, size);
        }

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<BitChar> src, Span<char> dst)
        {
            var count = src.Length;
            for(var i=0; i<count; i++)
                seek(dst,i) = skip(src,i);
            return (uint)count;
        }

        [Op]
        public static string format(ReadOnlySpan<BitChar> src, Span<char> buffer)
        {
            var count = render(src,buffer);
            return text.format(slice(buffer,0,count));
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