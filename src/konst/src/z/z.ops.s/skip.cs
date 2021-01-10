//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, byte count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, ushort count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, uint count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, ulong count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(in T src, long count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(T[] src, double count)
            => throw no<T>();

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, byte count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, ushort count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, uint count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, ulong count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(ReadOnlySpan<T> src, long count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, byte count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, ushort count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, uint count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, ulong count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(Span<T> src, long count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(T[] src, byte count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(T[] src, ushort count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(T[] src, uint count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(T[] src, ulong count)
            => ref memory.skip(src,count);

        [MethodImpl(Inline)]
        public static ref readonly T skip<T>(T[] src, long count)
            => ref memory.skip(src,count);
    }
}