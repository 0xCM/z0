//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Hex
    {
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

        public static string format(ReadOnlySpan<HexDigit> src)
        {
            Span<char> dst = stackalloc char[src.Length];
            render(src,dst);
            return text.@string(dst);
        }

        public static string format(UpperCased @case, ReadOnlySpan<byte> src)
        {
            Span<char> digits = stackalloc char[src.Length*3];
            render(@case, src,digits);
            return text.@string(digits);
        }
    }
}