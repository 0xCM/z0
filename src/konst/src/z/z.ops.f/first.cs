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
        public static ref T first<T>(Span<T> src)
            => ref memory.first(src);

        [MethodImpl(Inline)]
        public static ref readonly char first(ReadOnlySpan<char> src)
            => ref memory.first(src);

        [MethodImpl(Inline)]
        public static ref readonly T first<T>(ReadOnlySpan<T> src)
            => ref memory.first(src);

        [MethodImpl(Inline)]
        public static ref T first<T>(T[] src)
            => ref memory.first(src);
    }
}