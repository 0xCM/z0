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
        public static Span<ulong> u64s(in CharBlock4 src)
            => u64span(src);

        [MethodImpl(Inline), Op]
        public static Span<ulong> u64s(in CharBlock8 src)
            => u64span(src);

        [MethodImpl(Inline), Op]
        public static Span<ulong> u64s(in CharBlock12 src)
            => u64span(src);

        [MethodImpl(Inline), Op]
        public static Span<ulong> u64s(in CharBlock16 src)
            => u64span(src);

        [MethodImpl(Inline), Op]
        public static Span<ulong> u64s(in CharBlock32 src)
            => u64span(src);
    }
}