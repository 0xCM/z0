//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static BitNumbers;
    using static memory;

    /// <summary>
    /// Defines operations over character digits
    /// </summary>
    partial struct Digital
    {
        [MethodImpl(Inline), Op]
        public static void chars(Base10 @base, ushort src, out char c1, out char c0)
        {
            c1 = (char)symbol(digit(@base, src, Bit1));
            c0 = (char)symbol(digit(@base, src, Bit0));
        }

        [MethodImpl(Inline), Op]
        public static void chars(Base10 @base, uint src, out char c3, out char c2, out char c1, out char c0)
        {
            c3 = (char)symbol(digit(@base, src, Bit3));
            c2 = (char)symbol(digit(@base, src, Bit2));
            c1 = (char)symbol(digit(@base, src, Bit1));
            c0 = (char)symbol(digit(@base, src, Bit0));
        }

        [MethodImpl(Inline), Op]
        public static void chars(Base10 @base, ulong src, out char c7, out char c6, out char c5, out char c4, out char c3, out char c2, out char c1, out char c0)
        {
            c7 = (char)symbol(digit(@base, src, Bit7));
            c6 = (char)symbol(digit(@base, src, Bit6));
            c5 = (char)symbol(digit(@base, src, Bit5));
            c4 = (char)symbol(digit(@base, src, Bit4));
            c3 = (char)symbol(digit(@base, src, Bit3));
            c2 = (char)symbol(digit(@base, src, Bit2));
            c1 = (char)symbol(digit(@base, src, Bit1));
            c0 = (char)symbol(digit(@base, src, Bit0));
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Base10 @base, uint src)
        {
            var store = z64;
            var proxy = z16c;
            ref var dst = ref @as(store, ref proxy);
            chars(@base, src,
                out add(dst, 3), out add(dst, 2), out add(dst, 1), out add(dst, 0)
                );
            return cover(dst, 4);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Base10 @base, ulong src)
        {
            var store = z128f;
            var proxy = z16c;
            ref var dst = ref @as(store, ref proxy);
            chars(@base, src,
                out add(dst, 7), out add(dst, 6), out add(dst, 5), out add(dst, 4),
                out add(dst, 3), out add(dst, 2), out add(dst, 1), out add(dst, 0)
                );
            return cover(dst, 4);
        }

        [MethodImpl(Inline), Op]
        public static void chars(ushort src, out char c1, out char c0)
            => chars(base10, src, out c1, out c0);

        [MethodImpl(Inline), Op]
        public static void chars(uint src, out char c3, out char c2, out char c1, out char c0)
            => chars(base10, src, out c3, out c2, out c1, out c0);

        [MethodImpl(Inline), Op]
        public static void chars(ulong src, out char c7, out char c6, out char c5, out char c4, out char c3, out char c2, out char c1, out char c0)
            => chars(base10, src, out c7, out c6, out c5, out c4, out c3, out c2, out c1, out c0);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(uint src)
            => chars(base10, src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(ulong src)
            => chars(base10, src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexString<Hex1Seq> src, Hex1Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexString<Hex2Seq> src, Hex2Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexString<Hex3Seq> src, Hex3Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexString<Hex4Seq> src, Hex4Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex1Seq src)
            => chars(Hex.text(n1), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex2Seq src)
            => chars(Hex.text(n2), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex3Seq src)
            => chars(Hex.text(n3), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex4Seq src)
            => chars(Hex.text(n4), src);
    }
}