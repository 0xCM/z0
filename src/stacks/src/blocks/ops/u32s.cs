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
        public static Span<uint> u32s(in CharBlock2 src)
            => u32span(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock4 src)
            => u32span(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock6 src)
            => u32span(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock8 src)
            => u32span(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock10 src)
            => u32span(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock12 src)
            => u32span(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock14 src)
            => u32span(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock16 src)
            => u32span(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock32 src)
            => u32span(src);
    }
}