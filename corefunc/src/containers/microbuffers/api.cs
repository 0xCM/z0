//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class MicroBuffers
    {

        [MethodImpl(NotInline)]
        public static Stacked<byte> bytestack(int capacity)
            => new Stacked<byte>(new byte[capacity]);

        [MethodImpl(NotInline)]
        public static Stacked<T> stack<T>(int capacity)
            where T : unmanaged
                => new Stacked<T>(new T[capacity]);

        [MethodImpl(Inline)]
        public static Stacked<T> stack<T>(Span<T> src)
            where T : unmanaged
                => new Stacked<T>(src);

        [MethodImpl(Inline)]
        public static BitStack bitstack(ulong state = 0)
            => new BitStack(state);

        [MethodImpl(NotInline)]
        public static RingBuffer<T> ring<T>(int capacity)
            where T : unmanaged
                => new RingBuffer<T>(new T[capacity]);

        [MethodImpl(Inline)]
        public static RingBuffer<T> ring<T>(Span<T> src)
            where T : unmanaged
                => new RingBuffer<T>(src);

        [MethodImpl(Inline)]
        public static PartRing<S,T> parts<S,T>(int capacity)
            where S : unmanaged
            where T : unmanaged
                => new PartRing<S,T>(new S[capacity]);

        [MethodImpl(Inline)]
        public static PartRing<S,T> parts<S,T>(Span<S> src)
            where S : unmanaged
            where T : unmanaged
                => new PartRing<S,T>(src);

    }

}