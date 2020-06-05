//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    readonly partial struct CharBlocks
    {
        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock2 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock3 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock4 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock5 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock6 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock7 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock8 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock9 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock10 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock11 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock12 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock13 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock14 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock15 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock16 src)
            => u8span(src);

        [MethodImpl(Inline), Op]
        public static Span<byte> u8s(in CharBlock32 src)
            => u8span(src);
    }
}