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
        public static Span<uint> u32s(in CharBlock2 src)
            => span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock4 src)
            => span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock6 src)
            => span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock8 src)
            => span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock10 src)
            => span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock12 src)
            => span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock14 src)
            => span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock16 src)
            => span32u(src);

        [MethodImpl(Inline), Op]
        public static Span<uint> u32s(in CharBlock32 src)
            => span32u(src);
    }
}