//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    readonly partial struct CharBlocks
    {
        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock2 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock3 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock4 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock5 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock6 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock7 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock8 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock9 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock10 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock11 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock12 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock13 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock14 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock15 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock16 src)
            => z.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock32 src)
            => z.span16u(src);
    }
}