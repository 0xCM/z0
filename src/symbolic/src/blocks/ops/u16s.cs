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
        public static Span<ushort> u16s(in CharBlock2 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock3 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock4 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock5 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock6 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock7 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock8 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock9 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock10 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock11 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock12 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock13 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock14 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock15 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock16 src)
            => u16span(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock32 src)
            => u16span(src);
    }
}