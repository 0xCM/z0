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
        public static ReadOnlySpan<T> @readonly<T>(Span<T> src)
            => memory.@readonly(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> @readonly<T>(T[] src)
            => memory.@readonly(src);
    }
}