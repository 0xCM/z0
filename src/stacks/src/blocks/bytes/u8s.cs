//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    readonly partial struct ByteBlocks
    {
        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock2 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock3 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock4 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock5 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock6 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock7 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock8 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock9 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock10 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock11 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock12 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock13 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock14 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock15 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock16 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock32 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in ByteBlock64 src)
            => u8span(src);
    }
}