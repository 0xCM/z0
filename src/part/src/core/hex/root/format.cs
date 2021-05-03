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
        public static string format(ReadOnlySpan<byte> src, Span<char> buffer, bool lower = true)
            => lower ? format(LowerCase, src, buffer) : format(UpperCase, src, buffer);

        public static string format<C>(C @case, ReadOnlySpan<HexDigit> src)
            where C : unmanaged, ILetterCase
        {
            Span<char> buffer = stackalloc char[src.Length];
            return format(@case, src, buffer);
        }

        public static string format<C>(C @case, ReadOnlySpan<byte> src)
            where C : unmanaged, ILetterCase
        {
            Span<char> buffer = stackalloc char[src.Length*3];
            return format(@case, src, buffer);
        }

        [MethodImpl(Inline)]
        public static string format<C>(C @case, ReadOnlySpan<HexDigit> src, Span<char> buffer)
            where C : unmanaged, ILetterCase
        {
            var count = render(@case, src, buffer);
            return text.format(slice(buffer,0,count));
        }

        [MethodImpl(Inline)]
        public static string format<C>(C @case, ReadOnlySpan<byte> src, Span<char> buffer)
            where C : unmanaged, ILetterCase
        {
            var count = render(@case, src, buffer);
            return text.format(slice(buffer,0,count));
        }

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex1Seq> src, Hex1Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex2Seq> src,  Hex2Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex3Seq> src, Hex3Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex4Seq> src, Hex4Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(in HexString<Hex5Seq> src, Hex5Seq kind)
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex1Seq kind)
            => format(Hex.hexstring(n1), kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex2Seq kind)
            => format(Hex.hexstring(n2), kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex3Seq kind)
            => format(Hex.hexstring(n3), kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex4Seq kind)
            => format(Hex.hexstring(n4), kind);
    }
}