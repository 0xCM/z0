//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Digital
    {
        /// <summary>
        /// Formats a span of binary digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline), Op]
        public static void render(ReadOnlySpan<BinaryDigit> src, Span<char> dst)
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) =  (char)Symbolic.symbol(skip(src,i));
        }

        /// <summary>
        /// Formats a span of hex digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline), Op]
        public static void render(ReadOnlySpan<DecimalDigit> src, Span<char> dst)
        {
            for(var i = 0u; i< src.Length; i++)
                seek(dst,i) = (char)Symbolic.symbol(skip(src,i));
        }

        /// <summary>
        /// Formats a span of hex digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline), Op]
        public static void render(ReadOnlySpan<HexDigit> src, Span<char> dst)
        {
            for(var i=0u; i < src.Length; i++)
                seek(dst,i) = (char)Symbolic.symbol(UpperCase, skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static void render(Base2 @base, ReadOnlySpan<byte> src, Span<char> dst)
        {
            var count = src.Length;
            var j = 0u;
            for(var i=0u; i<count; i++)
            {
                ref readonly var cell = ref skip(src,i);
                seek(dst, j++) = (char)Symbolic.symbol(@base, (byte)((0b00000001 & cell) >> 0));
                seek(dst, j++) = (char)Symbolic.symbol(@base, (byte)((0b00000010 & cell) >> 1));
                seek(dst, j++) = (char)Symbolic.symbol(@base, (byte)((0b00000100 & cell) >> 2));
                seek(dst, j++) = (char)Symbolic.symbol(@base, (byte)((0b00001000 & cell) >> 3));
                seek(dst, j++) = (char)Symbolic.symbol(@base, (byte)((0b00010000 & cell) >> 4));
                seek(dst, j++) = (char)Symbolic.symbol(@base, (byte)((0b00100000 & cell) >> 5));
                seek(dst, j++) = (char)Symbolic.symbol(@base, (byte)((0b01000000 & cell) >> 6));
                seek(dst, j++) = (char)Symbolic.symbol(@base, (byte)((0b10000000 & cell) >> 7));
            }
        }

        [MethodImpl(Inline), Op]
        public static int render(ReadOnlySpan<HexCode> src, Span<char> dst)
        {
            var j=0u;
            for(var i=0u; i<src.Length; i+=2, j+=3)
            {
                seek(dst, j) = (char)skip(src, i);
                seek(dst, j + 1) = (char)skip(src, i + 1);
                seek(dst, j + 2) = Chars.Space;
            }

            return (int)j;
        }

        [MethodImpl(Inline), Op]
        public static char hexchar(UpperCased @case, byte index)
            => (char)Symbolic.symbol(@case, (HexDigit)index);

        [MethodImpl(Inline), Op]
        public static int render(Base16 @base, UpperCased @case, ReadOnlySpan<byte> src, Span<char> dst)
        {
            var j=0u;
            for(var i=0u; i<src.Length; i++, j+=3)
            {
                ref readonly var code = ref skip(src, i);
                seek(dst, j) = hexchar(@case, (byte)(code >> 4));
                seek(dst, j + 1) = hexchar(@case, (byte)(0xF & code));
                seek(dst, j + 2) = Chars.Space;
            }
            return (int)j;
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> render(Base2 @base, ReadOnlySpan<byte> src)
        {
            Span<char> dst = new char[src.Length*8];
            render(@base, src, dst);
            return dst;
        }
    }
}