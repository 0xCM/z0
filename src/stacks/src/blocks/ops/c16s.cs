//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    readonly partial struct CharBlocks
    {
        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock2 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock3 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock4 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock5 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock6 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock7 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock8 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock9 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock10 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock11 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock12 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock13 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock14 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock15 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock16 src)
            => c16span(src);

        [MethodImpl(Inline), Op]
        public static Span<char> c16s(in CharBlock32 src)
            => c16span(src);
    }
}