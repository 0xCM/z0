//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool has<T>(ReadOnlySpan<T> src, N1 n)
            => src.Length >= 1;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool has<T>(ReadOnlySpan<T> src, N2 n)
            => src.Length >= 2;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool has<T>(ReadOnlySpan<T> src, N3 n)
            => src.Length >= 3;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool has<T>(ReadOnlySpan<T> src, N4 n)
            => src.Length >= 4;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool has<T>(ReadOnlySpan<T> src, N5 n)
            => src.Length >= 5;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool has<T>(ReadOnlySpan<T> src, N6 n)
            => src.Length >= 6;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool has<T>(ReadOnlySpan<T> src, N7 n)
            => src.Length >= 7;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static bool has<T>(ReadOnlySpan<T> src, N8 n)
            => src.Length >= 8;
    }
}