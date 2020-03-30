//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Core;

    [ApiHost]
    public static class SpanBuffers
    {
        public static SpanStack<T> stack<T>(int capacity)
            where T : unmanaged
                => new SpanStack<T>(new T[capacity]);

        public static RingBuffer<T> ring<T>(int capacity)
            where T : unmanaged
                => new RingBuffer<T>(new T[capacity]);

        public static PartRing<S,T> parts<S,T>(int capacity)
            where S : unmanaged
            where T : unmanaged
                => new PartRing<S,T>(new S[capacity]);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static SpanStack<T> stack<T>(Span<T> src)
            where T : unmanaged
                => new SpanStack<T>(src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static RingBuffer<T> ring<T>(Span<T> src)
            where T : unmanaged
                => new RingBuffer<T>(src);

        [MethodImpl(Inline)]
        public static PartRing<S,T> parts<S,T>(Span<S> src)
            where S : unmanaged
            where T : unmanaged
                => new PartRing<S,T>(src);
    }
}