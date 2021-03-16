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
        public static Span<ushort> span16u(in CharBlock2 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock3 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock4 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock5 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock6 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock7 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock8 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock9 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock10 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock11 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock12 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock13 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock14 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock15 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock16 src)
            => memory.span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> span16u(in CharBlock32 src)
            => memory.span16u(src);
    }
}