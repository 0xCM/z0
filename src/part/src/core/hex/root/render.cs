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
        [Op]
        public static uint render(ReadOnlySpan<byte> src, Span<char> dst, bool lower = true)
            => lower ? render(LowerCase,src,dst) : render(UpperCase, src,dst);

        /// <summary>
        /// Formats a span of hex digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline)]
        public static uint render<C>(C @case, ReadOnlySpan<HexDigit> src, Span<char> dst)
            where C : unmanaged, ILetterCase
        {
            var count = (uint)src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = (char)symbol(@case, skip(src,i));
            return count;
        }

        [MethodImpl(Inline)]
        public static uint render<C>(C @case, ReadOnlySpan<byte> src, Span<char> dst)
            where C : unmanaged, ILetterCase
        {
            var j=0u;
            var count = src.Length;
            for(var i=0u; i<count; i++, j+=3)
            {
                ref readonly var code = ref skip(src, i);
                seek(dst, j) = hexchar(@case, (byte)(code >> 4));
                seek(dst, j + 1) = hexchar(@case, (byte)(0xF & code));
                seek(dst, j + 2) = Chars.Space;
            }
            return j;
        }

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<HexCode> src, Span<char> dst)
        {
            var j=0u;
            var count = src.Length;
            for(var i=0u; i<count; i+=2, j+=3)
            {
                seek(dst, j) = (char)skip(src, i);
                seek(dst, j + 1) = (char)skip(src, i + 1);
                seek(dst, j + 2) = Chars.Space;
            }

            return j;
        }
    }
}