//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static Span<char> span16c<T>(in T src)
            where T : struct
                => memory.span16c(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> span16c(ReadOnlySpan<byte> src)
            => memory.span16c(src);
    }
}