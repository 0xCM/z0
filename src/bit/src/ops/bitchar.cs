//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct bit
    {
        /// <summary>
        /// Tests the state of an index-identified source bit and returns the corresponding '0' or '1' character
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static char bitchar(sbyte src, byte pos)
            => bit.test(src, pos).ToChar();

        /// <summary>
        /// Tests the state of an index-identified source bit and returns the corresponding '0' or '1' character
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static char bitchar(byte src, byte pos)
            => bit.test(src, pos).ToChar();

        [MethodImpl(Inline), Op]
        public static byte bitchars(byte src, byte offset, out char hi, out char lo)
        {
            hi = bitchar(src, offset);
            lo =bitchar(src, Bytes.sub(offset, 1));
            return 2;
        }
        public static Span<char> bitchars(ReadOnlySpan<byte> src)
        {
            var dst = span<char>(src.Length*8);
            var input = span(src);
            bit.render(src, dst);
            return dst;
        }

        /// <summary>
        /// Tests the state of an index-identified source bit and returns the corresponding '0' or '1' character
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static char bitchar(short src, byte pos)
            => bit.test(src, pos).ToChar();

        /// <summary>
        /// Tests the state of an index-identified source bit and returns the corresponding '0' or '1' character
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static char bitchar(ushort src, byte pos)
            => bit.test(src, pos).ToChar();

        /// <summary>
        /// Tests the state of an index-identified source bit and returns the corresponding '0' or '1' character
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static char bitchar(int src, byte pos)
            => bit.test(src, pos).ToChar();

        /// <summary>
        /// Tests the state of an index-identified source bit and returns the corresponding '0' or '1' character
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static char bitchar(uint src, byte pos)
            => bit.test(src, pos).ToChar();

        /// <summary>
        /// Tests the state of an index-identified source bit and returns the corresponding '0' or '1' character
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static char bitchar(long src, byte pos)
            => bit.test(src, pos).ToChar();

        /// <summary>
        /// Tests the state of an index-identified source bit and returns the corresponding '0' or '1' character
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="pos">The 0-based index of the bit to test</param>
        [MethodImpl(Inline), Op]
        public static char bitchar(ulong src, byte pos)
            => bit.test(src, pos).ToChar();
    }
}