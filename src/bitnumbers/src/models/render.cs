//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static Typed;

    using C = AsciCharCode;

    partial struct BitNumbers
    {
        [MethodImpl(Inline), Op]
        public static uint render(uint1 src, ref uint i, Span<C> dst)
        {
            var i0 = i;
            seek(dst,i++) = (src ? bit.On : bit.Off).ToCharCode();
            return i - i0;
        }

        [MethodImpl(Inline), Op]
        public static uint render(uint2 src, ref uint i, Span<C> dst)
            => BitRender.render(n2, src, ref i, dst);

        [MethodImpl(Inline), Op]
        public static uint render(uint3 src, ref uint i, Span<C> dst)
            => BitRender.render(n3, src, ref i, dst);

        [MethodImpl(Inline), Op]
        public static uint render(uint4 src, ref uint i, Span<C> dst)
            => BitRender.render(n4, src, ref i, dst);

        [MethodImpl(Inline), Op]
        public static uint render(uint5 src, ref uint i, Span<C> dst)
            => BitRender.render(n5, src, ref i, dst);

        [MethodImpl(Inline), Op]
        public static uint render(uint6 src, ref uint i, Span<C> dst)
            => BitRender.render(n6, src, ref i, dst);
    }
}