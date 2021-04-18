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

    partial struct CharStacks
    {
        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack2 src)
            => cover(first(ref src), 2);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack4 src)
            => cover(first(ref src), 4);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack8 src)
            => cover(first(ref src), 8);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack16 src)
            => cover(first(ref src), 16);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack32 src)
            => cover(first(ref src), 32);

        [MethodImpl(Inline), Op]
        public static Span<char> span(ref CharStack64 src)
            => cover(first(ref src), 64);
    }
}