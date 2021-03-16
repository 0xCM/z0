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
        public static Span<uint> span32u(in CharBlock2 src)
            => memory.span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> span32u(in CharBlock4 src)
            => memory.span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> span32u(in CharBlock6 src)
            => memory.span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> span32u(in CharBlock8 src)
            => memory.span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> span32u(in CharBlock10 src)
            => memory.span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> span32u(in CharBlock12 src)
            => memory.span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> span32u(in CharBlock14 src)
            => memory.span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> span32u(in CharBlock16 src)
            => memory.span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> span32u(in CharBlock32 src)
            => memory.span32u(src);
    }
}