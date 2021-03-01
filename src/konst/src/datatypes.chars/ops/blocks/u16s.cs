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

    readonly partial struct CharBlocks
    {
        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock2 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock3 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock4 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock5 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock6 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock7 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock8 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock9 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock10 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock11 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock12 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock13 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock14 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock15 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock16 src)
            => span16u(src);

        [MethodImpl(Inline), Op]
        public static Span<ushort> u16s(in CharBlock32 src)
            => span16u(src);
    }
}