//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct CharBlocks
    {
        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock2 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock3 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock4 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock5 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock6 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock7 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock8 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock9 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock10 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock11 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock12 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock13 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock14 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock15 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock16 src)
            => span16c(src);

        [MethodImpl(Inline), Op]
        public static Span<char> span(in CharBlock32 src)
            => span16c(src);
    }
}