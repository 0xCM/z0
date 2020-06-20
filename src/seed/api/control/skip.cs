//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, byte count)
            => ref Imagine.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, byte count)
            => ref Imagine.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, byte count)
            => ref Imagine.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, int count)
            => ref Imagine.skip(src, count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
            => ref Imagine.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, int count)
            => ref Imagine.skip(src,count);
    }
}