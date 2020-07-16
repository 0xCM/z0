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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, byte count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, ushort count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, uint count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, ulong count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, long count)
            => ref skip(in first(src), count);
    
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(Span<T> src, byte count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(Span<T> src, ushort count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(Span<T> src, uint count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref readonly T skip<T>(Span<T> src, ulong count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, long count)
            => ref skip(in first(src), count);
    }
}