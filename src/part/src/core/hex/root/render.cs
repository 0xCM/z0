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

    partial struct Hex
    {
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

        /// <summary>
        /// Formats a span of hex digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline), Op]
        public static void render(ReadOnlySpan<HexDigit> src, Span<char> dst)
        {
            for(var i=0u; i < src.Length; i++)
                seek(dst,i) = (char)symbol(UpperCase, skip(src,i));
        }

        [MethodImpl(Inline), Op]
        public static int render(UpperCased @case, ReadOnlySpan<byte> src, Span<char> dst)
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
    }
}